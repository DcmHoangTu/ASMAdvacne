using System;
using System.Security.Cryptography.X509Certificates;
using Necklace.ASM2._1.User;
using Necklace.ASM2.Decorator;
using Necklace.ASM2.Material;

namespace Necklace.ASM2
{
    public class test1
    {
        static void Main(string[] args)
        {
            double originalPrice = 0; // Declare originalPrice at the start of the program
            User user = new User();
            Necklace necklace = null;

            int maxDiamonds = 20;
            int maxRubies = 20;
            int maxPendants = 5;

            SilverMemberObserver silverObserver = new SilverMemberObserver();
            GoldMemberObserver goldObserver = new GoldMemberObserver();
            DiamondMemberObserver diamondObserver = new DiamondMemberObserver();

            user.Attach(silverObserver);
            user.Attach(goldObserver);
            user.Attach(diamondObserver);

            // Menu
            user.AddAmountSpent(originalPrice);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Membership level: " + user.MembershipLevel);
            Console.WriteLine("Select a necklace type:");
            Console.WriteLine("1. Gold");
            Console.WriteLine("2. WhiteGold");
            Console.WriteLine("3. Silver");
            Console.WriteLine("4. Exit");
            Console.Write("Please enter your choice: ");

            try
            {
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    Console.Write("Please enter your choice: ");
                }

                switch (choice)
                {
                    case 1:
                        necklace = new Gold();
                        break;
                    case 2:
                        necklace = new WhiteGold();
                        break;
                    case 3:
                        necklace = new Silver();
                        break;
                    case 4:
                        Console.WriteLine("Exiting program. Thank you for using the necklace selection tool.");
                        return; // Thoát khỏi phương thức hiện tại, kết thúc chương trình.
                    default:
                        Console.WriteLine("Invalid choice. Using a Gold necklace by default.");
                        necklace = new Gold();
                        break;
                }

                originalPrice = necklace.GetPrice(); // Initialize originalPrice here after necklace creation

                bool addingDecorations = true;
                while (addingDecorations)
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Do you want to add a decoration? (y/n):");
                    string addDecorationInput;
                    do
                    {
                        Console.Write("Please enter 'y' or 'n': ");
                        addDecorationInput = Console.ReadLine().ToLower();
                    } while (addDecorationInput != "y" && addDecorationInput != "n");

                    if (addDecorationInput == "y")
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Select a decoration type:");
                        Console.WriteLine("1. Diamond");
                        Console.WriteLine("2. Ruby");
                        Console.WriteLine("3. Pendant");
                        Console.Write("Please enter your choice: ");

                        try
                        {
                            int decorationChoice;
                            while (!int.TryParse(Console.ReadLine(), out decorationChoice) || decorationChoice < 1 || decorationChoice > 3)
                            {
                                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                                Console.Write("Please enter your choice: ");
                            }

                            switch (decorationChoice)
                            {
                                case 1:
                                    if (maxDiamonds > 0)
                                    {
                                        necklace = new Diamond(necklace);
                                        maxDiamonds--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Maximum of 20 diamonds can be added.");
                                    }
                                    break;
                                case 2:
                                    if (maxRubies > 0)
                                    {
                                        necklace = new Ruby(necklace);
                                        maxRubies--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Maximum of 20 rubies can be added.");
                                    }
                                    break;
                                case 3:
                                    if (maxPendants > 0)
                                    {
                                        necklace = new Pendant(necklace);
                                        maxPendants--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Maximum of 5 pendants can be added.");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice. Skipping this decoration.");
                                    break;
                            }
                            originalPrice = necklace.GetPrice(); // Update originalPrice after each decoration
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                    else
                    {
                        addingDecorations = false;
                    }
                }

                Console.WriteLine("-----------------------");
                user.AddAmountSpent(originalPrice);
                double discountAmount = originalPrice * user.DiscountRatio;
                double finalPrice = originalPrice - discountAmount;

                Console.WriteLine("Membership level: " + user.MembershipLevel);
                Console.WriteLine("Final Necklace:");
                Console.WriteLine("Name: " + necklace.GetName() + ",");
                Console.WriteLine("Weight: " + necklace.GetWeight() + " grams");
                Console.WriteLine("Material: " + necklace.GetMaterial());
                Console.WriteLine("Description: " + necklace.GetDescription());

                // Test
                Console.WriteLine("Original price: " + originalPrice);
                Console.WriteLine("Discount applied: " + user.DiscountRatio);
                Console.WriteLine("Discount amount: " + discountAmount);
                Console.WriteLine("Final price after discount: " + finalPrice);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}

