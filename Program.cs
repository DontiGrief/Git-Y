namespace GitHHYlesanne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta mingi number");

            int msg = Int32.Parse(Console.ReadLine());
            if (msg == 0)
            {
                Console.WriteLine("E");
            } else { 
            for (int i = 0; i < msg; i++)
            {
                Console.WriteLine(msg);
            }
            }
        }
    }
}
