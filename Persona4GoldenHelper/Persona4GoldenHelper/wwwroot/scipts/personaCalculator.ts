document.addEventListener('DOMContentLoaded', calculateRecipes);

interface Persona {
    name: string,
    arcana: string
    level?: number;
};

interface ArcanaFusionResult {
    sourceArcanas: Arcana[],
    resultArcana: string
};

interface Arcana {
    arcanaName : string
}

interface SpecialFusionResult {
    sourcePersonas: string[],
    resultPersona: string
};

interface Recipe {
    IngredientPersonas: Persona[],
    Cost?: string
};

let TargetPersona: Persona;
let Personas: Persona[];
let Arcana2FusionResults: ArcanaFusionResult[];
let Arcana3FusionResults: ArcanaFusionResult[];
let SpecialFusionResults: SpecialFusionResult[];
let Recipes: Recipe[] = [];

/// Api functions
function getPersonaByName(name: string): Persona {
    for (let persona of Personas) {
        if (persona.name.toLowerCase() === name) {
            return persona;
        }
    }

    return null;
}

function getPersonasByArcana(arcana: string): Persona[] {
    let personas: Persona[] = [];

    for (let persona of Personas) {
        if (persona.arcana === arcana) {
            personas.push(persona);
        }
    }

    return personas;
}

function isPersonaSpecial(persona: Persona): boolean {
    let recipe = getSpecialRecipe(persona);
    return recipe != null;
}

/// Get fusion data
function getPersonaInfo() {
    let name = document.getElementById('target-persona-name').innerText;
    let arcana = document.getElementById('target-persona-arcana').innerText;

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

    alert(Recipes.length);
}

function getRecipes() {
    // check if the persona is made through a special recipe
    var specialRecipe = getSpecialRecipe(TargetPersona);
    if (specialRecipe != null) {
        Recipes.push(specialRecipe);
        return
    }

    // check for 2 persona fusions
    var twoPersonaRecipes = get2PersonaRecipes();
    for (let twoPersonaRecipe of twoPersonaRecipes) {
        Recipes.push(twoPersonaRecipe);
    }

    // check for 3 persona fusions
}

function getSpecialRecipe(persona: Persona): Recipe {
    let recipe: Recipe;

    for (let specialFusionResult of SpecialFusionResults) {
        if (specialFusionResult.resultPersona.toLowerCase() == persona.name.toLowerCase()) {
            let recipe: Recipe;

            for (let ingredientPersona of specialFusionResult.sourcePersonas) {
                let persona: Persona = getPersonaByName(ingredientPersona)
                if (persona == null) {
                    console.log(`ERROR: No persona with the name: ${ingredientPersona} could be found.`)
                    continue;
                }

                recipe.IngredientPersonas.push(persona);
            }

            return recipe;
        }
    }

    return null;
}

function get2PersonaRecipes(): Recipe[] {
    let recipes: Recipe[] = [];

    // get all arcana fusions that result in the target persona arcana
    let arcanaFusions: ArcanaFusionResult[] = [];
    for (let arcanaFusion of Arcana2FusionResults) {
        if (arcanaFusion.resultArcana.toLowerCase() === TargetPersona.arcana.toLowerCase()) {
            arcanaFusions.push(arcanaFusion);
        }
    }

    // get all possible persona from both arcanas and try to combine them all, then check if the output persona if the target persona
    for (let arcanaFusion of arcanaFusions) {
        let arcana1Personas: Persona[] = getPersonasByArcana(arcanaFusion.sourceArcanas[0].arcanaName);
        let arcana2Personas: Persona[] = getPersonasByArcana(arcanaFusion.sourceArcanas[1].arcanaName);

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

                let valid: Boolean = is2PersonaFusionValid(arcana1Persona, arcana2Persona, resultPersona)
                if (!valid) {
                    continue;
                }

                let recipe: Recipe = { IngredientPersonas: [arcana1Persona, arcana2Persona] }
                recipes.push(recipe);
            }
        }
    }

    return recipes;
}

function fuse2Personas(resultArcana: string, persona1: Persona, persona2: Persona): Persona {
    let level: number = 1 + Math.floor((persona1.level + persona2.level) / 2);
    let personas = getPersonasByArcana(resultArcana);

    for (var i = 0; i < personas.length; i++) {
        let persona = personas[i]

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

function fuse3Personas(resultArcana: string, persona1: Persona, persona2: Persona, persona3: Persona) {

}

function is2PersonaFusionValid(persona1: Persona, persona2: Persona, resultPersona: Persona): boolean {
    if (persona1.name === resultPersona.name) {
        return false;
    }

    if (persona2.name === resultPersona.name) {
        return false;
    }

    if (resultPersona.name === TargetPersona.name) {
        return true;
    }

    return false;
}