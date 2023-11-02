namespace Szyfr_cezara
{
    using System;

    class CaesarCipher
    {
        // Metoda do szyfrowania tekstu
        static string Encrypt(string text, int shift)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];

                if (char.IsLetter(character))
                {
                    char baseChar = char.IsUpper(character) ? 'A' : 'a';
                    result[i] = (char)(((character + shift - baseChar) % 26) + baseChar);
                }
                else
                {
                    result[i] = character;
                }
            }

            return new string(result);
        }

        // Metoda do deszyfrowania tekstu
        static string Decrypt(string text, int shift)
        {
            return Encrypt(text, 26 - shift); // Odszyfrowanie to szyfrowanie z przeciwnym przesunięciem
        }

        static void Main()
        {
            Console.WriteLine("Podaj tekst do zaszyfrowania: ");
            string textToEncrypt = Console.ReadLine();

            Console.WriteLine("Podaj przesunięcie (liczbę całkowitą): ");
            int shift = int.Parse(Console.ReadLine());

            string encryptedText = Encrypt(textToEncrypt, shift);
            Console.WriteLine("Zaszyfrowany tekst: " + encryptedText);

            string decryptedText = Decrypt(encryptedText, shift);
            Console.WriteLine("Odszyfrowany tekst: " + decryptedText);
        }
    }

}