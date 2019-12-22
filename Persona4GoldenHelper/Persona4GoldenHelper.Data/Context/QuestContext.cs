using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Context
{
    public class QuestContext
    {
        public List<Quest> Quests { get; } = new List<Quest>()
        {
            new Quest(
                id: 01,
                title: "Who's the Riddle Master!?",
                questGiver: "Funky Student",
                location: "Classroom Building 3F",
                dateAvailable: "04/18",
                prerequisites: "",
                reward: "Chest Key x3",
                instructions: "He will ask you 2 questions. The answers are: \"Group A\" and \"They're top 6 flag colors.\""
            ),
            new Quest(
                id: 02,
                title: "The Girl on the Rooftop",
                questGiver: "Male Student",
                location: "Classroom 2-2",
                dateAvailable: "04/25",
                prerequisites: "",
                reward: "Goho-m",
                instructions: "Go to the school roof and speak to the girl, select the 2nd dialogue option. Repeat this two more times on different days. She is not availble when it is rainy."
            ),
            new Quest(
                id: 03,
                title: "Acquire Mori Ranmaru Shochu",
                questGiver: "Man",
                location: "Samegawa Flood Plain",
                dateAvailable: "05/01",
                prerequisites: "",
                reward: "¥4000",
                instructions: "Go to the TV world and go inside Twisted Shopping District (Yosuke's dungeon). Then search the boxes in the room to obtain it. Then give the item to the quest giver."
            ),
            new Quest(
                id: 04,
                title: "Acquire an Angel Statue",
                questGiver: "Timid Female Student",
                location: "Classroom 2-2",
                dateAvailable: "05/02",
                prerequisites: "",
                reward: "Chest Key x3",
                instructions: "Go to the TV world and go inside The Castle (Yukiko's dungeon). Then defeat an enemy called \"Avenger Knight\" to have a chance to obtain it, they are typically found on floors 6-7. Then give the item to the quest giver."
            ),
            new Quest(
                id: 05,
                title: "Acquire a Demon Statue",
                questGiver: "Shady Student",
                location: "Classroom Building 2F",
                dateAvailable: "05/02",
                prerequisites: "",
                reward: "Dokudami Tea x3",
                instructions: "Go to the TV world and go inside The Castle (Yukiko's dungeon). Then defeat an enemy called \"Magical Magus\" to have a chance to obtain it, they are typically found on floors 6-7. Then give the item to the quest giver."
            ),
            new Quest(
                id: 06,
                title: "Acquire a Ritz Wire",
                questGiver: "Male Student",
                location: "Practice Building 1F",
                dateAvailable: "05/02",
                prerequisites: "",
                reward: "Olympic Tape",
                instructions: "Go to the TV world and go inside The Castle (Yukiko's dungeon). The defeat and enemy called \"Heat Balance\" to have a chance to obtain it, they are typically found on floors 6-7. Then give the item to the quest giver."
            ),
            new Quest(
                id: 07,
                title: "I Wish for Love",
                questGiver: "Fox",
                location: "Shrine",
                dateAvailable: "05/06",
                prerequisites: "",
                reward: "Hemit social link level up",
                instructions: "Take the ema from the fox. Talk to the female student in the Classroom Building 1F lobby. The next day she will be on 2F, tell her \"I read it\". The next day speak to her again at the same location. The report back to the fox."
            ),
            new Quest(
                id: 08,
                title: "I Wish I Didn't Crave Snacks",
                questGiver: "Fox",
                location: "Shrine",
                dateAvailable: "After 05/06",
                prerequisites: "Quest 07 completed",
                reward: "Hemit social link level up",
                instructions: "Take the ema from the fox. Talk to the lady in the Southern Shopping District. Then talk to Chie on the school roof to get \"Meat Gum\". Give the lady the meat gun. Then report back to the fox."
            ),
            new Quest(
                id: 09,
                title: "We Wish Our Dog Would Return",
                questGiver: "Fox",
                location: "Shrine",
                dateAvailable: "After 05/06",
                prerequisites: "Quest 08 completed",
                reward: "Hemit social link level up",
                instructions: "Take the ema from the fox. Find the dog at the Samegawa Flood Plain and \"Talk to it gently\". The next day go to the Northern Shopping District and \"Talk to it gently\". The next day feed the dog a Steak Skewer, these can be bought from Souzai Daigaku. Then report back to the fox."
            ),
            new Quest(
                id: 10,
                title: "I Wish I Had Friends",
                questGiver: "Fox",
                location: "Shrine",
                dateAvailable: "After 05/06",
                prerequisites: "Quest 09 completed",
                reward: "Hemit social link level up",
                instructions: "Take the ema from the fox. Find the boy next to the signs at the Samegawa Flood Plain, give him a Prize Sticker (Obtained when buying something from the TV). Talk him there the next day. Talk to Nanako, ask about the sticker. Then return to the boy and give him the sticker. Then report back to the fox."
            ),
            new Quest(
                id: 11,
                title: "I Wish My Life Had Meaning Again",
                questGiver: "Fox",
                location: "Shrine",
                dateAvailable: "After 05/06",
                prerequisites: "Quest 10 completed",
                reward: "Hemit social link level up",
                instructions: "Take the ema from the fox. Find the in the Shopping Distrcit North (near Souzai Daigaku), he will give you an unbuilt model. Build the model at your table (It's takes multiple days). Then return the model to the man. Then report back to the fox."
            ),
            new Quest(
                id: 12,
                title: "I Wish I Was Better At Speaking",
                questGiver: "Fox",
                location: "Shrine",
                dateAvailable: "After 05/06",
                prerequisites: "Quest 11 completed",
                reward: "Hemit social link level up",
                instructions: "Take the ema from the fox. Talk to the girl on the roof and choose the dialogue options: \"Looks like you want to learn to speak better\" and \"Let me teach you\". Talk to her the next day and choose \"It takes courage to apologize\". Then report back to the fox."
            ),
            new Quest(
                id: 13,
                title: "I Wish I Didn't Fear Cats",
                questGiver: "Fox",
                location: "Shrine",
                dateAvailable: "After 05/06",
                prerequisites: "Quest 12 completed",
                reward: "Hemit social link level up",
                instructions: "Take the ema from the fox. Talk to the man at the Samegawa Flood Plain and ask about cats. Go to the Dojima Residence, talk to the cat outside and choose \"Bring here\". The next day give the man a Red Goldfish (Can be obtained though fishing or bought on the TV). Talk to him the next day. Then report back to the fox."
            ),
            new Quest(
                id: 14,
                title: "I Wish My Wallet Would Return",
                questGiver: "Fox",
                location: "Shrine",
                dateAvailable: "After 05/06",
                prerequisites: "Quest 13 completed",
                reward: "Hemit social link level up",
                instructions: "Take the ema from the fox. Talk to the women at the Samegawa Flood Plain. Then search the sign in the floodplains to find a wallet, talk to the lady. Go to the Northern Shopping District, search the lamp post by the shrine. Bring it to the lady. Then report back to the fox."
            ),
            new Quest(
                id: 15,
                title: "The Shichiri Beach Guardian",
                questGiver: "Fox",
                location: "Shrine",
                dateAvailable: "After 05/06",
                prerequisites: "Quest 14 completed",
                reward: "Hermit social link level up",
                instructions: "Take the ema from the fox. You need access to Shichiri Beach with the scooter (Take 3 long rides). Talk to the old man at the river bank, he will talk about the Guardian. Catch it in the river using Inaba Jewel Beetle as bait (caught at night). Show the old man the guardian to get the sea rod. Then, using the sea rod, bait it with a Genji Beetle (caught at night) fish in the sea to get the Sea Guardian. (Both Guardians have a high spawn rate in rainy weather). Report back to the fox."
            ),
            new Quest(
                id: 16,
                title: "Desk Refurbishing",
                questGiver: "Homely Student",
                location: "Practice Building 2F",
                dateAvailable: "05/18",
                prerequisites: "",
                reward: "Royal Jelly x5",
                instructions: "Go to the TV world and go inside The Castle (Yukiko's dungeon). Then defeat an enemy called \"Laughing Table\" to have a chance to obtain it, they are typically found on floors 6-7. Then give the item to the quest giver."
            ),
            new Quest(
                id: 17,
                title: "Extracurricular Activities",
                questGiver: "Ms. Sofue",
                location: "Classroom Building 2F Staircase",
                dateAvailable: "05/18",
                prerequisites: "",
                reward: "Pulsating Stone x2",
                instructions: "Go to the TV world and go inside The Castle (Yukiko's dungeon). Then defeat an enemy called \"Trance Twins\" to have a chance to obtain it, they are typically found on floors 3-5. Then give the item to the quest giver."
            ),
            new Quest(
                id: 18,
                title: "Book Exchange",
                questGiver: "Avid Reader",
                location: "Southern Shopping District",
                dateAvailable: "05/23",
                prerequisites: "",
                reward: "The Gentle Way",
                instructions: "Go to the TV world and inside any dungeon. The look in non-golden chests for a \"Peach Seed\". Then give the item to the quest giver."
            ),
            new Quest(
                id: 19,
                title: "Tissue Distribution Agent",
                questGiver: "30 Frame Employee",
                location: "Okina City",
                dateAvailable: "06/11",
                prerequisites: "Scooter Access to Okina City",
                reward: "¥5000",
                instructions: "Talk to the man outside the theatre. Give everyone in the area the tissues he gives you. Then talk to the quest giver."
            ),
            new Quest(
                id: 20,
                title: "Please Feed the Cat",
                questGiver: "Avid Reader",
                location: "Southern Shopping District",
                dateAvailable: "06/03",
                prerequisites: "Quest 18 completed",
                reward: "The Punk Way",
                instructions: "Find the cat at the Samegawa Flood Plain (Only on non rainy days). Give it a fish (Can be obtained though fishing or bought on the TV). The talk to the quest giver."
            ),
            new Quest(
                id: 21,
                title: "Feed the Cat",
                questGiver: "[You]",
                location: "Samegawa Flood Plain",
                dateAvailable: "06/03",
                prerequisites: "Quest 20 completed",
                reward: "Heal Jelly",
                instructions: "Feed the cat 8 more fish (Only appears on non-rainy days)."
            ),
            new Quest(
                id: 22,
                title: "Cat Needs Food Badly",
                questGiver: "[You]",
                location: "Samegawa Flood Plain",
                dateAvailable: "06/03",
                prerequisites: "Quest 22 completed",
                reward: "Soma",
                instructions: "Feed the cat 19 more fish (Only appears on non-rainy days)."
            ),
            new Quest(
                id: 23,
                title: "Acquire an Old Key",
                questGiver: "Old Woman",
                location: "Samegawa Flood Plain",
                dateAvailable: "06/05",
                prerequisites: "",
                reward: "Knowledge & Courage Up",
                instructions: "Go to the TV world and go inside The Steamy Bathhouse (Kanji's dungeon). Then defeat an enemy called \"Bribed Fuzz\" to have a chance to obtain it, they are typically found on floors 1-2. Then give the item to the quest giver."
            ),
            new Quest(
                id: 24,
                title: "Acquire Coal",
                questGiver: "Loud Old Man",
                location: "Northern Shopping District",
                dateAvailable: "06/05",
                prerequisites: "",
                reward: "¥15000",
                instructions: "Go to the TV world and go inside The Steamy Bathhouse (Kanji's dungeon). Then defeat an enemy called \"Selfish Basalt\" to have a chance to obtain it, they are typically found on floors 5-6. Then give the item to the quest giver."
            ),
            new Quest(
                id: 25,
                title: "100% Inaba-Grown Cabbage",
                questGiver: "Fussy Housewife",
                location: "Junes",
                dateAvailable: "06/05",
                prerequisites: "Access to gardening",
                reward: "Sharp Shovel",
                instructions: "Buy Cabbage seeds from the farmer and plant them in the garden. Get a total of 3 Cabbage and give them to the quest giver."
            ),
            new Quest(
                id: 26,
                title: "Acquire a Crooked Cross",
                questGiver: "Timid Female Student",
                location: "Classroom 2-2",
                dateAvailable: "06/07",
                prerequisites: "Quest 4 completed",
                reward: "Ointment x3",
                instructions: "Go to the TV world and go inside The Steamy Bathhouse (Kanji's dungeon). Then defeat an enemy called \"Tranquil Idol\" to have a chance to obtain it, they are typically found on floors 7-8. Then give the item to the quest giver."
            ),
            new Quest(
                id: 27,
                title: "Acquire a Charmed Veil",
                questGiver: "Timid Female Student",
                location: "Classroom 2-2",
                dateAvailable: "07/12",
                prerequisites: "Quest 26 completed",
                reward: "Chest Key x5",
                instructions: "Go to the TV world and go inside The Marukyu Striptease (Rise's dungeon). Then defeat an enemy called \"Liberating Idol\" to have a chance to obtain it, they are typically found on floors 5-10. Then give the item to the quest giver."
            ),
            new Quest(
                id: 28,
                title: "Desk Refurbishing, Part 2",
                questGiver: "Homely Student",
                location: "Practice Building 2F",
                dateAvailable: "06/08",
                prerequisites: "Quest 16 completed",
                reward: "Snuff Soul x2",
                instructions: "Go to the TV world and go inside The Steamy Bathhouse (Kanji's dungeon). Then defeat an enemy called \"Reflecting Board\" to have a chance to obtain it, they are typically found on floors 9-10. Then give the item to the quest giver."
            ),
            new Quest(
                id: 29,
                title: "Acquire a Horn",
                questGiver: "Housewife",
                location: "Southern Shopping District",
                dateAvailable: "06/09",
                prerequisites: "",
                reward: "¥18000",
                instructions: "Go to the TV world and go inside The Steamy Bathhouse (Kanji's dungeon). Then defeat an enemy called \"Grave Beetle\" to have a chance to obtain it, they are typically found on floors 9-10. Then give the item to the quest giver."
            ),
            new Quest(
                id: 30,
                title: "Please Find My Younger Twin",
                questGiver: "Male Student",
                location: "Southern Shopping District",
                dateAvailable: "06/09",
                prerequisites: "",
                reward: "Goho-m x5",
                instructions: "NOTE: Must be completed before 11/17.\nGo to the Samegawa Flood Plain. Talk to the sister, by the gazebo. Then talk to the quest giver."
            ),
            new Quest(
                id: 31,
                title: "The Cleaning Club's Passion",
                questGiver: "",
                location: "Classroom Building 3F",
                dateAvailable: "06/11",
                prerequisites: "",
                reward: "Bamboo Broom",
                instructions: "Go to the Practice Building 2F and talk to the Artisan Apprentice. Sell Daidara Metalworks 6 Golden Cloth (Can be obtained from the \"Phantom Mage\" enemy in The Castle on floors 5-7) to be able to buy a \"Lai Katana\". Then go to Okina City and buy the Cleaning Uniform from Croco Fur. Then give the items to the quest giver."
            ),
            new Quest(
                id: 32,
                title: "Acquire Inaba Trout",
                questGiver: "Master Daidara",
                location: "Daidara Metalworks",
                dateAvailable: "06/14",
                prerequisites: "",
                reward: "Inaba Trout (Weapon)",
                instructions: "Get this from fishing at Samegawa Flood Plain or buy it from the TV on 06/05. Then give the item to the quest giver."
            ),
            new Quest(
                id: 33,
                title: "Acquire a Silver Lump",
                questGiver: "Male Student",
                location: "Practice Building 1F",
                dateAvailable: "06/30",
                prerequisites: "Quest 6 completed",
                reward: "Uplifting Radio x2",
                instructions: "Go to the TV world and go inside The Marukyu Striptease (Rise's dungeon). Then defeat an enemy called \"Silver Dice\" to have a chance to obtain it, they are typically found on floors 7-10. Then give the item to the quest giver."
            ),
            new Quest(
                id: 34,
                title: "Acquire Hard Boots",
                questGiver: "Avid Reader",
                location: "Southern Shopping District",
                dateAvailable: "07/03",
                prerequisites: "Quest 20 completed",
                reward: "Guide to Pests & ¥5,000",
                instructions: "Sell Daidara Metalworks 5 Thick Hide (Can be obtained from the \"Dancing Hand\" enemy in The Steamy Bathhouse on floors 5-8) to be able to buy a \"Hard Boots\". Then give the item to the quest giver."
            ),
            new Quest(
                id: 35,
                title: "Carbon Copy",
                questGiver: "Young Girl",
                location: "Samegawa Riverbank",
                dateAvailable: "07/13",
                prerequisites: "Quest 30 completed",
                reward: "Emergency Kit x3",
                instructions: "NOTE: Must be completed before 11/17.\nGo to the TV world and go inside The Marukyu Striptease (Rise's dungeon). Then defeat an enemy called \"Soul Dancer\" to have a chance to obtain it, they are typically found on floors 1-3. Then give the item to the quest giver."
            ),
            new Quest(
                id: 36,
                title: "Carbon Copy, Part 2",
                questGiver: "Young Girl",
                location: "Samegawa Riverbank",
                dateAvailable: "08/22",
                prerequisites: "Quest 35 completed",
                reward: "Macca Leaf x3",
                instructions: "NOTE: Must be completed before 11/17.\nGo to the TV world and go inside The Void Quest (Mitsuo's dungeon). Then defeat an enemy called \"Blind Cupid\" to have a chance to obtain it, they are typically found on floors 3-4. Then give the item to the quest giver."
            ),
            new Quest(
                id: 37,
                title: "Pining For Stylish Formalwear",
                questGiver: "Woman in Heavy Makeup",
                location: "Okina City",
                dateAvailable: "07/16",
                prerequisites: "",
                reward: "Royal Jelly",
                instructions: "Go to the TV world and go inside The Castle (Yukiko's dungeon). Then look in golden chests to have a chance to obtain \"The Gentleman's Tux\". Then give the item to the quest giver."
            ),
            new Quest(
                id: 38,
                title: "Harvest Two Types of Corn",
                questGiver: "Master Daidara",
                location: "Daidara Metalworks",
                dateAvailable: "07/25",
                prerequisites: "",
                reward: "Grilled Corn",
                instructions: "Buy Barrier Corn seeds from the seed seller and plant them in the garden. Then give them to the quest giver."
            ),
            new Quest(
                id: 39,
                title: "Acquire an Eternal Lamp",
                questGiver: "Older Man",
                location: "Samegawa Flood Plain",
                dateAvailable: "08/22",
                prerequisites: "",
                reward: "¥30,000",
                instructions: "Go to the TV world and go inside The Void Quest (Mitsuo's dungeon). Then defeat an enemy called \"Amenti Raven\" to have a chance to obtain it, they are typically found on floors 3-4. Then give the item to the quest giver."
            ),
            new Quest(
                id: 40,
                title: "Acquire Some Fashionable Dishes",
                questGiver: "Avid Reader",
                location: "Southern Shopping District",
                dateAvailable: "08/09",
                prerequisites: "Quest 34 completed",
                reward: "Riddlemania & ¥10,000",
                instructions: "Go to the TV world and go inside The Marukyu Striptease (Rise's dungeon). Then defeat an enemy called \"Sky Balance\" to have a chance to obtain it, they are typically found on floors 9-10. Then give the item to the quest giver."
            ),
            new Quest(
                id: 41,
                title: "What Was That in the Movie?",
                questGiver: "Movie Buff",
                location: "Okina City",
                dateAvailable: "09/02",
                prerequisites: "",
                reward: "",
                instructions: "Go to the Classroom Building 2F and talk to Ms. Sofue, ask about object. Then talk to the quest giver."
            ),
            new Quest(
                id: 42,
                title: "Riddle Senpai Returns!",
                questGiver: "Funky Student",
                location: "Classroom Building 3F",
                dateAvailable: "09/02",
                prerequisites: "Quest 1 completed",
                reward: "Snuff Soul",
                instructions: "He will ask you 4 questions. The answers are: \"Group A\", \"Human Motion\", \"Group B\" and \"Indefinite Articles\"."
            ),
            new Quest(
                id: 43,
                title: "Experiments in Telepathy",
                questGiver: "Girl",
                location: "Southern Shopping District",
                dateAvailable: "09/05",
                prerequisites: "Quest 30 completed",
                reward: "Dokudami Tea x5",
                instructions: "NOTE: Must be completed before 11/17.\nGo to the Samegawa Flood Plain and talk to the twin sister, ask her \"Name a black, sweet bar.\". Then talk to the quest giver."
            ),
            new Quest(
                id: 44,
                title: "Extracurricular Activities, Part 2",
                questGiver: "Ms. Sofue",
                location: "Classroom Building 2F Staircase",
                dateAvailable: "09/20",
                prerequisites: "Quest 17 completed",
                reward: "Mysterious Scarab x2",
                instructions: "Go to the TV world and go inside The Void Quest (Mitsuo's dungeon). Then defeat an enemy called \"Steel Machine\" to have a chance to obtain Culurium, they are typically found on floors 9-10. Then give the item to the quest giver."
            ),
            new Quest(
                id: 45,
                title: "A Test of Literary Memory",
                questGiver: "Avid Reader",
                location: "Southern Shopping District",
                dateAvailable: "09/26",
                prerequisites: "Quest 40 completed",
                reward: "Who Am I?",
                instructions: "He will ask you 4 questions. The answers are: \"Judo medalists' names\", \"How one should live as a punk\", \"2 pages per pest\" and \"Me\"."
            ),
            new Quest(
                id: 46,
                title: "Desk Refurbishing, Part 3",
                questGiver: "Homely Student",
                location: "Practice Building 2F",
                dateAvailable: "09/28",
                prerequisites: "Quest 28 completed",
                reward: "Bead",
                instructions: "Go to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Furious Gigas\" to have a chance to obtain Proof of Passion (3 are required), they are typically found on floor 4. Then give the items to the quest giver."
            ),
            new Quest(
                id: 47,
                title: "Find Me Something to Wear",
                questGiver: "Housewife",
                location: "Okina City",
                dateAvailable: "10/12",
                prerequisites: "",
                reward: "Juli Fan",
                instructions: "Sell Daidara Metalworks 8 Power Rocks (Can be obtained from the \"Power Castle\" enemy in The Secret Laboratory on floors 3-7) to be able to buy a \"Invincible Mini\". Then give the item to the quest giver."
            ),
            new Quest(
                id: 48,
                title: "Acquire a Crystal Ball",
                questGiver: "Ms. Nakayama",
                location: "Classroom Building 3F",
                dateAvailable: "10/08",
                prerequisites: "",
                reward: "¥35000",
                instructions: "Go to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Constancy Relic\" to have a chance to obtain it, they are typically found on floors 1-2. Then give the item to the quest giver."
            ),
            new Quest(
                id: 49,
                title: "Acquire a Training Shell",
                questGiver: "Principal",
                location: "Classroom Building 3F",
                dateAvailable: "10/08",
                prerequisites: "",
                reward: "Understanding & Diligence Up",
                instructions: "Go to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Wicked Turret\" to have a chance to obtain it, they are typically found on floors 7-8. Then give the item to the quest giver."
            ),
            new Quest(
                id: 50,
                title: "Acquire a High-Speed Gear",
                questGiver: "Female Student",
                location: "Classroom Building 1F",
                dateAvailable: "10/08",
                prerequisites: "",
                reward: "Physical Mirror x3",
                instructions: "Go to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Mach Wheel\" to have a chance to obtain it, they are typically found on floors 5-6. Then give the item to the quest giver."
            ),
            new Quest(
                id: 51,
                title: "Acquire Fine Coal",
                questGiver: "Loud Old Manf",
                location: "Northern Shopping District",
                dateAvailable: "10/09",
                prerequisites: "Quest 24 completed",
                reward: "¥40000",
                instructions: "Go to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Power Castle\" to have a chance to obtain it, they are typically found on floors 3-8. Then give the item to the quest giver."
            ),
            new Quest(
                id: 52,
                title: "A Twin's Independence",
                questGiver: "Younger Twin",
                location: "Samegawa Riverbank",
                dateAvailable: "10/09",
                prerequisites: "Quest 36 completed",
                reward: "Chain Bead",
                instructions: "NOTE: Must be completed before 11/17.\nGo to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Elegant Mother\" to have a chance to obtain a Branch Headband, they are typically found on floor 8. Then give the item to the quest giver."
            ),
            new Quest(
                id: 53,
                title: "Experiments in Telepathy, Part 2",
                questGiver: "Older Twin",
                location: "Samegawa Riverbank",
                dateAvailable: "10/31",
                prerequisites: "Quest 52 completed",
                reward: "Super Sonic x3",
                instructions: "Go to the Southern Shopping District and talk to the twin sister. Go back to the quest giver and talk to her. Then go back and talk to the other sister."
            ),
            new Quest(
                id: 54,
                title: "Find my Pet",
                questGiver: "Frantic Middle-aged Woman",
                location: "Okina City",
                dateAvailable: "11/1",
                prerequisites: "",
                reward: "",
                instructions: "Firstly, buy 3 Steak Skewers from Souzai Daigaku. Then talk to the dog in the Northern Shopping District and call it by it's name, Mika-chan. Over the next 3 days, return to the dog and feed it a Steak Skewer. Then return to the quest giver."
            ),
            new Quest(
                id: 55,
                title: "Revenge of Riddle Senpai!",
                questGiver: "Funky Student",
                location: "Classroom Building 3F",
                dateAvailable: "11/12",
                prerequisites: "Quest 47 completed",
                reward: "Chewing Soul",
                instructions: "He will ask you 4 questions. The answers are: \"Group B\", \"The way they're drawn\", \"Promethium\" and \"Need\"."
            ),
            new Quest(
                id: 56,
                title: "The Girl on the Rooftop, Part 2",
                questGiver: "Male Student",
                location: "Classroom 2-2",
                dateAvailable: "11/22",
                prerequisites: "Quest 2 completed",
                reward: "Mokoi Doll",
                instructions: "Go to the TV world and go inside Heaven (Nanako's dungeon). Then defeat an enemy called \"Prime Magus\" to have a chance to obtain an Animal Guide, they are typically found on floors 1-2. Then give the item to the quest giver."
            ),
            new Quest(
                id: 57,
                title: "Desk Refurbishing, Part 4",
                questGiver: "Homely Student",
                location: "Practice Building 2F",
                dateAvailable: "11/22",
                prerequisites: "Quest 46 completed",
                reward: "Fire Signal x3",
                instructions: "Go to the TV world and go inside Heaven (Nanako's dungeon). Then defeat an enemy called \"Angry Table\" to have a chance to obtain Classy Lumber, they are typically found on floors 5-7. Then give the item to the quest giver."
            ),
            new Quest(
                id: 58,
                title: "Acquire an Old Ore",
                questGiver: "Male Student",
                location: "Practice Building 1F",
                dateAvailable: "11/22",
                prerequisites: "Quest 33 completed",
                reward: "Spirit Radio",
                instructions: "Go to the TV world and go inside Heaven (Nanako's dungeon). Then defeat an enemy called \"Revelation Pesce\" to have a chance to obtain it, they are typically found on floors 6-8. Then give the item to the quest giver."
            ),
            new Quest(
                id: 59,
                title: "Acquire a Modest Lamp",
                questGiver: "Older Man",
                location: "Samegaqa Flood Plain",
                dateAvailable: "11/22",
                prerequisites: "Quest 39 completed",
                reward: "¥45000",
                instructions: "Go to the TV world and go inside Heaven (Nanako's dungeon). Then defeat an enemy called \"Phantom Lord\" to have a chance to obtain it, they are typically found on floors 5-6. Then give the item to the quest giver."
            ),
            new Quest(
                id: 60,
                title: "Acquire Samegawa's Guardian",
                questGiver: "Maseter Daidara",
                location: "Daidara Metalworks",
                dateAvailable: "01/10",
                prerequisites: "",
                reward: "Guardian (Weapon)",
                instructions: "Go to the Samegawa Riverbank and fish off the rock, bait the rod with an Inaba Jewel Beetle (Fish on a rainy day for better luck to catch it), for a chance to catch the Guardian. Then give the item to the quest giver."
            ),
            new Quest(
                id: 61,
                title: "Find My Pet, Part 2",
                questGiver: "Middle-aged woman",
                location: "Okina City",
                dateAvailable: "01/10",
                prerequisites: "Quest 54 completed",
                reward: "Haikara Shirt",
                instructions: "Go to the Samegawa Riverbank and feed the cat 5 times, with a different fish each time."
            ),
            new Quest(
                id: 62,
                title: "Extracurricular Activities, Part 3",
                questGiver: "Ms. Sofue",
                location: "Classroom Building 2F Staircase",
                dateAvailable: "01/10",
                prerequisites: "Quest 44 completed",
                reward: "Silver Tray",
                instructions: "Go to the TV world and go inside Magatsu Mandala ([True Killer]'s dungeon). Then defeat an enemy called \"Solemn Machine\" to have a chance to obtain Orichalum, they are typically found on floor 6. Then give the item to the quest giver."
            ),
            new Quest(
                id: 63,
                title: "Acquire Golden Chains",
                questGiver: "Ms. Nakayama",
                location: "Classroom Building 3F",
                dateAvailable: "01/10",
                prerequisites: "Quest 48 completed",
                reward: "¥65000",
                instructions: "Go to the TV world and go inside Magatsu Mandala ([True Killer]'s dungeon). Then defeat an enemy called \"Minotaur II\" to have a chance to obtain it (3 are required), they are typically found on floor 6. Then give the item to the quest giver."
            ),
            new Quest(
                id: 64,
                title: "The Riddle Senpai's Encore!",
                questGiver: "Funky Student",
                location: "Classroom Building 3F",
                dateAvailable: "01/10",
                prerequisites: "Quest 55 completed",
                reward: "Soul Food x3",
                instructions: "He will ask you 1 question. The answer is: \"Uruguay\"."
            ),
            new Quest(
                id: 65,
                title: "Kashiwagi's Special Lesson",
                questGiver: "Ms. Kashiwagi",
                location: "Classroom Building 1F",
                dateAvailable: "01/16",
                prerequisites: "",
                reward: "Coronet Armor",
                instructions: "She will ask you 2 questions. The answers are: \"Deoxyribonucleic Acid\" and \"Rabbit\"."
            ),
            new Quest(
                id: 66,
                title: "Show Me Some Cute Slippers",
                questGiver: "Ms. Kashiwagi",
                location: "Classroom Building 1F",
                dateAvailable: "01/17",
                prerequisites: "Quest 65 completed",
                reward: "Fighter Armor",
                instructions: "Sell Daidara Metalworks 8 Bloody Hides (Can be obtained from the \"Jotun of Blood\" enemy in Heaven on floors 8-9) to be able to buy \"Vidar Boots\". Then give the item to the boy in the Practice Building 2F."
            ),
            new Quest(
                id: 67,
                title: "Dazzle Me With Animal Paw Gloves",
                questGiver: "Ms. Kashiwagi",
                location: "Classroom Building 1F",
                dateAvailable: "01/18",
                prerequisites: "Quest 66 completed",
                reward: "Magical Armor",
                instructions: "Go to the TV world and go inside any dungeon. Then defeat an enemy called \"Golden Hand\" to have a chance to obtain Magatsu Xandrite (8 are required). Go to the Shrine at night and the Girl in White may be there. Trade her a Guardian (Fished on a rainy day using Inaba Jewel Beetle as bait) to obtain a Mondo Stone. Give all the items to the women in the Shiroku Pub during night to obtain an Animal Paw (Weapon). Then give the item to the quest giver."
            ),
            new Quest(
                id: 68,
                title: "Kashiwagi's Special Lesson Part 2",
                questGiver: "Ms. Kashiwagi",
                location: "Classroom Building 1F",
                dateAvailable: "01/19",
                prerequisites: "Quest 67 completed",
                reward: "School Swimsuit",
                instructions: "She will ask you 3 questions. The answers are: \"Raster\", \"Latin\" and \"Rome\"."
            ),
            new Quest(
                id: 69,
                title: "A Student Should Study",
                questGiver: "Principal",
                location: "Classroom Building 3F",
                dateAvailable: "01/23",
                prerequisites: "",
                reward: "Victory Fan",
                instructions: "He will ask you 4 questions. The answers are: \"Wind\", \"Upper, Middle, and Lower\", \"7\" and \"Mameluke\"."
            )
        };
    }
}
