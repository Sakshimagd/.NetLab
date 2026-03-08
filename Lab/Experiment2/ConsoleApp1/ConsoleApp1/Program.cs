namespace ConsoleAppExample
{
    // Step 1: Define a class
    class Student
    {
        // Data members
        public string name;
        public int age;

        // Method to get student details
        public void GetDetails()
        {
            Console.Write("Enter Student Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        // Method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    // Main class
    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Create object of class
            Student s1 = new Student();

            // Step 3: Access class methods
            s1.GetDetails();
            s1.DisplayDetails();

            Console.ReadLine();
        }
    }
}