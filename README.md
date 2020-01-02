**Persona4GoldenHelper** is an [ASP.Net Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2) web app to bring all the important information for [Persona 4 Golden](https://en.wikipedia.org/wiki/Persona_4#Persona_4_Golden_2) into one place. See at: http://www.persona4goldenhelper.co.uk/

## Current Pages
* **Personas** - This page lists all available personas in the game, it also shows their: arcana, level, stats, and element affinities. Clicking on one of the persona names will bring you to that persona's page, this contains the above as well as skills that personas has.
* **Skills** - This page lists all the skills that are available to get on personas, it also shows their: effect, cost, and all personas that can have these skills, including the level the personas require to unlock them (this only includes skills the base personas can have, meaning other personas can have these skills through inheritance with fusion).
* **Books** - This page lists all the books in the game, it also shows: the date required to obtain them, how to obtain them, their price, and their effect. This page also contains the order at which the books appear your inventory (to make checking missing books easier)
* **Accessories** - This page lists all accessories in the game, it also shows their: effect, price, and how to obtain them.
* **Exam Answers** - This page lists all the exam questions and correct answers, it also shows the date you will be asked the question.
* **Quests** - This page lists all the quests available in the game, it also shows: the quest giver, where the quest giver is, the date you can start the quest, any prerequisities for starting the quest, the reward, and how to complete the quest.
* **Shadows** - This page lists all available shadows in the game, it also shows their: type (whether they are a normal shadow, mini boss, or boss), level, stats, and element affinities. Clicking on one of the shadow names will bring you to the shadow's page, this contains the above as well as the skills the shadow has.
* **Lunches** - This page lists all the lunches you can make, as well as the correct method to make them properly.
* **Skill Cards** - This page lists all the skill cards available in the game, it also shows: their rank, and where to grind to get specific cards.

## Planned Pages
* **Calender** - This page will contain: the weather, times skips, exam dates, and social link availability for each day.
* **Weapons** - This page will contain all the weapons available in the game, sorted by user. It will also show their: attack, accuracy, effect, price, and how to obtain them.
* **Armor** - This page will contain all the armor available in the game, sorted by type (male, female, unisex). It will also show their: evade, defense, effect, price, and how to obtain them.
* **Costumes** - This page will contain all the constumes in the game, with their price and how to obtain them.
* **Gardening** - This page will contain all the plants you can grow in the garden, as well as their products and the effects of those products.
* **Items** - This page will contain all the items in the game (excluding accessories, weapons, and armor as they have dedicated pages), including their effect, and cost
* **Social Links** - This page will contain all the social links available in the game, as well as the results from each dialogue option you can choose in them.
* **Dungeons** - This page will contain all the dungeons. Each dungeon will have a seperate page that includes: how to access it, the floor layout for static floors, info on the: mini boss, main boss, and optional boss, and how to obtain items that are required to go further in the dungeon.

## API
All apis avilable internally in the app have been exposed, through the '/Api/{function}' url. Info on each can be found below, including: request type, required params, return summary, possible returned HTTP codes, and return data model.

### GetAllBooks
* **Expects**: GET request, with no params.
* **Return Summary**: Return all books stored in the database in the below data model.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
[
    {
        "id": -1,
        "dateAvailable": "",
        "title": "",
        "requirement": "",
        "effect": ""
    }, ...
]
```

### GetBookOrder
* **Expects**: GET request, with no params.
* **Return Summary**: Returns the book names in the order that appears in the players inventory.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
[
    {
        "id": -1,
        "bookName": ""
    }, ...
]
```

### GetAllExamAnswers
* **Expects**: GET request, with no params.
* **Return Summary**: Return all exam answers stored in the database in the below data model.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
[
    {
        "id": -1,
        "month": -1,
        "dateAsked": "",
        "questionAsked": "",
        "questionAnswer": ""
    }, ...
]
```

### GetSkillsByPersona
This is being rewritten to not require a persona object. Documentation will be added once that is changed

### GetSkillsByShadow
This is being rewritten to not require a shadow object. Documentation will be added once that is changed

### GetAllQuests
* **Expects**: GET request, with no params.
* **Return Summary**: Return all quests stored in the database in the below data model.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
[
    {
        "id": -1,
        "number": -1,
        "title": "",
        "questGiver": "",
        "location": "",
        "dateAvailable": "",
        "prerequisites": "",
        "reward": "",
        "instructions": ""
    }, ...
]
```

### GetAllSkillCards
* **Expects**: GET request, with no params.
* **Return Summary**: Return all skill cards stored in the database in the below data model.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
[
    {
        "id": -1,
        "type": -1,
        "name": "",
        "rank": -1
    }, ...
]
```

### GetAllSkillCardLocations
* **Expects**: GET request, with no params.
* **Return Summary**: Return all skill card locations stored in the database in the below data model.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
[
    {
        "id": -1,
        "dungeonName": "",
        "rankLowerBound": -1,
        "rankUpperBound": -1
    }, ...
]
```

### GetAllLunches
* **Expects**: GET request, with no params.
* **Return Summary**: Return all lunches stored in the database in the below data model.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
[
    {
        "id": -1,
        "name": "",
        "method": ""
    }, ...
]
```

### GetAllSources
* **Expects**: GET request, with no params.
* **Return Summary**: Return all sources stored in the database in the below data model, these sources are the data sources for the site, the links on the home page.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
[
    {
        "id": -1,
        "information": "",
        "links": [
            {
                "id": -1,
                "url": ""
            }, ...
        ]
    }, ...
]
```

### GetAllAccessories
* **Expects**: GET request, with no params.
* **Return Summary**: Return all accessories stored in the database in the below data model.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
[
    {
        "id": 1,
        "name": "",
        "effect": "",
        "obtained": [
            {
                "id": -1,
                "obtain": "",
                "price": ""
            }, ...
        ]
    }, ...
]
```

### GetAllPersonas
* **Expects**: GET request, with no params.
* **Return summary**: Return all personas stored in the database in the below data model.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
[
    {
        "id": -1,
        "name": "",
        "arcana": "",
        "level": -1,
        "stats": {
            "id": -1,
            "strength": -1,
            "magic": -1,
            "endurance": -1,
            "agility": -1,
            "luck": -1
        },
        "elements": {
            "id": -1,
            "physical": -1,
            "fire": -1,
            "ice": -1,
            "electricity": -1,
            "wind": -1,
            "light": -1,
            "darkness": -1
        },
        "skills": null,
        "ultimate": false,
        "newGame": false
    }, ...
]
```

### GetPersonaByName
* **Expects**: GET request, with a parameter called 'name', type string, containing the persona name.
* **Return Summary**: Returns the full persona object from the passed name.
* **Return HTTP codes**: 200, 204, 406, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game)
```json
{
    "id": -1,
    "name": "",
    "arcana": "",
    "level": -1,
    "stats": {
        "id": -1,
        "strength": -1,
        "magic": -1,
        "endurance": -1,
        "agility": -1,
        "luck": -1
    },
    "elements": {
        "id": -1,
        "physical": -1,
        "fire": -1,
        "ice": -1,
        "electricity": -1,
        "wind": -1,
        "light": -1,
        "darkness": -1
    },
    "skills": [
        {
            "id": -1,
            "name": "",
            "levelRequired": -1
        }, ...
    ],
    "ultimate": false,
    "newGame": false
}
```

### GetAllShadows
* **Expects**: GET request, with no params.
* **Return summary**: Return all shadows stored in the database in the below data model.
* **Return HTTP codes**: 200, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game. FullSkills can be ignored, this is used to pass the full skill object to the shadow view, this will always return null from the api)
```json
[
    {
        "id": -1,
        "name": "",
        "level": -1,
        "hp": -1,
        "sp": -1,
        "exp": -1,
        "yen": "",
        "stats": {
            "id": -1,
            "strength": -1,
            "magic": -1,
            "endurance": -1,
            "agility": -1,
            "luck": -1
        },
        "elements": {
            "id": -1,
            "physical": -1,
            "fire": -1,
            "ice": -1,
            "electricity": -1,
            "wind": -1,
            "light": -1,
            "darkness": -1
        },
        "skills": null,
        "fullSkills": null,
        "type": -1
    }, ...
]
```

### GetShadowsByName
* **Expects**: GET request, with a parameter called 'name', type string, containing the shadow name.
* **Return Summary**: Returns the full shadow objects from the passed name. Multiple object may be returned, 1 for each type (normal, mini boss, boss).
* **Return HTTP codes**: 200, 204, 406, 500
* **Return data model**: (All ids are purely internal ids and have no relation to the game. FullSkills can be ignored, this is used to pass the full skill object to the shadow view, this will always return null from the api)
```json
[
    {
        "id": -1,
        "name": "",
        "level": -1,
        "hp": -1,
        "sp": -1,
        "exp": -1,
        "yen": "",
        "stats": {
            "id": -1,
            "strength": -1,
            "magic": -1,
            "endurance": -1,
            "agility": -1,
            "luck": -1
        },
        "elements": {
            "id": -1,
            "physical": -1,
            "fire": -1,
            "ice": -1,
            "electricity": -1,
            "wind": -1,
            "light": -1,
            "darkness": -1
        },
        "skills": [
            {
                "id": -1,
                "name": ""
            }, ...
        ],
        "fullSkills": null,
        "type": -1
    }, ...
]
```