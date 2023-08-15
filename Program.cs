using System;
using System.Threading.Tasks;

namespace TypingEffectExample
{
    class Program
    {
        public static async Task WriteSlowly(string word, TimeSpan delayBetweenLetters = default)
        {
            if (delayBetweenLetters == default) delayBetweenLetters = TimeSpan.FromMilliseconds(100);
            
            foreach (char letter in word)
            {
                Console.Write(letter);
                await Task.Delay(delayBetweenLetters);
            }
        }

        static async Task Main(string[] args)
        {
            string[] lines = {
                "Dear Friend,",
                "I hope this letter finds you well.",
                "",
                "By the way,",
                "do you know why C# programmers always wear glasses?",
                "Because they can't C#!"
            };

            foreach (string line in lines)
            {
                await WriteSlowly(line);
                Console.WriteLine();
            }
        }
    }
}
