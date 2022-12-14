namespace Joppes_Djurfamilj_UI_Forms
{
    public class Cat : Animal
    {
        string type = "Cat";
        new string fav_food = "Catnip";
        public Cat(string name, int age, string breed)
            : base(name, age, breed)
        {
            cat();
        }
        public void cat()
        {
            base.fav_food = fav_food;
        }
        public override void Interact()
        {
            if (hunger == true)
            {
                Hungry_Animal();
            }
            else if (hunger == false)
            {
                Console.WriteLine($"The {type} plays with joppe");
                this.hunger = true;
            }
        }
        public override string ToString()
        {
            return "The " + type + " is called: " + base.name + ", and its " + base.age + " years old, and is a " + Breed;
        }
        public override void Hungry_Animal()
        {
            if (hunger == true)
            {
                Console.WriteLine("Cat meows angrily while looking at you");
                Console.WriteLine("Your kitty goes chasing mice instead.");
                Console.WriteLine("Your Cat has a 50% chance of catching a mouse.");
                Random ProbabilityofcatchingaMouse = new Random();
                int probabibility;
                probabibility = ProbabilityofcatchingaMouse.Next(0, 100);
                Console.WriteLine(probabibility);
                if (probabibility > 50)
                {
                    Console.WriteLine("meow meow your cat catches a mouse");
                    Console.WriteLine("Your cat is fully fed");
                    hunger = false;
                }
                else if (probabibility < 50)
                {
                    Console.WriteLine("Your cat fails to catch anything");
                    Console.WriteLine("Therefor he is still hungry");
                }
            }
            else if (hunger == false)
            {
                Console.WriteLine("Your cat isnt hungry and refuses to eat.");
            }
        }
    }
}
