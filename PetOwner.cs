namespace Joppes_Djurfamilj_UI_Forms
{
    public class PetOwner
    {
        int age;
        public List<Animal> pets = new List<Animal>(); // our list of animals
        public int Age { get { return age; } set { age = value; } } // property for age
        private string name;
        public string Name { get { return name; } set { name = value; } } // property for name
        public int Count { get { return pets.Count; } }
        int selector; // our index selection number
        public void List_Animals() // handles listing animaks
        {
            foreach (object animals in pets)
            {
                Console.WriteLine(animals);
                Console.WriteLine("-----------------------------------------------");
            }


        }

        public void Testing()
        {
            MessageBox.Show(Name);
        }
        public void PrintToFile()
        {
            // säger vart vi ska skriva
            string filePath = @"WriteFile.txt";
            // använder streamwriter kallad temp, ny streamwriter, path är filepath
            // för varje index str i pets 
            // skriv till fil.
            using (StreamWriter temp = new StreamWriter(filePath))
            {
                foreach (var str in pets)
                {
                    temp.WriteLine(str);
                }
            }
        }
        public void PetChoice()
        {
            Console.WriteLine("Pick the animal with which you wish to interact");
            Console.WriteLine("-------------------------------------------------");
            string petchoice;
            petchoice = Console.ReadLine();
            while (petchoice != "0" && petchoice != "1" && petchoice != "2") // input verification logic
            {
                Console.WriteLine("your input has to be a number, 0, or 1,or 2!");
                petchoice = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------");
            }
            selector = Int32.Parse(petchoice);
            // selector is index 
        }
        public void Play()
        {
            Console.WriteLine("Play method");
            Console.WriteLine("-----------------------------------------");
            List_Animals();
            PetChoice();
            // selector acts as index for petlist.
            pets[selector].Interact();
        }
        public void Feed()
        {
            string FoodIN;
            int Foodchoice;
            Console.WriteLine("Pick the food you wish to feed the animal with,input correlating number");
            Console.WriteLine("1. steak");
            Console.WriteLine("2. Catnip");
             FoodIN = Console.ReadLine();
            while (!int.TryParse(FoodIN, out Foodchoice))
            {
                Console.WriteLine("This is not a number!");
                Console.WriteLine("Input 1 or 2");
                FoodIN = Console.ReadLine();
            }
            Console.WriteLine($"Your choice is: {Foodchoice}");
            if (Foodchoice == 1)
            {
                FoodIN = "Steak";
                PetChoice();
                pets[selector].Eat(FoodIN);
            }
            if (Foodchoice == 2)
            {
                FoodIN = "Catnip";
                PetChoice();
                pets[selector].Eat(FoodIN);
            }
            if (Foodchoice != 1 && Foodchoice != 2)
            {
                Console.WriteLine("There is no food correlating to that number. Choose again.");
                Feed();
            }
        }
        public void Menu()
        {
            int menu;
            int loop;
            do
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("Menuchoice:");
                Console.WriteLine("1. Play Fetch");
                Console.WriteLine("2. Feed Animal");
                Console.WriteLine("3. List Joppes Animals");
                Console.WriteLine("4. Print your list to a file");
                Console.WriteLine("Enter the appropriate number for your choice!");
                // menu = Int32.Parse(Console.ReadLine());
                var input = Console.ReadLine();
                while (!int.TryParse(input, out menu))
                {
                    input = Console.ReadLine();
                }
                if (menu != 1 && menu != 2 && menu != 3 && menu != 3 && menu != 4)
                {
                    Console.WriteLine("This is not an acceptable choice!");
                    Console.WriteLine("Acceptable choices are 1,2,3,4(exit)");
                }
                Console.WriteLine($"Your choice is: {menu}");
                loop = menu;
                switch (menu)
                {
                    case 1:
                        Play();
                        break;
                    case 2:
                        Feed();
                        break;
                    case 3:
                        List_Animals();
                        break;
                    case 4:
                        PrintToFile();
                        break;
                }
            } while (loop != 4);
        }
        public override string ToString()
        {
            return "Petowner is Called:" + name + " and his age is:" + age;
        }
    }
}
