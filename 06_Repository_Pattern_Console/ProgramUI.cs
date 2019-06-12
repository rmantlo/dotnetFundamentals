using _06_Repository_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Repository_Pattern_Console
{
    //this file, called by main, where user will actually interact
    public class ProgramUI
    {
        private StreamingContentRepository _streamingRepo = new StreamingContentRepository();
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRunMenu = true;

            while (continueToRunMenu)
            {
                Console.Clear();
                Console.WriteLine("Enter number of option you'd like to select.\n" +
                    "1. Show all streaming content.\n" +
                    "2. Find streaming content by title.\n" +
                    "3. Create new streaming content.\n" +
                    "4. Remove streaming content.\n" +
                    "5. Update streaming content.\n" +
                    "6. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //show all content
                        ShowAllContent();
                        break;
                    case "2":
                        FindContentByTitle();
                        break;
                    case "3":
                        CreateContent();
                        break;
                    case "4":
                        RemoveContentFromList();
                        break;
                    case "5":
                        UpdateContentFromList();
                        break;
                    case "6":
                        continueToRunMenu = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void UpdateContentFromList()
        {
            Console.WriteLine("Please enter title of content you plan to update.");
            string userInput = Console.ReadLine();
            StreamingContent content = _streamingRepo.GetContentByTitle(userInput);
            Console.WriteLine($"\n{content.Title} - {content.Description}\n" +
                $"{content.StarRating} Stars\n" +
                $"Run time: {content.RunTimeInMinutes} minutes\n" +
                $"Maturity rating: {content.MaturityRating}\n" +
                $"Family Friendly: {content.IsFamilyFriendly}\n" +
                $"Genre: {content.TypeOfGenre}");
            Console.WriteLine("\nContent Found");
            Console.WriteLine("Please enter a new title: ");
            content.Title = Console.ReadLine();
            Console.WriteLine("Enter content new description: ");
            content.Description = Console.ReadLine();
            Console.WriteLine("Enter new content run time in minutes: ");
            content.RunTimeInMinutes = double.Parse(Console.ReadLine()); //convert
            Console.WriteLine("Enter new Content Star rating (1-10)");
            content.StarRating = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter new Maturity rating (G, PG, etc): ");
            content.MaturityRating = Console.ReadLine();
            Console.WriteLine("Is the content Family Friendly? (True/False)");
            content.IsFamilyFriendly = bool.Parse(Console.ReadLine());
            Console.WriteLine("Please choose a new genre." +
                "1. Action\n" +
                "2. Bromance\n" +
                "3. Documentary\n" +
                "4. Drama\n" +
                "5. Horror\n" +
                "6. Noir\n" +
                "7. RomCom\n" +
                "8. SciFi\n" +
                "9. WildWest");
            int genreNumber = int.Parse(Console.ReadLine());
            content.TypeOfGenre = (GenreType)genreNumber; //called casting
            _streamingRepo.UpdateContentInList(userInput, content);
            //Console.WriteLine($"\n{updatedContent.Title} - {updatedContent.Description}\n" +
            //    $"{updatedContent.StarRating} Stars\n" +
              //  $"Run time: {updatedContent.RunTimeInMinutes} minutes\n" +
                //$"Maturity rating: {updatedContent.MaturityRating}\n" +
              //  $"Family Friendly: {updatedContent.IsFamilyFriendly}\n" +
              //  $"Genre: {updatedContent.TypeOfGenre}");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        private void RemoveContentFromList()
        {
            Console.WriteLine("Please enter title of content to remove");
            string userInput = Console.ReadLine();
            StreamingContent content = _streamingRepo.GetContentByTitle(userInput);
            if (content == null)
            {
                Console.WriteLine("Not a known content title, please try again");
            }
            else
            {
                Console.WriteLine($"Added content to List:\n" +
                $"\n{content.Title} - {content.Description}\n" +
                $"{content.StarRating} Stars\n" +
                $"Run time: {content.RunTimeInMinutes} minutes\n" +
                $"Maturity rating: {content.MaturityRating}\n" +
                $"Family Friendly: {content.IsFamilyFriendly}\n" +
                $"Genre: {content.TypeOfGenre}");
                _streamingRepo.RemoveContentFromList(content);
                Console.WriteLine("\nContent deleted. Press any button to continue...");
                Console.ReadKey();
            }
        }
        private void CreateContent()
        {
            StreamingContent content = new StreamingContent();
            Console.WriteLine("\nCreating new content");
            Console.WriteLine("Please enter a title: ");
            content.Title = Console.ReadLine();
            Console.WriteLine("Enter content description: ");
            content.Description = Console.ReadLine();
            Console.WriteLine("Enter content run time in minutes: ");
            content.RunTimeInMinutes = double.Parse(Console.ReadLine()); //convert
            Console.WriteLine("Enter Content Star rating (1-10)");
            content.StarRating = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Maturity rating (G, PG, etc): ");
            content.MaturityRating = Console.ReadLine();
            Console.WriteLine("Is the content Family Friendly? (True/False)");
            content.IsFamilyFriendly = bool.Parse(Console.ReadLine());
            Console.WriteLine("Please choose a genre." +
                "1. Action\n" +
                "2. Bromance\n" +
                "3. Documentary\n" +
                "4. Drama\n" +
                "5. Horror\n" +
                "6. Noir\n" +
                "7. RomCom\n" +
                "8. SciFi\n" +
                "9. WildWest");
            int genreNumber = int.Parse(Console.ReadLine());
            content.TypeOfGenre = (GenreType)genreNumber; //called casting


            _streamingRepo.AddContentToList(content);
            Console.WriteLine($"Added content to List:\n" +
                $"\n{content.Title} - {content.Description}\n" +
                $"{content.StarRating} Stars\n" +
                $"Run time: {content.RunTimeInMinutes} minutes\n" +
                $"Maturity rating: {content.MaturityRating}\n" +
                $"Family Friendly: {content.IsFamilyFriendly}\n" +
                $"Genre: {content.TypeOfGenre}");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        private void SeedContentList()
        {
            StreamingContent rubber = new StreamingContent("Rubber", GenreType.Horror, "Evil tire murders people.", 124, 5.8, "R", false);
            StreamingContent toyStory = new StreamingContent("Toy Story", GenreType.Bromance, "Toys work together to return home.", 155, 10, "PG", true);
            StreamingContent starwars = new StreamingContent("Starwars", GenreType.SciFi, "Space people fight each other.", 300, 2.6, "PG-13", true);

            _streamingRepo.AddContentToList(rubber);
            _streamingRepo.AddContentToList(toyStory);
            _streamingRepo.AddContentToList(starwars);
        }
        private void ShowAllContent()
        {
            List<StreamingContent> contentList = _streamingRepo.GetStreamingContentList();
            foreach (StreamingContent item in contentList)
            {
                Console.WriteLine($"{item.Title} - {item.Description}");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        private void FindContentByTitle()
        {
            Console.WriteLine("\nPlease enter title of content.");
            string userInput = Console.ReadLine();
            StreamingContent content = _streamingRepo.GetContentByTitle(userInput);
            if (content != null)
            {

                Console.WriteLine($"\n{content.Title} - {content.Description}\n" +
                    $"{content.StarRating} Stars\n" +
                    $"Run time: {content.RunTimeInMinutes} minutes\n" +
                    $"Maturity rating: {content.MaturityRating}\n" +
                    $"Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"Genre: {content.TypeOfGenre}");
            }
            else
            {
                Console.WriteLine("No content found");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
