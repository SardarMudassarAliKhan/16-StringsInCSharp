Here are some examples of using strings in C#:

1. **Creating a String:**
   ```csharp
   string greeting = "Hello, World!";
   ```

2. **String Concatenation:**
   ```csharp
   string firstName = "John";
   string lastName = "Doe";
   string fullName = firstName + " " + lastName; // fullName will be "John Doe"
   ```

3. **String Interpolation:**
   ```csharp
   string name = "Alice";
   int age = 30;
   string message = $"My name is {name} and I am {age} years old."; // message will be "My name is Alice and I am 30 years old."
   ```

4. **String Length:**
   ```csharp
   string text = "C# Programming";
   int length = text.Length; // length will be 14
   ```

5. **Accessing Characters:**
   ```csharp
   string word = "example";
   char firstChar = word[0]; // firstChar will be 'e'
   char lastChar = word[word.Length - 1]; // lastChar will be 'e'
   ```

6. **Substring:**
   ```csharp
   string phrase = "The quick brown fox";
   string sub = phrase.Substring(4, 5); // sub will be "quick"
   ```

7. **String Comparison:**
   ```csharp
   string str1 = "hello";
   string str2 = "HELLO";
   bool isEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase); // isEqual will be true
   ```

8. **String Splitting:**
   ```csharp
   string sentence = "C# is a powerful programming language";
   string[] words = sentence.Split(' '); // words will be {"C#", "is", "a", "powerful", "programming", "language"}
   ```

9. **String Joining:**
   ```csharp
   string[] fruits = { "apple", "banana", "orange" };
   string joined = string.Join(", ", fruits); // joined will be "apple, banana, orange"
   ```

10. **String Formatting:**
    ```csharp
    string formatted = string.Format("Name: {0}, Age: {1}", "John", 30); // formatted will be "Name: John, Age: 30"
    ```

These examples cover basic string operations commonly used in C#.
