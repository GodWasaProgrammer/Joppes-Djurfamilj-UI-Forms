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
                MessageBox.Show($"The {type} plays with joppe");
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
                MessageBox.Show("Cat meows angrily while looking at you");
                MessageBox.Show("Your kitty goes chasing mice instead.");
                MessageBox.Show("Your Cat has a 50% chance of catching a mouse.");
                Random ProbabilityofcatchingaMouse = new Random();
                int probabibility;
                probabibility = ProbabilityofcatchingaMouse.Next(0, 100);
                MessageBox.Show(probabibility.ToString());
                if (probabibility > 50)
                {
                    MessageBox.Show("meow meow your cat catches a mouse");
                    MessageBox.Show("Your cat is fully fed");
                    hunger = false;
                }
                else if (probabibility < 50)
                {
                    MessageBox.Show("Your cat fails to catch anything");
                    MessageBox.Show("Therefor he is still hungry");
                }
            }
            
        }
    }
}
