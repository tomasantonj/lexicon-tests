using System;
// Class testing program
namespace BusinessCardApp {
    class Program {
        static void Main(string[] args) {
            BusinessCard card = new BusinessCard{
                Name = BusinessCard.CreateCard() // This will call the static method to create a card
            };
            Console.WriteLine($"Business Card Name: {card.Name}");
            // ask user if he wants to save the card
            Console.Write("Do you want to save the card? (y/n): ");
            string saveResponse = Console.ReadLine() ?? string.Empty; // Use null-coalescing operator to handle null input
            if (saveResponse.ToLower() == "y") {
                BusinessCard.SaveCard(card); // Call the static method to save the card
                Console.WriteLine("Card saved successfully.");
            } else {
                Console.WriteLine("Card not saved.");
                // ask if user wants to update the card
                Console.Write("Do you want to update the card? (y/n): ");
                //run update card method if user wants to update the card
                string updateResponse = Console.ReadLine() ?? string.Empty; // Use null-coalescing operator to handle null input
                // run UpdateCard method if yes
                if (updateResponse.ToLower() == "y") {
                    BusinessCard.UpdateCard(card); // Call the static method to update the card
                    Console.WriteLine("Card updated successfully.");
                } else {
                    Console.WriteLine("Card not updated.");
                    // ask if user wants to delete the card
                    Console.Write("Do you want to delete the card? (y/n): ");
                    string deleteResponse = Console.ReadLine() ?? string.Empty; // Use  operator to handle null input
                    // run DeleteCard method if yes
                    if (deleteResponse.ToLower() == "y") {
                        BusinessCard.DeleteCard(card); // Call the static method to delete the card
                        Console.WriteLine("Card deleted successfully.");
                    } else {
                        Console.WriteLine("Card not deleted, it will be saved for later use. You can view your cards in the app");
                        // TODO: save temp card to file.txt/database and let user know that there are unused cards in the app.
                    }
                }
            }
        }
    }

    class BusinessCard {
        //TODO: add additional properties like email, phone number, address etc
        public required string Name { get; set; }
        public static string CreateCard() {
            Console.WriteLine("Creating a business card...");
            // Use Readline to fetch name from the user
            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? string.Empty; // !!Use null-coalescing operator to handle null input
            if (string.IsNullOrWhiteSpace(name)) {
                Console.WriteLine("Name cannot be empty. Please try again.");
                return CreateCard(); // !!Recursively call to get a valid name
            }
            return name; // Return the valid name
        }
        public static void SaveCard(BusinessCard card) {
            // TODO Save card to file.txt/database/generate printable card etc
            Console.WriteLine($"Saving card for {card.Name}...");
        }
        public static void UpdateCard(BusinessCard card) {
            // run CreateCard again to get new details
            Console.WriteLine($"Updating card for {card.Name}...");
            card.Name = CreateCard(); // Call the static method to create a new card
            Console.WriteLine($"Updated card name to {card.Name}.");
        }
        public static void DeleteCard(BusinessCard card) {
            // TODO: Delete the card from file.txt/database
            Console.WriteLine($"Deleting card for {card.Name}...");
        }
    }
}   
