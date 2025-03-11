namespace CustomStack
{
    public class StartUp
    {
        static void Main()
        {
            StackOfStrings a = new StackOfStrings();


            Stack<string> b = new Stack<string>();
            b.Push("test");
            b.Push("test2");
            b.Push("test3");
            b.Push("test4");
            Console.WriteLine(a.IsEmpty());
            a.AddRange(b);
            Console.WriteLine(a.IsEmpty());
        }
    }
}