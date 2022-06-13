using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba7
{
    static class test
    {
        static void Main()
        {
            string StringGenerator()
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
                var random = new Random();
                var stringChars = new char[random.Next(1, 26)];

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                return finalString;
            }

            const int value = 5;
            List<string> list1 = new List<string>(value);
            for (int i = 0; i < value; i++)
            {
                string random_string = StringGenerator();
                list1.Add(random_string);
                Console.WriteLine(random_string);
                Console.WriteLine();
            }
            var count = 0;
            var latin_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < list1.Count; i++)
            {
                string check = list1[i];
                count += check.Count(latin_chars.Contains);
            }

            Console.WriteLine($"Количество латинских символов: {count}");
        }
    }
}
