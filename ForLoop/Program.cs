namespace GitHHYlesanne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta mingi number");
            int msg = Int32.Parse(Console.ReadLine());
            Console.WriteLine("*******");

            for (int i = 0; i < msg; i++)
                {
                    Console.WriteLine(i + 1);
                if (msg == i + 1)
                {
                    Console.WriteLine("--");
                    Console.WriteLine("Tehtud!");
                }
                else
                {
                    Console.WriteLine("--");
                }
            }
        }
    }
}
