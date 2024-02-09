using System;

namespace List4
{
    class Program
    {
        static bool FinnsTecknetIAllaSträngar(string[] words, char letter)
        {
            int inehåller = 0;
            bool svar = false;
            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letter){
                        inehåller ++;
                    }
                }
            }
            if (inehåller == 3)
            {
                svar = true;
            }
            return svar;
        }
        static void Main(string[] args)
        {
            string[] input = { "hej", "nej", "ja" };
            Console.WriteLine(FinnsTecknetIAllaSträngar (input, 'j'));
            Console.WriteLine(FinnsTecknetIAllaSträngar(input, 'e'));
        }
    }
}