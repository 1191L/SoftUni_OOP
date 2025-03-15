﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog:Animal
    {
        public Dog(string name, string favFood):base(name,favFood)
        {
            
        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "\nDJAAF";
        }
    }
}
