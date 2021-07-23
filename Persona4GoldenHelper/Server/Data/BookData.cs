using Persona4GoldenHelper.Shared.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Server.Data
{
    /// <summary>The book data.</summary>
    public static class BookData
    {
        /*********
        ** Accesors
        *********/
        /// <summary>The book data.</summary>
        public static List<Book> Books { get; } = new()
        {
            new("4/20", "The Lovely Man", "Buy at Yomenaido Bookstore for ¥1200.", "Raises Courage."),
            new("4/20", "Expert Study Methods", "Buy at Yomenaido Bookstore for ¥2800.", "Increases Knowledge gained when studying at your desk or in the library."),
            new("4/20", "Beginner Fishing", "Buy at Yomenaido Bookstore for ¥1600.", "Increases the number of times you can fish before getting tired."),
            new("5/6", "Off Today", "Buy at Yomenaido Bookstore for ¥1500.", "Raises Understanding."),
            new("5/6", "Office Work Manual", "Buy at Yomenaido Bookstore for ¥2800.", "Increases Diligence gained from the envelope making part-time job."),
            new("5/23", "The Gentle Way", "Complete Quest 18.\nThe Avid Reader, standing outside Yomenaido Bookstore, wants you to bring him a Peach Seed. Peach Seeds can be found in non-golden dungeon chests.", "Raises Knowledge & Expression."),
            new("5/29", "Witch Detective", "Strength Date.\nYou must clear the Steamy Bathhouse before 5/29. You will recieve a call from the Strength Social Link, agree to meet up and accept the book.\nNOTE: If you joined the basketball team, you mustn't be rank 4 or above. (Soccer doesn't have the requirement) Neither will call if the social link is maxed.", "Raises Understanding & Diligence"),
            new("6/1", "English Made Easy", "Buy at Yomenaido Bookstore for ¥3200.", "Increases Expression gained from the translation part-time job."),
            new("6/1", "Easy Origami", "Buy at Yomenaido Bookstore for ¥3000.", "Increased Understanding gained from the origami folding part-time job."),
            new("6/3", "The Punk's Way", "Complete Quest 20.\nYou must complete Quest 18 first.\nThe avid reader, standing outside Yomenaido Bookstore, wants you to feed a cat. Go to the Samegawa Riverbank, go to the far left and feed the cat any kind of fish. Fish can be obtained through the fishing minigame or bought from the TV shopping show.", "Raises Knowledge & Expression."),
            new("6/11", "Forever Macho", "Buy at Yomenaido Bookstore for ¥1200.", "Raises Courage."),
            new("6/11", "100 Ghost Stories", "Buy at Yomenaido Bookstore for ¥3400.", "Increases Courage gained from the hospital janitor part-time job."),
            new("6/11", "Catching Bugs", "Buy at Yomenaido Bookstore for ¥1800.", "Increases the number of bugs you can catch at one time."),
            new("6/28", "Short on Cash", "Buy at Yomenaido Bookstore for ¥1500.", "Raises Understanding."),
            new("6/28", "Expert Fishing", "Buy at Yomenaido Bookstore for ¥4800.", "Makes fishing easier by adding a quick-reel option. (Press ? when prompted)"),
            new("7/3", "Guide to Pests", "Complete Quest 34.\nYou must complete Quest 20 first.\nThe avid reader, standing outside Yomenaido Bookstore, wants you to bring him a pair of Hard Boots. Hard Boots can be bought from Daidara Metalworks once you've sold them 5 Thick Hide. Thick Hide is dropped from the Dancing Hand enemy, these are common on floors 5-8 in the Steamy Bathhouse.", "Raises Knowledge & Courage."),
            new("7/15", "Man of History", "Buy at Yomenaido Bookstore for ¥1200.", "Raises Courage."),
            new("7/15", "Home Gardening", "Buy at Yomenaido Bookstore for ¥3600.", "Reduces the number of days required to harvest vegetables by 1."),
            new("7/15", "Poly-land", "Strength Date.\nYou must go to your room on the evening of of 7/15 before leaving the house to do a time-passing activity. You will recieve a call inviting you to hang out on 7/17. (The call doesn't pass time)\nNOTE: If you joined the basketball team, you mustn't be rank 5 or 6. (Soccer doesn't have the requirement) Neither will call if the social link is maxed.", "Raises Knowledge & Diligence."),
            new("8/4", "Changing Careers", "Buy at Yomenaido Bookstore for ¥1500.", "Raises Understanding."),
            new("8/4", "Hyperspeed Reading", "Buy at Yomenaido Bookstore for ¥9800.", "Allows you to read 2 chapters of a book per sitting."),
            new("8/10", "The O-Cha Way", "Strength Date.\nYou will recieve a call from the Strength Social Link, agree to meet up and accept the book.\nNOTE: If you joined the basketball team, you mustn't be rank 5 or 6. (Soccer doesn't have the requirement) Neither will call if the social link is maxed.", "Raises Knowledge & Expression."),
            new("8/11", "Picross Rules!", "Complete Quest 40.\nYou must complete Quest 34 first.\nThe avid reader, standing outside Yomenaido Bookstore, wants you to bring him 3 Fashionable Dishes. Fashionable Dishes are dropped from the Sky Balance enemy, these are common on floors 9-10 in the Marukyu Striptease.", "Raises Understanding & Diligence."),
            new("8/21", "The Divine Way", "Go to the Summer Festive with a girl.\nIf you are in a lovers relationship with a girl, she will call you inviting you to the festival. Rise will call at any rank, Ai & Ayane will call at rink 3 or above, and Yumi will call at rank 1 or 2.", "Raises Knowledge & Expression"),
            new("8/24", "Man-God", "Buy at Yomenaido Bookstore for ¥1200.", "Raises Courage."),
            new("8/24", "Food Fight!", "Buy at Yomenaido Bookstore for ¥4200.", "Increases all stat gains when eating at Chinese Diner Aiya"),
            new("9/20", "Sensei's Friends", "Buy at Yomenaido Bookstore for ¥1500.", "Raises Understanding."),
            new("9/26", "Who Am I?", "Complete Quest 45.\nYou must complete Quest 40 first.\nThe avid reader, standing outside Yomenaido Bookstore, will question you 4 questions about the books he previously gave you. The answers are: \"Judo medalists' names.\", \"How one should live as a punk.\", \"2 pages per pest\", and \"Me.\"", "Raises Knowledge & Diligence."),
            new("10/12", "Farewell to Man", "Buy at Yomenaido Bookstore for ¥1200.", "Raises Courage."),
            new("11/1", "The Final Lesson", "Buy at Yomenaido Bookstore for ¥1500.", "Raises Understanding."),
            new("11/1", "World-Class Bugs", "Buy at Yomenaido Bookstore for ¥4800.", "Increases the number of bugs you can catch at one time even more."),
            new("-", "The Ramen Way", "Eat at Chinese Diner Aiya 8 times. (Doesn't need to be rainy day special, can be day or night)", "Raises Knowlege & Understanding.")
        };

        /// <summary>The book order data.</summary>
        public static List<string> BookOrder { get; } = new() { "The Lovely Man", "Forever Macho", "Man of History", "Man-God", "Farewell to Man", "Off Today", "Short on Cash", "Changing Careers", "Sensei's Friends", "The Final Lesson", "The O-Cha Way", "The Gentle Way", "The Divine Way", "The Ramen Way", "The Punk's Way", "Witch Detective", "Poly-land", "Guide to Pests", "Picross Rules!", "Who Am I?", "Expert Study Methods", "English Made Easy", "100 Ghost Stories", "Office Work Manual", "Easy Origami", "Food Fight!", "Beginner Fishing", "Expert Fishing", "Catching Bugs", "World-Class Bugs", "Home Gardening", "Hyperspeed Reading" };
    }
}
