namespace Week2challengeLabs4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a width number: ");
            int width = Convert.ToInt32(Console.ReadLine());

            for (int i = width; i >= 1; i--) 
            {
                for (int j = 1; j<= i; j++) 
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
    //} // Outer loop
    //for (int i = 1; i <= 2; ++i)
    //{
    //    Console.WriteLine("Outer: " + i);  // Executes 2 times

    //    // Inner loop
    //    for (int j = 1; j <= 3; j++)
    //    {
    //        Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
}

