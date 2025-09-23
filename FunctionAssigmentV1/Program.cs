namespace FunctionAssigmentV1
{
    internal class Program
    {
        /// <summary>
        /// This funktion asks the user their name and checks validity
        /// </summary>
        /// <returns> Returns valid input</returns>

        static string KysyNimi()

        {
            // Ask for name and ensure it is not empty
            while (true)
            {
                Console.Write("Enter your name: ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Name cannot be empty.");
            }
        }
        /// <summary>
        /// Asks the user for their age and makes sure its valid
        /// </summary>
        /// <returns>Returns valid age</returns>
        static int KysyIkä()
        {
            // Ask for age and ensure it is a positive integer
            while (true)
            {
                Console.Write("Enter your age: ");
                string? input = Console.ReadLine();


                if (int.TryParse(input, out int age) && age > 0)
                    return age;

                Console.WriteLine("Please enter a positive integer.");
            }
        }
        /// <summary>
        /// Prints the input name and age
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void TulostaNimijaIkä(string name, int age)
        {
            // Print name and age
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
        /// <summary>
        /// Checks to see if the input age is over 18
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        static bool TarkistaTäysIkäinen(int age)
        {
            // Check if the user is an adult
            return age >= 18;

        }
        /// <summary>
        /// Compares if the input name is the same as Matti, both upper- and lowercase
        /// </summary>
        /// <param name="name"></param>
        /// <param name="compareTo"></param>
        static void VertaaNimeä(string name, string compareTo)
        {
            //Case-insensetive check
            if (name.Equals(compareTo, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Your name matches '{compareTo}' (case-insensetive)");
            }

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareTo))
            {
            Console.WriteLine($"Your name is exactly '{compareTo}' (case-sensitive).");
            }
        }
        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this
            string name = KysyNimi();
            int age = KysyIkä();

            TulostaNimijaIkä(name, age);
            bool isFullAge = TarkistaTäysIkäinen(age);

            if (isFullAge)
            {
                Console.WriteLine("You are an adult!");
            }
            else
            {
                Console.WriteLine("You are not an adult");
            }
            // Compare the name to another string (e.g., "Matti")
            VertaaNimeä(name, "Matti");
        }
    }
}

