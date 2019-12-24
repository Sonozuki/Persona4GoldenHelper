using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Data
{
    public static class QuestData
    {
        public static List<Quest> Quests { get; } = new List<Quest>()
        {
            new Quest() {
                Number = 1,
                Title = "Who's the Riddle Master!?",
                QuestGiver = "Funky Student",
                Location = "Classroom Building 3F",
                DateAvailable = "04/18",
                Prerequisites = "",
                Reward = "Chest Key x3",
                Instructions = "He will ask you 2 questions. The answers are: \"Group A\" and \"They're top 6 flag colors.\""
            },
            new Quest() {
                Number = 2,
                Title = "The Girl on the Rooftop",
                QuestGiver = "Male Student",
                Location = "Classroom 2-2",
                DateAvailable = "04/25",
                Prerequisites = "",
                Reward = "Goho-m",
                Instructions = "Go to the school roof and speak to the girl, select the 2nd dialogue option. Repeat this two more times on different days. She is not availble when it is rainy."
            },
            new Quest() {
                Number = 3,
                Title = "Acquire Mori Ranmaru Shochu",
                QuestGiver = "Man",
                Location = "Samegawa Flood Plain",
                DateAvailable = "05/01",
                Prerequisites = "",
                Reward = "¥4000",
                Instructions = "Go to the TV world and go inside Twisted Shopping District (Yosuke's dungeon). Then search the boxes in the room to obtain it. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 4,
                Title = "Acquire an Angel Statue",
                QuestGiver = "Timid Female Student",
                Location = "Classroom 2-2",
                DateAvailable = "05/02",
                Prerequisites = "",
                Reward = "Chest Key x3",
                Instructions = "Go to the TV world and go inside The Castle (Yukiko's dungeon). Then defeat an enemy called \"Avenger Knight\" to have a chance to obtain it, they are typically found on floors 6-7. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 5,
                Title = "Acquire a Demon Statue",
                QuestGiver = "Shady Student",
                Location = "Classroom Building 2F",
                DateAvailable = "05/02",
                Prerequisites = "",
                Reward = "Dokudami Tea x3",
                Instructions = "Go to the TV world and go inside The Castle (Yukiko's dungeon). Then defeat an enemy called \"Magical Magus\" to have a chance to obtain it, they are typically found on floors 6-7. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 6,
                Title = "Acquire a Ritz Wire",
                QuestGiver = "Male Student",
                Location = "Practice Building 1F",
                DateAvailable = "05/02",
                Prerequisites = "",
                Reward = "Olympic Tape",
                Instructions = "Go to the TV world and go inside The Castle (Yukiko's dungeon). The defeat and enemy called \"Heat Balance\" to have a chance to obtain it, they are typically found on floors 6-7. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 7,
                Title = "I Wish for Love",
                QuestGiver = "Fox",
                Location = "Shrine",
                DateAvailable = "05/06",
                Prerequisites = "",
                Reward = "Hemit social link level up",
                Instructions = "Take the ema from the fox. Talk to the female student in the Classroom Building 1F lobby. The next day she will be on 2F, tell her \"I read it\". The next day speak to her again at the same location. The report back to the fox."
            },
            new Quest() {
                Number = 8,
                Title = "I Wish I Didn't Crave Snacks",
                QuestGiver = "Fox",
                Location = "Shrine",
                DateAvailable = "After 05/06",
                Prerequisites = "Quest 07 completed",
                Reward = "Hemit social link level up",
                Instructions = "Take the ema from the fox. Talk to the lady in the Southern Shopping District. Then talk to Chie on the school roof to get \"Meat Gum\". Give the lady the meat gun. Then report back to the fox."
            },
            new Quest() {
                Number = 9,
                Title = "We Wish Our Dog Would Return",
                QuestGiver = "Fox",
                Location = "Shrine",
                DateAvailable = "After 05/06",
                Prerequisites = "Quest 08 completed",
                Reward = "Hemit social link level up",
                Instructions = "Take the ema from the fox. Find the dog at the Samegawa Flood Plain and \"Talk to it gently\". The next day go to the Northern Shopping District and \"Talk to it gently\". The next day feed the dog a Steak Skewer, these can be bought from Souzai Daigaku. Then report back to the fox."
            },
            new Quest() {
                Number = 10,
                Title = "I Wish I Had Friends",
                QuestGiver = "Fox",
                Location = "Shrine",
                DateAvailable = "After 05/06",
                Prerequisites = "Quest 09 completed",
                Reward = "Hemit social link level up",
                Instructions = "Take the ema from the fox. Find the boy next to the signs at the Samegawa Flood Plain, give him a Prize Sticker (Obtained when buying something from the TV). Talk him there the next day. Talk to Nanako, ask about the sticker. Then return to the boy and give him the sticker. Then report back to the fox."
            },
            new Quest() {
                Number = 11,
                Title = "I Wish My Life Had Meaning Again",
                QuestGiver = "Fox",
                Location = "Shrine",
                DateAvailable = "After 05/06",
                Prerequisites = "Quest 10 completed",
                Reward = "Hemit social link level up",
                Instructions = "Take the ema from the fox. Find the in the Shopping Distrcit North (near Souzai Daigaku), he will give you an unbuilt model. Build the model at your table (It's takes multiple days). Then return the model to the man. Then report back to the fox."
            },
            new Quest() {
                Number = 12,
                Title = "I Wish I Was Better At Speaking",
                QuestGiver = "Fox",
                Location = "Shrine",
                DateAvailable = "After 05/06",
                Prerequisites = "Quest 11 completed",
                Reward = "Hemit social link level up",
                Instructions = "Take the ema from the fox. Talk to the girl on the school roof, go back the next day and talk to her again and choose the dialogue options: \"Looks like you want to learn to speak better\" and \"Give her lessons\". Talk to her the next day and choose \"It takes courage to apologize\". Then report back to the fox."
            },
            new Quest() {
                Number = 13,
                Title = "I Wish I Didn't Fear Cats",
                QuestGiver = "Fox",
                Location = "Shrine",
                DateAvailable = "After 05/06",
                Prerequisites = "Quest 12 completed",
                Reward = "Hemit social link level up",
                Instructions = "Take the ema from the fox. Talk to the man at the Samegawa Flood Plain and ask about cats. Go to the Dojima Residence, talk to the cat outside and choose \"Bring here\". The next day give the man a Red Goldfish (Can be obtained though fishing or bought on the TV). Talk to him the next day. Then report back to the fox."
            },
            new Quest() {
                Number = 14,
                Title = "I Wish My Wallet Would Return",
                QuestGiver = "Fox",
                Location = "Shrine",
                DateAvailable = "After 05/06",
                Prerequisites = "Quest 13 completed",
                Reward = "Hemit social link level up",
                Instructions = "Take the ema from the fox. Talk to the women at the Samegawa Flood Plain. Then search the sign in the floodplains to find a wallet, talk to the lady. Go to the Northern Shopping District, search the lamp post by the shrine. Bring it to the lady. Then report back to the fox."
            },
            new Quest() {
                Number = 15,
                Title = "The Shichiri Beach Guardian",
                QuestGiver = "Fox",
                Location = "Shrine",
                DateAvailable = "After 05/06",
                Prerequisites = "Quest 14 completed",
                Reward = "Hermit social link level up",
                Instructions = "Take the ema from the fox. You need access to Shichiri Beach with the scooter (Take 3 long rides). Talk to the old man at the river bank, he will talk about the Guardian. Catch it in the river using Inaba Jewel Beetle as bait (caught at night). Show the old man the guardian to get the sea rod. Then, using the sea rod, bait it with a Genji Beetle (caught at night) fish in the sea to get the Sea Guardian. (Both Guardians have a high spawn rate in rainy weather). Report back to the fox."
            },
            new Quest() {
                Number = 16,
                Title = "Desk Refurbishing",
                QuestGiver = "Homely Student",
                Location = "Practice Building 2F",
                DateAvailable = "05/18",
                Prerequisites = "",
                Reward = "Royal Jelly x5",
                Instructions = "Go to the TV world and go inside The Castle (Yukiko's dungeon). Then defeat an enemy called \"Laughing Table\" to have a chance to obtain it, they are typically found on floors 6-7. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 17,
                Title = "Extracurricular Activities",
                QuestGiver = "Ms. Sofue",
                Location = "Classroom Building 2F Staircase",
                DateAvailable = "05/18",
                Prerequisites = "",
                Reward = "Pulsating Stone x2",
                Instructions = "Go to the TV world and go inside The Castle (Yukiko's dungeon). Then defeat an enemy called \"Trance Twins\" to have a chance to obtain it, they are typically found on floors 3-5. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 18,
                Title = "Book Exchange",
                QuestGiver = "Avid Reader",
                Location = "Southern Shopping District",
                DateAvailable = "05/23",
                Prerequisites = "",
                Reward = "The Gentle Way",
                Instructions = "Go to the TV world and inside any dungeon. The look in non-golden chests for a \"Peach Seed\". Then give the item to the quest giver."
            },
            new Quest() {
                Number = 19,
                Title = "Tissue Distribution Agent",
                QuestGiver = "30 Frame Employee",
                Location = "Okina City",
                DateAvailable = "06/11",
                Prerequisites = "Scooter Access to Okina City",
                Reward = "¥5000",
                Instructions = "Talk to the man outside the theatre. Give everyone in the area the tissues he gives you. Then talk to the quest giver."
            },
            new Quest() {
                Number = 20,
                Title = "Please Feed the Cat",
                QuestGiver = "Avid Reader",
                Location = "Southern Shopping District",
                DateAvailable = "06/03",
                Prerequisites = "Quest 18 completed",
                Reward = "The Punk Way",
                Instructions = "Find the cat at the Samegawa Flood Plain (Only on non rainy days). Give it a fish (Can be obtained though fishing or bought on the TV). The talk to the quest giver."
            },
            new Quest() {
                Number = 21,
                Title = "Feed the Cat",
                QuestGiver = "[You]",
                Location = "Samegawa Flood Plain",
                DateAvailable = "06/03",
                Prerequisites = "Quest 20 completed",
                Reward = "Heal Jelly",
                Instructions = "Feed the cat 8 more fish (Only appears on non-rainy days)."
            },
            new Quest() {
                Number = 22,
                Title = "Cat Needs Food Badly",
                QuestGiver = "[You]",
                Location = "Samegawa Flood Plain",
                DateAvailable = "06/03",
                Prerequisites = "Quest 22 completed",
                Reward = "Soma",
                Instructions = "Feed the cat 19 more fish (Only appears on non-rainy days)."
            },
            new Quest() {
                Number = 23,
                Title = "Acquire an Old Key",
                QuestGiver = "Old Woman",
                Location = "Samegawa Flood Plain",
                DateAvailable = "06/05",
                Prerequisites = "",
                Reward = "Knowledge & Courage Up",
                Instructions = "Go to the TV world and go inside The Steamy Bathhouse (Kanji's dungeon). Then defeat an enemy called \"Bribed Fuzz\" to have a chance to obtain it, they are typically found on floors 1-2. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 24,
                Title = "Acquire Coal",
                QuestGiver = "Loud Old Man",
                Location = "Northern Shopping District",
                DateAvailable = "06/05",
                Prerequisites = "",
                Reward = "¥15000",
                Instructions = "Go to the TV world and go inside The Steamy Bathhouse (Kanji's dungeon). Then defeat an enemy called \"Selfish Basalt\" to have a chance to obtain it, they are typically found on floors 5-6. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 25,
                Title = "100% Inaba-Grown Cabbage",
                QuestGiver = "Fussy Housewife",
                Location = "Junes",
                DateAvailable = "06/05",
                Prerequisites = "Access to gardening",
                Reward = "Sharp Shovel",
                Instructions = "Buy Cabbage seeds from the farmer and plant them in the garden. Get a total of 3 Cabbage and give them to the quest giver."
            },
            new Quest() {
                Number = 26,
                Title = "Acquire a Crooked Cross",
                QuestGiver = "Timid Female Student",
                Location = "Classroom 2-2",
                DateAvailable = "06/07",
                Prerequisites = "Quest 4 completed",
                Reward = "Ointment x3",
                Instructions = "Go to the TV world and go inside The Steamy Bathhouse (Kanji's dungeon). Then defeat an enemy called \"Tranquil Idol\" to have a chance to obtain it, they are typically found on floors 7-8. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 27,
                Title = "Acquire a Charmed Veil",
                QuestGiver = "Timid Female Student",
                Location = "Classroom 2-2",
                DateAvailable = "07/12",
                Prerequisites = "Quest 26 completed",
                Reward = "Chest Key x5",
                Instructions = "Go to the TV world and go inside The Marukyu Striptease (Rise's dungeon). Then defeat an enemy called \"Liberating Idol\" to have a chance to obtain it, they are typically found on floors 5-10. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 28,
                Title = "Desk Refurbishing, Part 2",
                QuestGiver = "Homely Student",
                Location = "Practice Building 2F",
                DateAvailable = "06/08",
                Prerequisites = "Quest 16 completed",
                Reward = "Snuff Soul x2",
                Instructions = "Go to the TV world and go inside The Steamy Bathhouse (Kanji's dungeon). Then defeat an enemy called \"Reflecting Board\" to have a chance to obtain it, they are typically found on floors 9-10. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 29,
                Title = "Acquire a Horn",
                QuestGiver = "Housewife",
                Location = "Southern Shopping District",
                DateAvailable = "06/09",
                Prerequisites = "",
                Reward = "¥18000",
                Instructions = "Go to the TV world and go inside The Steamy Bathhouse (Kanji's dungeon). Then defeat an enemy called \"Grave Beetle\" to have a chance to obtain it, they are typically found on floors 9-10. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 30,
                Title = "Please Find My Younger Twin",
                QuestGiver = "Male Student",
                Location = "Southern Shopping District",
                DateAvailable = "06/09",
                Prerequisites = "",
                Reward = "Goho-m x5",
                Instructions = "NOTE: Must be completed before 11/17.\nGo to the Samegawa Flood Plain. Talk to the sister, by the gazebo. Then talk to the quest giver."
            },
            new Quest() {
                Number = 31,
                Title = "The Cleaning Club's Passion",
                QuestGiver = "",
                Location = "Classroom Building 3F",
                DateAvailable = "06/11",
                Prerequisites = "",
                Reward = "Bamboo Broom",
                Instructions = "Go to the Practice Building 2F and talk to the Artisan Apprentice. Sell Daidara Metalworks 6 Golden Cloth (Can be obtained from the \"Phantom Mage\" enemy in The Castle on floors 5-7) to be able to buy a \"Lai Katana\". Then go to Okina City and buy the Cleaning Uniform from Croco Fur. Then give the items to the quest giver."
            },
            new Quest() {
                Number = 32,
                Title = "Acquire Inaba Trout",
                QuestGiver = "Master Daidara",
                Location = "Daidara Metalworks",
                DateAvailable = "06/14",
                Prerequisites = "",
                Reward = "Inaba Trout (Weapon)",
                Instructions = "Get this from fishing at Samegawa Flood Plain or buy it from the TV on 06/05. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 33,
                Title = "Acquire a Silver Lump",
                QuestGiver = "Male Student",
                Location = "Practice Building 1F",
                DateAvailable = "06/30",
                Prerequisites = "Quest 6 completed",
                Reward = "Uplifting Radio x2",
                Instructions = "Go to the TV world and go inside The Marukyu Striptease (Rise's dungeon). Then defeat an enemy called \"Silver Dice\" to have a chance to obtain it, they are typically found on floors 7-10. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 34,
                Title = "Acquire Hard Boots",
                QuestGiver = "Avid Reader",
                Location = "Southern Shopping District",
                DateAvailable = "07/03",
                Prerequisites = "Quest 20 completed",
                Reward = "Guide to Pests & ¥5,000",
                Instructions = "Sell Daidara Metalworks 5 Thick Hide (Can be obtained from the \"Dancing Hand\" enemy in The Steamy Bathhouse on floors 5-8) to be able to buy a \"Hard Boots\". Then give the item to the quest giver."
            },
            new Quest() {
                Number = 35,
                Title = "Carbon Copy",
                QuestGiver = "Young Girl",
                Location = "Samegawa Riverbank",
                DateAvailable = "07/13",
                Prerequisites = "Quest 30 completed",
                Reward = "Emergency Kit x3",
                Instructions = "NOTE: Must be completed before 11/17.\nGo to the TV world and go inside The Marukyu Striptease (Rise's dungeon). Then defeat an enemy called \"Soul Dancer\" to have a chance to obtain it, they are typically found on floors 1-3. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 36,
                Title = "Carbon Copy, Part 2",
                QuestGiver = "Young Girl",
                Location = "Samegawa Riverbank",
                DateAvailable = "08/22",
                Prerequisites = "Quest 35 completed",
                Reward = "Macca Leaf x3",
                Instructions = "NOTE: Must be completed before 11/17.\nGo to the TV world and go inside The Void Quest (Mitsuo's dungeon). Then defeat an enemy called \"Blind Cupid\" to have a chance to obtain it, they are typically found on floors 3-4. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 37,
                Title = "Pining For Stylish Formalwear",
                QuestGiver = "Woman in Heavy Makeup",
                Location = "Okina City",
                DateAvailable = "07/16",
                Prerequisites = "",
                Reward = "Royal Jelly",
                Instructions = "Go to the TV world and go inside The Castle (Yukiko's dungeon). Then look in golden chests to have a chance to obtain \"The Gentleman's Tux\". Then give the item to the quest giver."
            },
            new Quest() {
                Number = 38,
                Title = "Harvest Two Types of Corn",
                QuestGiver = "Master Daidara",
                Location = "Daidara Metalworks",
                DateAvailable = "07/25",
                Prerequisites = "",
                Reward = "Grilled Corn",
                Instructions = "Buy Barrier Corn seeds from the seed seller and plant them in the garden. Then give them to the quest giver."
            },
            new Quest() {
                Number = 39,
                Title = "Acquire an Eternal Lamp",
                QuestGiver = "Older Man",
                Location = "Samegawa Flood Plain",
                DateAvailable = "08/22",
                Prerequisites = "",
                Reward = "¥30,000",
                Instructions = "Go to the TV world and go inside The Void Quest (Mitsuo's dungeon). Then defeat an enemy called \"Amenti Raven\" to have a chance to obtain it, they are typically found on floors 3-4. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 40,
                Title = "Acquire Some Fashionable Dishes",
                QuestGiver = "Avid Reader",
                Location = "Southern Shopping District",
                DateAvailable = "08/09",
                Prerequisites = "Quest 34 completed",
                Reward = "Riddlemania & ¥10,000",
                Instructions = "Go to the TV world and go inside The Marukyu Striptease (Rise's dungeon). Then defeat an enemy called \"Sky Balance\" to have a chance to obtain it, they are typically found on floors 9-10. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 41,
                Title = "What Was That in the Movie?",
                QuestGiver = "Movie Buff",
                Location = "Okina City",
                DateAvailable = "09/02",
                Prerequisites = "",
                Reward = "",
                Instructions = "Go to the Classroom Building 2F and talk to Ms. Sofue, ask about object. Then talk to the quest giver."
            },
            new Quest() {
                Number = 42,
                Title = "Riddle Senpai Returns!",
                QuestGiver = "Funky Student",
                Location = "Classroom Building 3F",
                DateAvailable = "09/02",
                Prerequisites = "Quest 1 completed",
                Reward = "Snuff Soul",
                Instructions = "He will ask you 4 questions. The answers are: \"Group A\", \"Human Motion\", \"Group B\" and \"Indefinite Articles\"."
            },
            new Quest() {
                Number = 43,
                Title = "Experiments in Telepathy",
                QuestGiver = "Girl",
                Location = "Southern Shopping District",
                DateAvailable = "09/05",
                Prerequisites = "Quest 30 completed",
                Reward = "Dokudami Tea x5",
                Instructions = "NOTE: Must be completed before 11/17.\nGo to the Samegawa Flood Plain and talk to the twin sister, ask her \"Name a black, sweet bar.\". Then talk to the quest giver."
            },
            new Quest() {
                Number = 44,
                Title = "Extracurricular Activities, Part 2",
                QuestGiver = "Ms. Sofue",
                Location = "Classroom Building 2F Staircase",
                DateAvailable = "09/20",
                Prerequisites = "Quest 17 completed",
                Reward = "Mysterious Scarab x2",
                Instructions = "Go to the TV world and go inside The Void Quest (Mitsuo's dungeon). Then defeat an enemy called \"Steel Machine\" to have a chance to obtain Culurium, they are typically found on floors 9-10. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 45,
                Title = "A Test of Literary Memory",
                QuestGiver = "Avid Reader",
                Location = "Southern Shopping District",
                DateAvailable = "09/26",
                Prerequisites = "Quest 40 completed",
                Reward = "Who Am I?",
                Instructions = "He will ask you 4 questions. The answers are: \"Judo medalists' names\", \"How one should live as a punk\", \"2 pages per pest\" and \"Me\"."
            },
            new Quest() {
                Number = 46,
                Title = "Desk Refurbishing, Part 3",
                QuestGiver = "Homely Student",
                Location = "Practice Building 2F",
                DateAvailable = "09/28",
                Prerequisites = "Quest 28 completed",
                Reward = "Bead",
                Instructions = "Go to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Furious Gigas\" to have a chance to obtain Proof of Passion (3 are required), they are typically found on floor 4. Then give the items to the quest giver."
            },
            new Quest() {
                Number = 47,
                Title = "Find Me Something to Wear",
                QuestGiver = "Housewife",
                Location = "Okina City",
                DateAvailable = "10/12",
                Prerequisites = "",
                Reward = "Juli Fan",
                Instructions = "Sell Daidara Metalworks 8 Power Rocks (Can be obtained from the \"Power Castle\" enemy in The Secret Laboratory on floors 3-7) to be able to buy a \"Invincible Mini\". Then give the item to the quest giver."
            },
            new Quest() {
                Number = 48,
                Title = "Acquire a Crystal Ball",
                QuestGiver = "Ms. Nakayama",
                Location = "Classroom Building 3F",
                DateAvailable = "10/08",
                Prerequisites = "",
                Reward = "¥35000",
                Instructions = "Go to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Constancy Relic\" to have a chance to obtain it, they are typically found on floors 1-2. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 49,
                Title = "Acquire a Training Shell",
                QuestGiver = "Principal",
                Location = "Classroom Building 3F",
                DateAvailable = "10/08",
                Prerequisites = "",
                Reward = "Understanding & Diligence Up",
                Instructions = "Go to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Wicked Turret\" to have a chance to obtain it, they are typically found on floors 7-8. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 50,
                Title = "Acquire a High-Speed Gear",
                QuestGiver = "Female Student",
                Location = "Classroom Building 1F",
                DateAvailable = "10/08",
                Prerequisites = "",
                Reward = "Physical Mirror x3",
                Instructions = "Go to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Mach Wheel\" to have a chance to obtain it, they are typically found on floors 5-6. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 51,
                Title = "Acquire Fine Coal",
                QuestGiver = "Loud Old Manf",
                Location = "Northern Shopping District",
                DateAvailable = "10/09",
                Prerequisites = "Quest 24 completed",
                Reward = "¥40000",
                Instructions = "Go to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Power Castle\" to have a chance to obtain it, they are typically found on floors 3-8. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 52,
                Title = "A Twin's Independence",
                QuestGiver = "Younger Twin",
                Location = "Samegawa Riverbank",
                DateAvailable = "10/09",
                Prerequisites = "Quest 36 completed",
                Reward = "Chain Bead",
                Instructions = "NOTE: Must be completed before 11/17.\nGo to the TV world and go inside The Secret Laboratory (Naoto's dungeon). Then defeat an enemy called \"Elegant Mother\" to have a chance to obtain a Branch Headband, they are typically found on floor 8. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 53,
                Title = "Experiments in Telepathy, Part 2",
                QuestGiver = "Older Twin",
                Location = "Samegawa Riverbank",
                DateAvailable = "10/31",
                Prerequisites = "Quest 52 completed",
                Reward = "Super Sonic x3",
                Instructions = "Go to the Southern Shopping District and talk to the twin sister. Go back to the quest giver and talk to her. Then go back and talk to the other sister."
            },
            new Quest() {
                Number = 54,
                Title = "Find my Pet",
                QuestGiver = "Frantic Middle-aged Woman",
                Location = "Okina City",
                DateAvailable = "11/1",
                Prerequisites = "",
                Reward = "",
                Instructions = "Firstly, buy 3 Steak Skewers from Souzai Daigaku. Then talk to the dog in the Northern Shopping District and call it by it's name, Mika-chan. Over the next 3 days, return to the dog and feed it a Steak Skewer. Then return to the quest giver."
            },
            new Quest() {
                Number = 55,
                Title = "Revenge of Riddle Senpai!",
                QuestGiver = "Funky Student",
                Location = "Classroom Building 3F",
                DateAvailable = "11/12",
                Prerequisites = "Quest 47 completed",
                Reward = "Chewing Soul",
                Instructions = "He will ask you 4 questions. The answers are: \"Group B\", \"The way they're drawn\", \"Promethium\" and \"Need\"."
            },
            new Quest() {
                Number = 56,
                Title = "The Girl on the Rooftop, Part 2",
                QuestGiver = "Male Student",
                Location = "Classroom 2-2",
                DateAvailable = "11/22",
                Prerequisites = "Quest 2 completed",
                Reward = "Mokoi Doll",
                Instructions = "Go to the TV world and go inside Heaven (Nanako's dungeon). Then defeat an enemy called \"Prime Magus\" to have a chance to obtain an Animal Guide, they are typically found on floors 1-2. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 57,
                Title = "Desk Refurbishing, Part 4",
                QuestGiver = "Homely Student",
                Location = "Practice Building 2F",
                DateAvailable = "11/22",
                Prerequisites = "Quest 46 completed",
                Reward = "Fire Signal x3",
                Instructions = "Go to the TV world and go inside Heaven (Nanako's dungeon). Then defeat an enemy called \"Angry Table\" to have a chance to obtain Classy Lumber, they are typically found on floors 5-7. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 58,
                Title = "Acquire an Old Ore",
                QuestGiver = "Male Student",
                Location = "Practice Building 1F",
                DateAvailable = "11/22",
                Prerequisites = "Quest 33 completed",
                Reward = "Spirit Radio",
                Instructions = "Go to the TV world and go inside Heaven (Nanako's dungeon). Then defeat an enemy called \"Revelation Pesce\" to have a chance to obtain it, they are typically found on floors 6-8. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 59,
                Title = "Acquire a Modest Lamp",
                QuestGiver = "Older Man",
                Location = "Samegaqa Flood Plain",
                DateAvailable = "11/22",
                Prerequisites = "Quest 39 completed",
                Reward = "¥45000",
                Instructions = "Go to the TV world and go inside Heaven (Nanako's dungeon). Then defeat an enemy called \"Phantom Lord\" to have a chance to obtain it, they are typically found on floors 5-6. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 60,
                Title = "Acquire Samegawa's Guardian",
                QuestGiver = "Maseter Daidara",
                Location = "Daidara Metalworks",
                DateAvailable = "01/10",
                Prerequisites = "",
                Reward = "Guardian (Weapon)",
                Instructions = "Go to the Samegawa Riverbank and fish off the rock, bait the rod with an Inaba Jewel Beetle (Fish on a rainy day for better luck to catch it), for a chance to catch the Guardian. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 61,
                Title = "Find My Pet, Part 2",
                QuestGiver = "Middle-aged woman",
                Location = "Okina City",
                DateAvailable = "01/10",
                Prerequisites = "Quest 54 completed",
                Reward = "Haikara Shirt",
                Instructions = "Go to the Samegawa Riverbank and feed the cat 5 times, with a different fish each time."
            },
            new Quest() {
                Number = 62,
                Title = "Extracurricular Activities, Part 3",
                QuestGiver = "Ms. Sofue",
                Location = "Classroom Building 2F Staircase",
                DateAvailable = "01/10",
                Prerequisites = "Quest 44 completed",
                Reward = "Silver Tray",
                Instructions = "Go to the TV world and go inside Magatsu Mandala ([True Killer]'s dungeon). Then defeat an enemy called \"Solemn Machine\" to have a chance to obtain Orichalum, they are typically found on floor 6. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 63,
                Title = "Acquire Golden Chains",
                QuestGiver = "Ms. Nakayama",
                Location = "Classroom Building 3F",
                DateAvailable = "01/10",
                Prerequisites = "Quest 48 completed",
                Reward = "¥65000",
                Instructions = "Go to the TV world and go inside Magatsu Mandala ([True Killer]'s dungeon). Then defeat an enemy called \"Minotaur II\" to have a chance to obtain it (3 are required), they are typically found on floor 6. Then give the item to the quest giver."
            },
            new Quest() {
                Number = 64,
                Title = "The Riddle Senpai's Encore!",
                QuestGiver = "Funky Student",
                Location = "Classroom Building 3F",
                DateAvailable = "01/10",
                Prerequisites = "Quest 55 completed",
                Reward = "Soul Food x3",
                Instructions = "He will ask you 1 question. The answer is: \"Uruguay\"."
            },
            new Quest() {
                Number = 65,
                Title = "Kashiwagi's Special Lesson",
                QuestGiver = "Ms. Kashiwagi",
                Location = "Classroom Building 1F",
                DateAvailable = "01/16",
                Prerequisites = "",
                Reward = "Coronet Armor",
                Instructions = "She will ask you 2 questions. The answers are: \"Deoxyribonucleic Acid\" and \"Rabbit\"."
            },
            new Quest() {
                Number = 66,
                Title = "Show Me Some Cute Slippers",
                QuestGiver = "Ms. Kashiwagi",
                Location = "Classroom Building 1F",
                DateAvailable = "01/17",
                Prerequisites = "Quest 65 completed",
                Reward = "Fighter Armor",
                Instructions = "Sell Daidara Metalworks 8 Bloody Hides (Can be obtained from the \"Jotun of Blood\" enemy in Heaven on floors 8-9) to be able to buy \"Vidar Boots\". Then give the item to the boy in the Practice Building 2F."
            },
            new Quest() {
                Number = 67,
                Title = "Dazzle Me With Animal Paw Gloves",
                QuestGiver = "Ms. Kashiwagi",
                Location = "Classroom Building 1F",
                DateAvailable = "01/18",
                Prerequisites = "Quest 66 completed",
                Reward = "Magical Armor",
                Instructions = "Go to the TV world and go inside any dungeon. Then defeat an enemy called \"Golden Hand\" to have a chance to obtain Magatsu Xandrite (8 are required). Go to the Shrine at night and the Girl in White may be there. Trade her a Guardian (Fished on a rainy day using Inaba Jewel Beetle as bait) to obtain a Mondo Stone. Give all the items to the women in the Shiroku Pub during night to obtain an Animal Paw (Weapon). Then give the item to the quest giver."
            },
            new Quest() {
                Number = 68,
                Title = "Kashiwagi's Special Lesson Part 2",
                QuestGiver = "Ms. Kashiwagi",
                Location = "Classroom Building 1F",
                DateAvailable = "01/19",
                Prerequisites = "Quest 67 completed",
                Reward = "School Swimsuit",
                Instructions = "She will ask you 3 questions. The answers are: \"Raster\", \"Latin\" and \"Rome\"."
            },
            new Quest() {
                Number = 69,
                Title = "A Student Should Study",
                QuestGiver = "Principal",
                Location = "Classroom Building 3F",
                DateAvailable = "01/23",
                Prerequisites = "",
                Reward = "Victory Fan",
                Instructions = "He will ask you 4 questions. The answers are: \"Wind\", \"Upper, Middle, and Lower\", \"7\" and \"Mameluke\"."
            }
        };
    }
}
