using System;

class Program
{
    static void Main()
    {
        // Creating a string
        string greeting = "Hello, World!";
        Console.WriteLine("1. Greeting: " + greeting);

        // String concatenation
        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;
        Console.WriteLine("2. Full Name: " + fullName);

        // String interpolation
        string name = "Alice";
        int age = 30;
        string message = $"My name is {name} and I am {age} years old.";
        Console.WriteLine("3. Message: " + message);

        // String length
        string text = "C# Programming";
        int length = text.Length;
        Console.WriteLine("4. Text Length: " + length);

        // Accessing characters
        string word = "example";
        char firstChar = word[0];
        char lastChar = word[word.Length - 1];
        Console.WriteLine("5. First Character: " + firstChar);
        Console.WriteLine("   Last Character: " + lastChar);

        // Substring
        string phrase = "The quick brown fox";
        string sub = phrase.Substring(4, 5);
        Console.WriteLine("6. Substring: " + sub);

        // String comparison
        string str1 = "hello";
        string str2 = "HELLO";
        bool isEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine("7. Are strings equal (case-insensitive)? " + isEqual);

        // String splitting
        string sentence = "C# is a powerful programming language";
        string[] words = sentence.Split(' ');
        Console.WriteLine("8. Words in the sentence:");
        foreach(string wordInSentence in words)
        {
            Console.WriteLine("   " + wordInSentence);
        }

        // String joining
        string[] fruits = { "apple", "banana", "orange" };
        string joined = string.Join(", ", fruits);
        Console.WriteLine("9. Joined Fruits: " + joined);

        // String formatting
        string formatted = string.Format("Name: {0}, Age: {1}", "John", 30);
        Console.WriteLine("10. Formatted: " + formatted);
    }
}
