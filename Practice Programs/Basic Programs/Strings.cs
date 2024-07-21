using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Programs.Basic_Programs
{
    public class StringsPrograms
    {
        public void ReverseStringUsingArray()
        {
            String InputStr = Console.ReadLine();
            Char[] chInput = InputStr.ToCharArray();
            Array.Reverse(chInput);
            string revString = new string(chInput);
            Console.WriteLine($"Reverse string is : {revString}");

        }
        public void ReverseString()
        {
            string str = "", RevString = "";
            str = Convert.ToString(Console.ReadLine());
            for (int i = str.Length - 1; i >= 0; i--)
            {
                RevString += str[i];
            }
            Console.WriteLine($"Revse is {RevString}");
        }
        public void CountWordsInString()
        {
            string strInput; int count = 1, len = 0;
            strInput = Console.ReadLine();
            while (len < strInput.Length - 1)
            {
                if (strInput[len] == ' ' || strInput[len] == '\n' || strInput[len] == '\t')
                {
                    count++;
                }
                len++;
            }
            Console.WriteLine($"Count is {count}");
        }

        public void CountOfCharacters()
        {
            Console.WriteLine("Enter String :");
            String strInput = Convert.ToString(Console.ReadLine());
            strInput.ToLower();
            Dictionary<char, int> dict = new Dictionary<char, int>();       
            foreach(char c in strInput)
            {
                dict.TryGetValue(c, out int count);
                dict[c] = count+1;
            }
            foreach(var items in dict)
            {
                if((items.Key) == 'i')
                {
                    Console.WriteLine("Occurance of character " + items.Key + " is " + items.Value);
                }
                
            }
        }
    }
}
