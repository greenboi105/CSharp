using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Student class
            Student student = new Student("John", "Doe", 25, "12345");

            // Call the PrintDetails method to print the student's details
            student.PrintDetails();
            student.PrintStudentDetails();

            // Declare an integer array of size 5
            int[] numbers = new int[5];

            // Initialize the array
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Access elements using an index
            Console.WriteLine(numbers[2]); // Output: 30

            // Iterate over the array using a loop
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Declare a list of strings
            List<string> names = new List<string>();

            // Add elements to the list
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");

            // Access elements using an index
            Console.WriteLine(names[1]); // Output: Bob

            // Iterate over the list using a loop
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Declare a dictionary of strings and integers
            Dictionary<string, int> scores = new Dictionary<string, int>();

            // Add key-value pairs to the dictionary
            scores.Add("Alice", 90);
            scores.Add("Bob", 80);
            scores.Add("Charlie", 70);

            // Access values using a key
            Console.WriteLine(scores["Bob"]); // Output: 80

            // Iterate over the dictionary using a loop
            foreach (KeyValuePair<string, int> pair in scores)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            // Declare a queue of integers
            Queue<int> new_numbers = new Queue<int>();

            // Enqueue elements into the queue
            new_numbers.Enqueue(10);
            new_numbers.Enqueue(20);
            new_numbers.Enqueue(30);

            // Peek at the next element in the queue
            int next = new_numbers.Peek();

            // Iterate over the queue using a loop
            foreach (int number in new_numbers)
            {
                Console.WriteLine(number);
            }

            // Declare a stack of integers
            Stack<int> more_numbers = new Stack<int>();

            // Push elements onto the stack
            more_numbers.Push(10);
            more_numbers.Push(20);
            more_numbers.Push(30);

            // Peek at the top element in the stack
            int top = more_numbers.Peek();

            // Iterate over the stack using a loop
            foreach (int number in more_numbers)
            {
                Console.WriteLine(number);
            }

            // Declare a set of integers
            HashSet<int> some_numbers = new HashSet<int>();

            // Add elements to the set
            some_numbers.Add(100);
            some_numbers.Add(90);
            some_numbers.Add(80);

            // Remove an element from the set
            some_numbers.Remove(20);

            // Check if an element is in the set
            bool contains = some_numbers.Contains(30);

            // Iterate over the set using a loop
            foreach (int number in some_numbers)
            {
                Console.WriteLine(number);
            }
        }
    }

    // Define a Person class with a name and age
    class Person
    {
        // Fields
        private string firstName;
        private string lastName;
        private int age;

        // Constructor
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        // Method to print the person's details
        public void PrintDetails()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Age: {0}", age);
        }
    }

    // Define a Student class that inherits from Person and adds a student ID
    class Student : Person
    {
        // Field
        private string studentId;

        // Constructor
        public Student(string firstName, string lastName, int age, string studentId)
            : base(firstName, lastName, age)
        {
            this.studentId = studentId;
        }

        // Method to print the student's details
        public void PrintStudentDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Student ID: {0}", studentId);
        }
    }
}

