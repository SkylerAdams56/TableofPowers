namespace Table_of_Powers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes table");
            Console.WriteLine();
            string choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter an integer: ");
                int integer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t=======\t=====");
                for (int i = 1; i <= integer; i++)
                {
                    Console.WriteLine(i + "\t" + i * i + "\t" + i * i * i);
                }
                Console.WriteLine();
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}