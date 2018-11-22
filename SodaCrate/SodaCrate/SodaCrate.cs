using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaCrate
{
    class SodaCrate
    {
        //String to store the name given by the user.
        public static string Name;

        //The index is to set the defualt value for the menu to funktion properly.
        private static int Index = 0;

        //Variables for the array.
        private static Bottle[] bottles = new Bottle[25];
        private static int BottleCount = 0;
        private static int MaxNumberOfBottles = 25;
        private static int MinNumberOfBottles = 0;

        //The method that generates the menu and makes it funktion with arrow and enter key.
        private static string Menu(List<string> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                if (i == Index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(options[i]);
                }
                else
                {
                    Console.WriteLine(options[i]);
                }
                Console.ResetColor();
            }
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    if (Index <= 0)
                    {
                        Index = options.Count - 1;
                    }
                    else { Index--; }
                    break;
                case ConsoleKey.DownArrow:
                    if (Index == options.Count - 1)
                    {
                        Index = 0;
                    }
                    else { Index++; }
                    break;
                case ConsoleKey.Enter:
                    return options[Index];
                default:
                    break;
            }
            Console.Clear();
            return "";
        }

        //This method generates the main menu with all the options.
        public static void MainMenu()
        {
            List<string> mainMenu = new List<string>()
            {
                "Add soda",
                "Remove soda",
                "Search for soda by type",
                "Check status of your soda crate",
                "Calculate the total cost",
                "Exit"
            };

            Console.CursorVisible = false;
            while (true)
            {
                Console.WriteLine($"Hello {SodaCrate.Name}! What can I do for you today? \nUse your arrow key and enter key to navigate! \n");

                string userSelection = Menu(mainMenu);
                switch (userSelection)
                {
                    case "Add soda":
                        Console.Clear();
                        Index = 0;
                        AddSoda(GetBottleSortimentSodaNames());
                        break;

                    case "Remove soda":
                        Console.Clear();
                        Index = 0;
                        RemoveSoda();
                        break;

                    case "Search for soda by type":
                        Console.Clear();
                        Index = 0;
                        FindSodaByType();
                        break;

                    case "Check status of your soda crate":
                        Console.Clear();
                        Index = 0;
                        StatusOfTheSodaCrate();
                        break;

                    case "Calculate the total cost":
                        Console.Clear();
                        Index = 0;
                        CalculateCost();
                        break;

                    case "Exit":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }

        //The method to choose which soda the user wants add.
        public static void AddSoda(List<string> sodaNames)
        {
            Console.CursorVisible = false;
            while (true)
            {
                Console.WriteLine("Which soda would you like to add?\n");
                string userSelection = Menu(sodaNames);
                switch (userSelection)
                {
                    case "Loka":
                        AddBottleToCrate(new Loka());
                        Console.Clear();
                        Console.WriteLine("Added Loka \n");
                        break;

                    case "Ramlösa":
                        AddBottleToCrate(new Ramlösa());
                        Console.Clear();
                        Console.WriteLine("Added Ramlös \n");
                        break;

                    case "Bonaqua":
                        AddBottleToCrate(new Bonaqua());
                        Console.Clear();
                        Console.WriteLine("Added Bonaqua \n");
                        break;

                    case "Coca-Cola":
                        AddBottleToCrate(new CocaCola());
                        Console.Clear();
                        Console.WriteLine("Added Coca-Cola \n");
                        break;

                    case "Coca-Cola Zero":
                        AddBottleToCrate(new CocaColaZero());
                        Console.Clear();
                        Console.WriteLine("Added Coca-Cola Zero \n");
                        break;

                    case "Coca-Cola Light":
                        AddBottleToCrate(new CocaColaLight());
                        Console.Clear();
                        Console.WriteLine("Added Coca-Cola Light \n");
                        break;

                    case "Fanta":
                        AddBottleToCrate(new Fanta());
                        Console.Clear();
                        Console.WriteLine("Added Fanta \n");
                        break;

                    case "Fanta Exotic":
                        AddBottleToCrate(new FantaExotic());
                        Console.Clear();
                        Console.WriteLine("Added Fanta Exotic \n");
                        break;

                    case "Sprite":
                        AddBottleToCrate(new Sprite());
                        Console.Clear();
                        Console.WriteLine("Added Sprite \n");
                        break;

                    case "Heineken":
                        AddBottleToCrate(new Heineken());
                        Console.Clear();
                        Console.WriteLine("Added Heineken \n");
                        break;

                    case "Tuborg":
                        AddBottleToCrate(new Tuborg());
                        Console.Clear();
                        Console.WriteLine("Added Tuborg \n");
                        break;

                    case "Falcon":
                        AddBottleToCrate(new Falcon());
                        Console.Clear();
                        Console.WriteLine("Added Falcon \n");
                        break;

                    case "Norrlands Guld":
                        AddBottleToCrate(new NorrlandsGuld());
                        Console.Clear();
                        Console.WriteLine("Added Norrlands Guld \n");
                        break;

                    case "Check status of your soda crate":
                        Console.Clear();
                        Index = 0;
                        StatusOfTheSodaCrate();
                        break;

                    case "Return to main menu":
                        Console.Clear();
                        Index = 0;
                        MainMenu();
                        break;

                    default:
                        break;
                }
            }
        }

        //The method to add sodas to the array.
        private static void AddBottleToCrate(Bottle bottle)
        {
            if (BottleCount >= MaxNumberOfBottles)
            {
                Console.WriteLine($"You can only have {MaxNumberOfBottles} bottles in a crate!");
            }
            else
            {
                bottles[BottleCount] = bottle;
                BottleCount++;
            }
        }

        //The method to choose which soda the user wants to remove.
        public static void RemoveSoda()
        {
            Console.CursorVisible = false;
            while (true)
            {
                Console.WriteLine("Which soda would you like to remove?\n");

                string userSelection = Menu(GetBottleSortimentSodaNames());
                switch (userSelection)
                {
                    case "Coca-Cola":
                        RemoveBottleFromCrate("Coca-Cola");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Coca-Cola\n");
                        break;

                    case "Coca-Cola Zero":
                        RemoveBottleFromCrate("Coca-Cola Zero");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Coca-Cola Zero\n");
                        break;

                    case "Coca-Cola Light":
                        RemoveBottleFromCrate("Coca-Cola Light");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Coca-Cola Light\n");
                        break;

                    case "Fanta":
                        RemoveBottleFromCrate("Fanta");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Fanta\n");
                        break;

                    case "Fanta Exotic":
                        RemoveBottleFromCrate("Fanta Exotic");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Fanta Exotic\n");
                        break;

                    case "Sprite":
                        RemoveBottleFromCrate("Sprite");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Sprite\n");
                        break;

                    case "Loka":
                        RemoveBottleFromCrate("Loka");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Loka\n");
                        break;

                    case "Ramlösa":
                        RemoveBottleFromCrate("Ramlösa");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Ramlösa\n");
                        break;

                    case "Bonaqua":
                        RemoveBottleFromCrate("Bonaqua");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Bonaqua\n");
                        break;

                    case "Heineken":
                        RemoveBottleFromCrate("Heineken");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Heineken\n");
                        break;

                    case "Tuborg":
                        RemoveBottleFromCrate("Tuborg");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Tuborg\n");
                        break;

                    case "Falcon":
                        RemoveBottleFromCrate("Falcon");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Falcon\n");
                        break;

                    case "Norrlands Guld":
                        RemoveBottleFromCrate("Norrlands Guld");
                        Console.Clear();
                        Console.WriteLine("Removed 1 Norrlands Guld\n");
                        break;

                    case "Check status of your soda crate":
                        Console.Clear();
                        Index = 0;
                        StatusOfTheSodaCrate();
                        break;

                    case "Return to main menu":
                        Console.Clear();
                        Index = 0;
                        MainMenu();
                        break;

                    default:
                        break;
                }
            }
        }

        //The method to remove sodas from the array.
        private static void RemoveBottleFromCrate(string bottleName)
        {
            if (BottleCount > MinNumberOfBottles)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    for (int index = i; index < bottles.Length; index++)
                    {
                        if (bottles[index] != null)
                        {
                            bottles[i] = bottles[index];
                        }
                        else bottles[index - 1] = null;
                    }
                }
            }
            else
            {
                Console.WriteLine($"You can only remove what you have inserted to the crate. the lowest number is {MinNumberOfBottles}");
            }
        }

        //The method to find soda by its type "Water" "Beer" "Soda"
        public static void FindSodaByType()
        {
            while (true)
            {
                Console.WriteLine("What type of soda do you want?\n");

                Console.CursorVisible = false;
                var listStringSodaSorts = new List<string>();
                foreach (Bottle bottle in GetBottleSortiment())
                {
                    if (!listStringSodaSorts.Contains(bottle.GetSodaType()))
                    {
                        listStringSodaSorts.Add(bottle.GetSodaType());
                    }
                }
                listStringSodaSorts.Add("Return to main menu");

                var selectedSort = Menu(listStringSodaSorts);
                if (selectedSort == "Soda")
                {
                    Console.Clear();
                    var sortiment = GetBottleSortiment();
                    var sortedSortiment = new List<string>();
                    foreach (Bottle bottle in sortiment)
                    {
                        if (bottle.GetSodaType() == "Soda")
                        {
                            sortedSortiment.Add(bottle.GetSodaName());
                        }
                    }
                    sortedSortiment.Add("Return to main menu");
                    AddSoda(sortedSortiment);
                    Console.Clear();
                }

                if (selectedSort == "Water")
                {
                    Console.Clear();
                    var sortiment = GetBottleSortiment();
                    var sortedSortiment = new List<string>();
                    foreach (Bottle bottle in sortiment)
                    {
                        if (bottle.GetSodaType() == "Water")
                        {
                            sortedSortiment.Add(bottle.GetSodaName());
                        }
                    }
                    sortedSortiment.Add("Return to main menu");
                    AddSoda(sortedSortiment);
                    Console.Clear();
                }

                if (selectedSort == "Beer")
                {
                    Console.Clear();
                    var sortiment = GetBottleSortiment();
                    var sortedSortiment = new List<string>();
                    foreach (Bottle bottle in sortiment)
                    {
                        if (bottle.GetSodaType() == "Beer")
                        {
                            sortedSortiment.Add(bottle.GetSodaName());
                        }
                    }
                    sortedSortiment.Add("Return to main menu");
                    AddSoda(sortedSortiment);
                    Console.Clear();
                }

                else if (selectedSort == "Return to main menu")
                {
                    Console.Clear();
                    Index = 0;
                    MainMenu();
                }
            }
        }

        //The method to show the status of the soda crate.
        public static void StatusOfTheSodaCrate()
        {
            foreach (var bottle in bottles)
            {
                if (bottle != null)
                {
                    Console.WriteLine(bottle.GetSodaName());
                }
                else
                    Console.WriteLine("Empty");
            }
            List<string> statusMenu = new List<string>()
            {
                "Calculate the total cost",
                "Return to main menu"
            };

            Console.CursorVisible = false;
            while (true)
            {
                Console.WriteLine();
                string userSelection = Menu(statusMenu);
                switch (userSelection)
                {
                    case "Calculate the total cost":
                        Console.Clear();
                        CalculateCost();
                        break;

                    case "Return to main menu":
                        Console.Clear();
                        MainMenu();
                        break;

                    default:
                        break;
                }
            }
        }

        //The method to calculate the total cost of the soda crate.
        public static void CalculateCost()
        {
            if (bottles != null)
            {
                Console.Clear();
                int count = 0;
                decimal cost = 0;
                foreach (Bottle bottle in bottles)
                {
                    if (bottle != null)
                    {
                        cost += bottle.GetSodaPrice();
                        count++;
                    }
                }
                Console.WriteLine($"number of bottle in crate: {count}");
                Console.WriteLine($"Bottles Total cost {cost}kr\n");
            }
        }

        //This method generates the list of the different sodas.
        public static List<Bottle> GetBottleSortiment()
        {
            return new List<Bottle>
            {
                new Loka(),
                new Ramlösa(),
                new Bonaqua(),
                new CocaCola(),
                new CocaColaZero(),
                new CocaColaLight(),
                new Fanta(),
                new FantaExotic(),
                new Sprite(),
                new Heineken(),
                new Tuborg(),
                new Falcon(),
                new NorrlandsGuld(),
                new Tuborg()
            };
        }

        //This method generate display the list of different sodas to the menu.
        public static List<string> GetBottleSortimentSodaNames()
        {
            List<string> listSodaNames = new List<string>();

            foreach (var item in GetBottleSortiment())
            {
                listSodaNames.Add(item.GetSodaName());
            }
            listSodaNames.Add("Check status of your soda crate");
            listSodaNames.Add("Return to main menu");
            return listSodaNames;
        }
    }
}
