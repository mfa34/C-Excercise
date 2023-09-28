using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
            Console.WriteLine("Lütfen mesajınızı yazınız...");
            string input = Console.ReadLine();
            string inputLower = input.ToLower();
      
            char[] secretMessage = inputLower.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                if (char.IsLetter(letter)) // Check if the character is a letter
                {
                    int letterPosition = Array.IndexOf(alphabet, letter);
                    // Using modulo operator for looping alphabet
                    int newLetterPosition = (letterPosition + 3) % 26;
                    char letterEncoded = alphabet[newLetterPosition];
                    encryptedMessage[i] = letterEncoded;
                }
                else
                {
                    encryptedMessage[i] = letter; // If it's not a letter, keep it as is
                }
            }
            string encodedString = new string(encryptedMessage);
            Console.WriteLine($"Your encoded message is: {encodedString}");
        }
    }
}
