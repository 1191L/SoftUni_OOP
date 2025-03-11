using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    class RandomList : List<string>
    {
        Random ra = new Random();
        public string RandomString()
        {
            
            int randomNum = ra.Next(0, this.Count());
            string returner = this.ElementAt(randomNum);
            this.RemoveAt(randomNum);
            return returner.ToString();
        }

    }
}
