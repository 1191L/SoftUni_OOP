using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        string name { get; }
        string favFood { get; }
        public Animal(string name, string favFood)
        {
            this.name = name;
            this.favFood = favFood;
        }
        public virtual string ExplainSelf()
        {
            return $"I am {name} and my fovourite food is {favFood}";
        }
    }
}
