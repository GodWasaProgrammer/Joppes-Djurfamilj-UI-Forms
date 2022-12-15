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
        public int Selector { get { return selector; } set { selector = value; } }
        string FoodIN;
        public string FoodOUT { get { return FoodIN; } set { FoodIN = value; } }
        public void List_Animals() // handles listing animaks
        {
            foreach (object animals in pets)
            {
                Console.WriteLine(animals);
            }
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

            MessageBox.Show($"Your file has been written to:{filePath}");
        }
        
        public void Play()
        {
            pets[selector].Interact();
        }
        public void Feed()
        {
                pets[selector].Eat(FoodIN);
             
        }
        
        public override string ToString()
        {
            return "Petowner is Called:" + name + " and his age is:" + age;
        }
    }
}
