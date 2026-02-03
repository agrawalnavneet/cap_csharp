using System;
using System.Text;

class Flip
{
    public static string CleanseAndInvert(string input)
    {
        // Rule 1: null or length < 6
        if (string.IsNullOrEmpty(input) || input.Length < 6)
            return "";

        // Rule 2: only alphabets allowed
        foreach (char ch in input)
        {
            if (!char.IsLetter(ch))
                return "";
        }

        // Convert to lowercase
        input = input.ToLower();

        // Remove characters with even ASCII values
        StringBuilder filtered = new StringBuilder();
        foreach (char ch in input)
        {
            if ((int)ch % 2 != 0) // odd ASCII
                filtered.Append(ch);
        }

        // Reverse the string
        char[] arr = filtered.ToString().ToCharArray();
        Array.Reverse(arr);

        // Convert even index characters to uppercase
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
                arr[i] = char.ToUpper(arr[i]);
        }

        return new string(arr);
    }

    public static void flip()
    {
        Console.WriteLine("Enter the word");
        string input = Console.ReadLine();

        string result = CleanseAndInvert(input);

        if (result == "")
            Console.WriteLine("Invalid Input");
        else
            Console.WriteLine("The generated key is - " + result);
    }
}
