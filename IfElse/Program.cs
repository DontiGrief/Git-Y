namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta mingi number");
            int num = int.Parse(Console.ReadLine());
            if (num >= 40)
            {
                Console.WriteLine("Number on rohkem kui 40");
                Console.WriteLine("----------------------");
                if (num >= 70)
                {
                    Console.WriteLine("Number on rohkem kui 70");

                }
                else
                {
                    Console.WriteLine("Number on vähem kui 70 ja rohkem kui 40");
                }
            } else
            {

                Console.WriteLine("Number on vähem kui 40");
                Console.WriteLine("----------------------");
                if (num >= 10)
                {
                    Console.WriteLine("Number on rohkem kui 10 ja vähem kui 40");

                } else
                {
                    Console.WriteLine("Number on vähem kui 10");
                }
            }

        }
    }
}
