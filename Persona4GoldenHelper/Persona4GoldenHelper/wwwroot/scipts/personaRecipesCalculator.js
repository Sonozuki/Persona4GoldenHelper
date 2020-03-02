$(document).ready(calculateRecipes);

let TargetPersona;
let Personas = [];
let Arcanas = [];
let Arcana2FusionResults = [];
let Arcana3FusionResults = [];
let SpecialFusionResults = [];
let Recipes = [];

// Api functions
function getPersonaByName(name) {
    for (let persona of Personas) {
        if (persona.name.toLowerCase() === name.toLowerCase()) {
            return persona;
        }
    }

    return null;
}

function getPersonasByArcana(arcana) {
    let personas = [];

    for (let persona of Personas) {
        if (persona.arcana === arcana) {
            personas.push(persona);
        }
    }

    return personas;
}

function isPersonaSpecial(persona) {
    let recipe = getSpecialRecipe(persona);
    return recipe !== null;
}

function getArcanaRank(targetArcana) {
    for (let i = 0; i < Arcanas.length; i++) {
        let arcana = Arcanas[i];
        if (arcana.name === targetArcana) {
            return i;
        }
    }

    return 0;
}

/// Get fusion recipes functions
function getPersonaInfo() {
    let name = $('#target-persona-name')[0].innerText;
    let arcana = $('#target-persona-arcana')[0].innerText;

    TargetPersona = {
        name: name,
        arcana: arcana
    };
}

/// Calculate recipes functions
function calculateRecipes() {
    getPersonaInfo();

    $.when($.ajax('/api/GetAllPersonas'), $.ajax('/api/GetAllArcanas'), $.ajax('/api/GetAllArcana2FusionResults'), $.ajax('/api/GetAllArcana3FusionResults'), $.ajax('/api/GetAllSpecialFusionResults'))
        .done(function (personas, arcanas, arcana2FusionResults, arcana3FusionResults, specialFusionResults) {
            Personas = personas[0];
            Arcanas = arcanas[0];
            Arcana2FusionResults = arcana2FusionResults[0];
            Arcana3FusionResults = arcana3FusionResults[0];
            SpecialFusionResults = specialFusionResults[0];

            // once data has been received, start calculating recipes
            getRecipes();

            populateRecipeCount();
            calculateRecipeCosts();
            sortRecipes();
            populateRecipeTable();
        });
}

function getRecipes() {
    // check if the persona is made through a special recipe
    let specialRecipe = getSpecialRecipe(TargetPersona);
    if (specialRecipe !== null) {
        Recipes.push(specialRecipe);
        return;
    }

    // check for 2 persona fusions
    let twoPersonaRecipes = get2PersonaRecipes(TargetPersona.arcana, true);
    for (let twoPersonaRecipe of twoPersonaRecipes) {
        Recipes.push(twoPersonaRecipe);
    }

    // check for 3 persona fusions
    let threePersonaRecipes = get3PersonaRecipes();
    for (let threePersonaRecipe of threePersonaRecipes) {
        Recipes.push(threePersonaRecipe);
    }
}

function getSpecialRecipe(persona) {
    for (let specialFusionResult of SpecialFusionResults) {
        if (specialFusionResult.resultPersona.toLowerCase() === persona.name.toLowerCase()) {
            let recipe = { ingredientPersonas: [] };

            for (let ingredientPersona of specialFusionResult.sourcePersonas) {
                let persona = getPersonaByName(ingredientPersona.name);
                if (persona == null) {
                    console.log(`ERROR: No persona with the name: ${ingredientPersona.name} could be found.`);
                    continue;
                }

                recipe.ingredientPersonas.push(persona);
            }

            return recipe;
        }
    }

    return null;
}

function get2PersonaRecipes(arcana, validate) {
    let recipes = [];

    // get all arcana fusions that result in the target persona arcana
    let arcanaFusions = [];
    for (let arcanaFusion of Arcana2FusionResults) {
        if (arcanaFusion.resultArcana.toLowerCase() === arcana.toLowerCase()) {
            arcanaFusions.push(arcanaFusion);
        }
    }

    // get all possible persona from both arcanas and try to combine them all, then check if the output persona if the target persona
    for (let arcanaFusion of arcanaFusions) {
        let arcana1Personas = getPersonasByArcana(arcanaFusion.sourceArcanas[0].name);
        let arcana2Personas = getPersonasByArcana(arcanaFusion.sourceArcanas[1].name);

        for (let i = 0; i < arcana1Personas.length; i++) {
            let arcana1Persona = arcana1Personas[i];

            for (let j = 0; j < arcana2Personas.length; j++) {
                let arcana2Persona = arcana2Personas[j];

                if (arcana1Persona.arcana === arcana2Persona.arcana && j <= i) {
                    continue;
                }

                let resultPersona = fuse2Personas(arcanaFusion.resultArcana, arcana1Persona, arcana2Persona);
                if (resultPersona == null) {
                    continue;
                }

                if (validate) {
                    let valid = is2PersonaFusionValid(arcana1Persona, arcana2Persona, resultPersona);
                    if (!valid) {
                        continue;
                    }
                }

                let recipe = { ingredientPersonas: [arcana1Persona, arcana2Persona] };
                recipes.push(recipe);
            }
        }
    }

    return recipes;
}

function get3PersonaRecipes() {
    let recipes = [];

    // get all 3 persona arcana fusion results that result in the target persona arcana
    let arcanaFusions = [];
    for (let arcanaFusion of Arcana3FusionResults) {
        if (arcanaFusion.resultArcana.toLowerCase() === TargetPersona.arcana.toLowerCase()) {
            arcanaFusions.push(arcanaFusion);
        }
    }

    // for each arcana fusion, consider either the intermediate parent
    for (let arcanaFusion of arcanaFusions) {
        let step1Recipes = get2PersonaRecipes(arcanaFusion.sourceArcanas[0].name, false);

        for (let step1Recipe of step1Recipes) {
            let persona1 = step1Recipe.ingredientPersonas[0];
            let persona2 = step1Recipe.ingredientPersonas[1];
            let personas = getPersonasByArcana(arcanaFusion.sourceArcanas[1].name);

            for (let persona3 of personas) {

                let valid = is3PersonaFusionValid(persona1, persona2, persona3);
                if (!valid) {
                    continue;
                }

                let resultPersona = fuse3Personas(TargetPersona.arcana, persona1, persona2, persona3);
                if (resultPersona == null) {
                    continue;
                }

                if (resultPersona.name !== TargetPersona.name) {
                    continue;
                }

                let recipe = { ingredientPersonas: [persona1, persona2, persona3] };
                recipes.push(recipe);
            }
        }
    }

    return recipes;
}

function fuse2Personas(resultArcana, persona1, persona2) {
    let level = 1 + Math.floor((persona1.level + persona2.level) / 2);
    let personas = getPersonasByArcana(resultArcana);

    for (var i = 0; i < personas.length; i++) {
        let persona = personas[i];

        if (persona.level >= level) {
            if (isPersonaSpecial(persona)) {
                continue;
            }

            break;
        }
    }

    if (persona1.arcana === persona2.arcana) {
        i--;
    }
    if (personas[i] === persona1 || personas[i] === persona2) {
        i--;
    }

    return personas[i];
}

function fuse3Personas(resultArcana, persona1, persona2, persona3) {
    let level = 5 + Math.floor((persona1.level + persona2.level + persona3.level) / 3);
    let personas = getPersonasByArcana(resultArcana);

    // ensure there is a persona in that arcana with a level that is valid
    let found = false;
    for (var i = 0; i < personas.length; i++) {
        let persona = personas[i];

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

/// Display data functions
function populateRecipeCount() {
    $('#recipe-count')[0].innerText = Recipes.length.toString();
}

function calculateRecipeCosts() {
    for (let i = 0; i < Recipes.length; i++) {
        Recipes[i].cost = 0;

        for (let ingredientPersona of Recipes[i].ingredientPersonas) {
            Recipes[i].cost += (27 * ingredientPersona.level * ingredientPersona.level) + (126 * ingredientPersona.level) + 2147;
        }
    }
}

function sortRecipes() {
    Recipes.sort(function (a, b) { return a.cost - b.cost; });

    for (let recipe of Recipes) {
        recipe.ingredientPersonas.sort(function (a, b) { return b.level - a.level; });
    }
}

function populateRecipeTable() {
    let recipeTable = $('#recipe-table tbody');
    // this is to add support for the 'see more' button on the recipe scroll. use the current recipe count as the start point and render the next 100 records
    let currentRecipesCount = recipeTable[0].children.length;

    for (let i = currentRecipesCount; i < Recipes.length && i < currentRecipesCount + 100; i++) {
        let recipe = Recipes[i];

        let costCellValue = `¥${recipe.cost}`;
        let personaCellValue = '';

        for (let persona of recipe.ingredientPersonas) {
            let personaType = '';
            if (persona.ultimate) {
                personaType = 'type-ultimate';
            }
            else if (persona.newGame) {
                personaType = 'type-new-game';
            }

            personaCellValue += `
            <a class="padding-right" href="${persona.name}">
                <span class="${personaType}">
                    ${persona.name}
                </span>
                (<span class="text-secondary">${persona.level.toString()}</span>/<span class="text-secondary">${persona.arcana}</span>)
            </a>
            <br class="desktop-hidden" />`;
        }

        let recipeRow = `<tr><td>${costCellValue}</td><td>${personaCellValue}</td></tr>`;
        recipeTable.append(recipeRow);
    }

    let seeMoreButton = $('#see-more-recipes');
    if (Recipes.length === recipeTable[0].children.length) {
        seeMoreButton.hide();
    }
}