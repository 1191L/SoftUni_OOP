﻿namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            Animal cat = new Cat("Peter", "Whiskas");
            Animal dog = new Dog("George", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}