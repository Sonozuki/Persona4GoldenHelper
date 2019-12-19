using Persona4GoldenHelper.Data.Models;
using System.Collections.Generic;

namespace Persona4GoldenHelper.Data.Context
{
    public class BookContext
    {
        public List<Book> Books { get; } = new List<Book>()
        {
            new Book(
                dateAvailable: "4/20",
                title: "The Lovely Man",
                requirement: "Buy at Yomenaido Bookstore for ¥1200.",
                effect: "Raises Courage."
            ),
            new Book(
                dateAvailable: "4/20",
                title: "Expert Study Methods",
                requirement: "Buy at Yomenaido Bookstore for ¥2800.",
                effect: "Increases Knowledge gained when studying at your desk or in the library."
            ),
            new Book(
                dateAvailable: "4/20",
                title: "Beginner Fishing",
                requirement: "Buy at Yomenaido Bookstore for ¥1600.",
                effect: "Increases the number of times you can fish before getting tired."
            ),
            new Book(
                dateAvailable: "5/6",
                title: "Off Today",
                requirement: "Buy at Yomenaido Bookstore for ¥1500.",
                effect: "Raises Understanding."
            ),
            new Book(
                dateAvailable: "5/6",
                title: "Office Work Manual",
                requirement: "Buy at Yomenaido Bookstore for ¥2800.",
                effect: "Increases Diligence gained from the envelope making part-time job."
            ),
            new Book(
                dateAvailable: "5/23",
                title: "The Gentle Way",
                requirement: "Complete Quest 18.\nThe Avid Reader, standing outside Yomenaido Bookstore, wants you to bring him a Peach Seed. Peach Seeds can be found in non-golden dungeon chests.",
                effect: "Raises Knowledge & Expression."
            ),
            new Book(
                dateAvailable: "5/29",
                title: "Witch Detective",
                requirement: "Strength Date.\nYou must clear the Steamy Bathhouse before 5/29. You will recieve a call from the Strength Social Link, agree to meet up and accept the book.\nNOTE: If you joined the basketball team, you mustn't be rank 4 or above. (Soccer doesn't have the requirement) Neither will call if the social link is maxed.",
                effect: "Raises Understanding & Diligence"
            ),
            new Book(
                dateAvailable: "6/1",
                title: "English Made Easy",
                requirement: "Buy at Yomenaido Bookstore for ¥3200.",
                effect: "Increases Expression gained from the translation part-time job."
            ),
            new Book(
                dateAvailable: "6/1",
                title: "Easy Origami",
                requirement: "Buy at Yomenaido Bookstore for ¥3000.",
                effect: "Increased Understanding gained from the origami folding part-time job."
            ),
            new Book(
                dateAvailable: "6/3",
                title: "The Punk's Way",
                requirement: "Complete Quest 20.\nYou must complete Quest 18 first.\nThe avid reader, standing outside Yomenaido Bookstore, wants you to feed a cat. Go to the Samegawa Riverbank, go to the far left and feed the cat any kind of fish. Fish can be obtained through the fishing minigame or bought from the TV shopping show.",
                effect: "Raises Knowledge & Expression."
            ),
            new Book(
                dateAvailable: "6/11",
                title: "Forever Macho",
                requirement: "Buy at Yomenaido Bookstore for ¥1200.",
                effect: "Raises Courage."
            ),
            new Book(
                dateAvailable: "6/11",
                title: "100 Ghost Stories",
                requirement: "Buy at Yomenaido Bookstore for ¥3400.",
                effect: "Increases Courage gained from the hospital janitor part-time job."
            ),
            new Book(
                dateAvailable: "6/11",
                title: "Catching Bugs",
                requirement: "Buy at Yomenaido Bookstore for ¥1800.",
                effect: "Increases the number of bugs you can catch at one time."
            ),
            new Book(
                dateAvailable: "6/28",
                title: "Short on Cash",
                requirement: "Buy at Yomenaido Bookstore for ¥1500.",
                effect: "Raises Understanding."
            ),
            new Book(
                dateAvailable: "6/28",
                title: "Expert Fishing",
                requirement: "Buy at Yomenaido Bookstore for ¥4800.",
                effect: "Makes fishing easier by adding a quick-reel option. (Press △ when prompted)"
            ),
            new Book(
                dateAvailable: "7/3",
                title: "Guide to Pests",
                requirement: "Complete Quest 34.\nYou must complete Quest 20 first.\nThe avid reader, standing outside Yomenaido Bookstore, wants you to bring him a pair of Hard Boots. Hard Boots can be bought from Daidara Metalworks once you've sold them 5 Thick Hide. Thick Hide is dropped from the Dancing Hand enemy, these are common on floors 5-8 in the Steamy Bathhouse.",
                effect: "Raises Knowledge & Courage."
            ),
            new Book(
                dateAvailable: "7/15",
                title: "Man of History",
                requirement: "Buy at Yomenaido Bookstore for ¥1200.",
                effect: "Raises Courage."
            ),
            new Book(
                dateAvailable: "7/15",
                title: "Home Gardening",
                requirement: "Buy at Yomenaido Bookstore for ¥3600.",
                effect: "Reduces the number of days required to harvest vegetables by 1."
            ),
            new Book(
                dateAvailable: "7/15",
                title: "Poly-land",
                requirement: "Strength Date.\nYou must go to your room on the evening of of 7/15 before leaving the house to do a time-passing activity. You will recieve a call inviting you to hang out on 7/17. (The call doesn't pass time)\nNOTE: If you joined the basketball team, you mustn't be rank 5 or 6. (Soccer doesn't have the requirement) Neither will call if the social link is maxed.",
                effect: "Raises Knowledge & Diligence."
            ),
            new Book(
                dateAvailable: "8/4",
                title: "Changing Careers",
                requirement: "Buy at Yomenaido Bookstore for ¥1500.",
                effect: "Raises Understanding."
            ),
            new Book(
                dateAvailable: "8/4",
                title: "Hyperspeed Reading",
                requirement: "Buy at Yomenaido Bookstore for ¥9800.",
                effect: "Allows you to read 2 chapters of a book per sitting."
            ),
            new Book(
                dateAvailable: "8/10",
                title: "The O-Cha Way",
                requirement: "Strength Date.\nYou will recieve a call from the Strength Social Link, agree to meet up and accept the book.\nNOTE: If you joined the basketball team, you mustn't be rank 5 or 6. (Soccer doesn't have the requirement) Neither will call if the social link is maxed.",
                effect: "Raises Knowledge & Expression."
            ),
            new Book(
                dateAvailable: "8/11",
                title: "Picross Rules!",
                requirement: "Complete Quest 40.\nYou must complete Quest 34 first.\nThe avid reader, standing outside Yomenaido Bookstore, wants you to bring him 3 Fashionable Dishes. Fashionable Dishes are dropped from the Sky Balance enemy, these are common on floors 9-10 in the Marukyu Striptease.",
                effect: "Raises Understanding & Diligence."
            ),
            new Book(
                dateAvailable: "8/21",
                title: "The Divine Way",
                requirement: "Go to the Summer Festive with a girl.\nIf you are in a lovers relationship with a girl, she will call you inviting you to the festival. Rise will call at any rank, Ai & Ayane will call at rink 3 or above, and Yumi will call at rank 1 or 2.",
                effect: "Raises Knowledge & Expression"
            ),
            new Book(
                dateAvailable: "8/24",
                title: "Man-God",
                requirement: "Buy at Yomenaido Bookstore for ¥1200.",
                effect: "Raises Courage."
            ),
            new Book(
                dateAvailable: "8/24",
                title: "Food Fight!",
                requirement: "Buy at Yomenaido Bookstore for ¥4200.",
                effect: "Increases all stat gains when eating at Chinese Diner Aiya"
            ),
            new Book(
                dateAvailable: "9/20",
                title: "Sensei's Friends",
                requirement: "Buy at Yomenaido Bookstore for ¥1500.",
                effect: "Raises Understanding."
            ),
            new Book(
                dateAvailable: "9/26",
                title: "Who Am I?",
                requirement: "Complete Quest 45.\nYou must complete Quest 40 first.\nThe avid reader, standing outside Yomenaido Bookstore, will question you 4 questions about the books he previously gave you. The answers are: \"Judo medalists' names.\", \"How one should live as a punk.\", \"2 pages per pest\", and \"Me.\"",
                effect: "Raises Knowledge & Diligence."
            ),
            new Book(
                dateAvailable: "10/12",
                title: "Farewell to Man",
                requirement: "Buy at Yomenaido Bookstore for ¥1200.",
                effect: "Raises Courage."
            ),
            new Book(
                dateAvailable: "11/1",
                title: "The Final Lesson",
                requirement: "Buy at Yomenaido Bookstore for ¥1500.",
                effect: "Raises Understanding."
            ),
            new Book(
                dateAvailable: "11/1",
                title: "World-Class Bugs",
                requirement: "Buy at Yomenaido Bookstore for ¥4800.",
                effect: "Increases the number of bugs you can catch at one time even more."
            ),
            new Book(
                dateAvailable: "-",
                title: "The Ramen Way",
                requirement: "Eat at Chinese Diner Aiya 8 times. (Doesn't need to be rainy day special, can be day or night)",
                effect: "Raises Knowlege & Understanding."
            )
        };
    }
}
