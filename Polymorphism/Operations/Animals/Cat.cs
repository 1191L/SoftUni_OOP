using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat:Animal
    {
        public Cat(string name, string favFood) : base(name, favFood)
        {
            
        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "\nMEEOW"; 
        }

    }
}
