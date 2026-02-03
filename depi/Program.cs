namespace depi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape[] arr = {
            new rectangle(4,5), new rectangle(4,5),
            new Square(4), new Square(5),   
            new circle(2), new circle(3),
            };
            picture pc = new picture();
            Console.WriteLine("Total Area for all shapes = "+pc.calcArea(arr));
        }
    }
}
