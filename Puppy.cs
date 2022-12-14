using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Joppes_Djurfamilj_UI_Forms
{
    public class Puppy:Dog
    {
        int months;
        string type = "Puppy";
        public Puppy(string name, int age, int months, string breed) : base(name, age, breed)
        {
            this.months = months;   
        }
        public override string ToString()
        {
            return "The " + type + " is called: " + base.name + ", The " + type + " is " + months + " months old and is a " + Breed;
        }
    }
}
