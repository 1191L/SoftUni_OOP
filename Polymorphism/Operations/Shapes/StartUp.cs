using System.Net.Http.Headers;

namespace Shapes
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                Rectangle rec = new Rectangle(2, 3);
                Circle cir = new Circle(5);
                Console.WriteLine($"{rec.Draw()}\n{cir.Draw()}");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}