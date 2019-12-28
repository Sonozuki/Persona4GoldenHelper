document.addEventListener('DOMContentLoaded', calculateRecipes);
;
;
;
;
var TargetPersona;
var Personas;
var Arcanas;
var Arcana2FusionResults;
var Arcana3FusionResults;
var SpecialFusionResults;
var Recipes = [];
/// Api functions
function getPersonaByName(name) {
    for (var _i = 0, Personas_1 = Personas; _i < Personas_1.length; _i++) {
        var persona = Personas_1[_i];
        if (persona.name.toLowerCase() === name.toLowerCase()) {
            return persona;
        }
    }
    return null;
}
function getPersonasByArcana(arcana) {
    var personas = [];
    for (var _i = 0, Personas_2 = Personas; _i < Personas_2.length; _i++) {
        var persona = Personas_2[_i];
        if (persona.arcana === arcana) {
            personas.push(persona);
        }
    }
    return personas;
}
function isPersonaSpecial(persona) {
    var recipe = getSpecialRecipe(persona);
    return recipe != null;
}
function getArcanaRank(targetArcana) {
    for (var i = 0; i < Arcanas.length; i++) {
        var arcana = Arcanas[i];
        if (targetArcana === arcana.arcanaName) {
            return i;
        }
    }
    return 0;
}
/// Get fusion data
function getPersonaInfo() {
    var name = document.getElementById('target-persona-name').innerText;
    var arcana = document.getElementById('target-persona-arcana').innerText;
    TargetPersona = {
        name: name,
        arcana: arcana
    };
}
function getFusionInfo() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (xhttp.readyState == 4) {
            if (xhttp.status == 200) {
                console.log('Successfully got persona list');
                Personas = JSON.parse(xhttp.response);
            }
            else {
                console.log('Failed to get persona list');
            }
        }
    };
    xhttp.open("GET", "/api/GetAllPersonas", false);
    xhttp.send();
    xhttp.onreadystatechange = function () {
        if (xhttp.readyState == 4) {
            if (xhttp.status == 200) {
                console.log('Successfully got arcana list');
                Arcanas = JSON.parse(xhttp.response);
            }
            else {
                console.log('Failed to get arcana list');
            }
        }
    };
    xhttp.open("GET", "/api/GetAllArcanas", false);
    xhttp.send();
    xhttp.onreadystatechange = function () {
        if (xhttp.readyState == 4) {
            if (xhttp.status == 200) {
                console.log('Successfully got arcana 2 fusion list');
                Arcana2FusionResults = JSON.parse(xhttp.response);
            }
            else {
                console.log('Failed to get arcana 2 fusion list');
            }
        }
    };
    xhttp.open("GET", "/api/GetAllArcana2FusionResults", false);
    xhttp.send();
    xhttp.onreadystatechange = function () {
        if (xhttp.readyState == 4) {
            if (xhttp.status == 200) {
                console.log('Successfully got arcana 3 fusion list');
                Arcana3FusionResults = JSON.parse(xhttp.response);
            }
            else {
                console.log('Failed to get arcana 3 fusion list');
            }
        }
    };
    xhttp.open("GET", "/api/GetAllArcana3FusionResults", false);
    xhttp.send();
    xhttp.onreadystatechange = function () {
        if (xhttp.readyState == 4) {
            if (xhttp.status == 200) {
                console.log('Successfully got special fusion list');
                SpecialFusionResults = JSON.parse(xhttp.response);
            }
            else {
                console.log('Failed to get special fusion list');
            }
        }
    };
    xhttp.open("GET", "/api/GetAllSpecialFusionResults", false);
    xhttp.send();
}
/// Calculate recipes
function calculateRecipes() {
    getPersonaInfo();
    getFusionInfo();
    getRecipes();
}
function getRecipes() {
    // check if the persona is made through a special recipe
    var specialRecipe = getSpecialRecipe(TargetPersona);
    if (specialRecipe != null) {
        Recipes.push(specialRecipe);
        return;
    }
    // check for 2 persona fusions
    var twoPersonaRecipes = get2PersonaRecipes(TargetPersona.arcana, true);
    for (var _i = 0, twoPersonaRecipes_1 = twoPersonaRecipes; _i < twoPersonaRecipes_1.length; _i++) {
        var twoPersonaRecipe = twoPersonaRecipes_1[_i];
        Recipes.push(twoPersonaRecipe);
    }
    console.log("after 2 persona fusions: " + Recipes.length);
    // check for 3 persona fusions
    var threePersonaRecipes = get3PersonaRecipes();
    for (var _a = 0, threePersonaRecipes_1 = threePersonaRecipes; _a < threePersonaRecipes_1.length; _a++) {
        var threePersonaRecipe = threePersonaRecipes_1[_a];
        Recipes.push(threePersonaRecipe);
    }
    console.log("after 3 persona fusions: " + Recipes.length);
}
function getSpecialRecipe(persona) {
    for (var _i = 0, SpecialFusionResults_1 = SpecialFusionResults; _i < SpecialFusionResults_1.length; _i++) {
        var specialFusionResult = SpecialFusionResults_1[_i];
        if (specialFusionResult.resultPersona.toLowerCase() == persona.name.toLowerCase()) {
            var recipe = { IngredientPersonas: [] };
            for (var _a = 0, _b = specialFusionResult.sourcePersonas; _a < _b.length; _a++) {
                var ingredientPersona = _b[_a];
                var persona_1 = getPersonaByName(ingredientPersona.personaName);
                if (persona_1 == null) {
                    console.log("ERROR: No persona with the name: " + ingredientPersona.personaName + " could be found.");
                    continue;
                }
                recipe.IngredientPersonas.push(persona_1);
            }
            return recipe;
        }
    }
    return null;
}
function get2PersonaRecipes(arcana, validate) {
    var recipes = [];
    // get all arcana fusions that result in the target persona arcana
    var arcanaFusions = [];
    for (var _i = 0, Arcana2FusionResults_1 = Arcana2FusionResults; _i < Arcana2FusionResults_1.length; _i++) {
        var arcanaFusion = Arcana2FusionResults_1[_i];
        if (arcanaFusion.resultArcana.toLowerCase() === arcana.toLowerCase()) {
            arcanaFusions.push(arcanaFusion);
        }
    }
    // get all possible persona from both arcanas and try to combine them all, then check if the output persona if the target persona
    for (var _a = 0, arcanaFusions_1 = arcanaFusions; _a < arcanaFusions_1.length; _a++) {
        var arcanaFusion = arcanaFusions_1[_a];
        var arcana1Personas = getPersonasByArcana(arcanaFusion.sourceArcanas[0].arcanaName);
        var arcana2Personas = getPersonasByArcana(arcanaFusion.sourceArcanas[1].arcanaName);
        for (var i = 0; i < arcana1Personas.length; i++) {
            var arcana1Persona = arcana1Personas[i];
            for (var j = 0; j < arcana2Personas.length; j++) {
                var arcana2Persona = arcana2Personas[j];
                if (arcana1Persona.arcana === arcana2Persona.arcana && j <= i) {
                    continue;
                }
                var resultPersona = fuse2Personas(arcanaFusion.resultArcana, arcana1Persona, arcana2Persona);
                if (resultPersona == null) {
                    continue;
                }
                if (validate) {
                    var valid = is2PersonaFusionValid(arcana1Persona, arcana2Persona, resultPersona);
                    if (!valid) {
                        continue;
                    }
                }
                var recipe = { IngredientPersonas: [arcana1Persona, arcana2Persona] };
                recipes.push(recipe);
            }
        }
    }
    return recipes;
}
function get3PersonaRecipes() {
    var recipes = [];
    // get all 3 persona arcana fusion results that result in the target persona arcana
    var arcanaFusions = [];
    for (var _i = 0, Arcana3FusionResults_1 = Arcana3FusionResults; _i < Arcana3FusionResults_1.length; _i++) {
        var arcanaFusion = Arcana3FusionResults_1[_i];
        if (arcanaFusion.resultArcana.toLowerCase() === TargetPersona.arcana.toLowerCase()) {
            arcanaFusions.push(arcanaFusion);
        }
    }
    // for each arcana fusion, consider either the intermediate parent
    for (var _a = 0, arcanaFusions_2 = arcanaFusions; _a < arcanaFusions_2.length; _a++) {
        var arcanaFusion = arcanaFusions_2[_a];
        var step1Recipes = get2PersonaRecipes(arcanaFusion.sourceArcanas[0].arcanaName, false);
        for (var _b = 0, step1Recipes_1 = step1Recipes; _b < step1Recipes_1.length; _b++) {
            var step1Recipe = step1Recipes_1[_b];
            var persona1 = step1Recipe.IngredientPersonas[0];
            var persona2 = step1Recipe.IngredientPersonas[1];
            var personas = getPersonasByArcana(arcanaFusion.sourceArcanas[1].arcanaName);
            for (var _c = 0, personas_1 = personas; _c < personas_1.length; _c++) {
                var persona3 = personas_1[_c];
                var valid = is3PersonaFusionValid(persona1, persona2, persona3);
                if (!valid) {
                    continue;
                }
                var resultPersona = fuse3Personas(TargetPersona.arcana, persona1, persona2, persona3);
                if (resultPersona == null) {
                    continue;
                }
                if (resultPersona.name != TargetPersona.name) {
                    continue;
                }
                var recipe = { IngredientPersonas: [persona1, persona2, persona3] };
                recipes.push(recipe);
            }
        }
    }
    return recipes;
}
function fuse2Personas(resultArcana, persona1, persona2) {
    var level = 1 + Math.floor((persona1.level + persona2.level) / 2);
    var personas = getPersonasByArcana(resultArcana);
    for (var i = 0; i < personas.length; i++) {
        var persona = personas[i];
        if (persona.level >= level) {
            if (isPersonaSpecial(persona)) {
                continue;
            }
            break;
        }
    }
    if (persona1.arcana == persona2.arcana) {
        i--;
    }
    if (personas[i] == persona1 || personas[i] == persona2) {
        i--;
    }
    return personas[i];
}
function fuse3Personas(resultArcana, persona1, persona2, persona3) {
    var level = 5 + Math.floor((persona1.level + persona2.level + persona3.level) / 3);
    var personas = getPersonasByArcana(resultArcana);
    // ensure there is a persona in that arcana with a level that is valid
    var found = false;
    for (var i = 0; i < personas.length; i++) {
        var persona = personas[i];
        if (persona.level >= level) {
            found = true;
            break;
        }
    }
    if (!found) {
        return null;
    }
    if (persona1.arcana === resultArcana && persona2.arcana === resultArcana && persona3.arcana === resultArcana) {
        while (persona1.name === personas[i].name || persona2.name === personas[i].name || persona3.name === personas[i].name) {
            i++;
            if (personas[i] == null) {
                return null;
            }
        }
    }
    return personas[i];
}
function is2PersonaFusionValid(persona1, persona2, resultPersona) {
    if (persona1.name === TargetPersona.name) {
        return false;
    }
    if (persona2.name === TargetPersona.name) {
        return false;
    }
    if (resultPersona.name === TargetPersona.name) {
        return true;
    }
    return false;
}
function is3PersonaFusionValid(persona1, persona2, persona3) {
    if (persona1.name === persona3.name || persona2.name === persona3.name) {
        return false;
    }
    if (persona1.level > persona3.level || persona2.level > persona3.level) {
        return false;
    }
    if (persona1.level === persona3.level) {
        return getArcanaRank(persona1.arcana) > getArcanaRank(persona3.arcana);
    }
    if (persona2.level === persona3.level) {
        return getArcanaRank(persona2.arcana) > getArcanaRank(persona3.arcana);
    }
    return true;
}
//# sourceMappingURL=personaCalculator.js.map