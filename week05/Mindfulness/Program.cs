class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                new BreathingActivity().Run();
            else if (choice == 2)
                new ReflectionActivity().Run();
            else if (choice == 3)
                new ListingActivity().Run();
        }
    }
}