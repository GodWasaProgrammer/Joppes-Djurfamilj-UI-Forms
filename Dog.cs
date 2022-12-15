namespace Joppes_Djurfamilj_UI_Forms
{
    public class Dog : Animal
    {
        string type = "Dog";
        new string fav_food = "Steak";
        public void dog()
        {
            base.fav_food = fav_food;
        }
        public Dog(string name, int age, string breed)
            : base(name, age, breed)
        {
            dog();
        }
        public override void Interact()
        {
            if (hunger == true)
            {
                MessageBox.Show($"The {type} is hungry and wont play.");
                MessageBox.Show($"The {type} Growls hungrily");
                Hungry_Animal();
            }
            else if (hunger == false)
            {
                MessageBox.Show($"The {type} plays with joppe");
                hunger = true;
            }
        }
        public override string ToString()
        {
            return "The " + type + " is called: " + base.name + " The " + type + " is " + base.age + " years old and is a "+ Breed;
        }
    }
}
