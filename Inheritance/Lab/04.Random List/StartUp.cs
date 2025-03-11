namespace CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
            RandomList randomList = new RandomList();
            randomList.Add("Test");
            randomList.Add("Test2");
            randomList.Add("Test3");
            randomList.Add("Test4");
            randomList.Add("Test5");
            Console.WriteLine(randomList.RandomString());
        }
    }
}