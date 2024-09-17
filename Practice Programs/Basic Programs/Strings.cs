using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Programs.Basic_Programs
{
    public class StringsPrograms
    {
        public StringsPrograms()
        {
            Console.WriteLine("Enter String : ");

        }
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

            Console.Write("Enter the string : ");

            string inputString = Console.ReadLine();

            int result = 0;
            //Trim whitespace from beginning and end of string

            inputString = inputString.Trim();
            //Necessary because foreach will execute once with empty string returning 1

            if (inputString == "")

                Console.WriteLine(0);
            //Ensure there is only one space between each word in the passed string

            while (inputString.Contains("  "))

                inputString = inputString.Replace("  ", " ");

            //Count the words

            foreach (string y in inputString.Split(' '))
            result++;
            Console.WriteLine("Number of words is : " + result);

            Console.ReadLine();
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

            //Console.Write("Enter the string : ");

            //string inputString = Console.ReadLine();

            //inputString = inputString.Replace(" ", string.Empty);



            //while (inputString.Length > 0)
            //{

            //    Console.Write(inputString[0] + " : ");

            //    int count = 0;

            //    for (int j = 0; j < inputString.Length; j++)

            //    {

            //        if (inputString[0] == inputString[j])
            //        {

            //            count++;

            //        }

            //    }

            //    Console.WriteLine(count);

            //    inputString = inputString.Replace(inputString[0].ToString(), string.Empty);

            //}

        }

        public void RemoveDuplicatesInString()
        {
            Console.WriteLine("Enter String : ");
            String StrInput = Convert.ToString(Console.ReadLine());
            for(int i = 0; i < StrInput.Length; i++)
            {
                
            }
        }
        public void FindAllSubString()
        {
            String inputStr = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Substrings are : ");
            for (int i = 0; i < inputStr.Length; i++)
            {
                Dictionary<int, string> dictCompare = new Dictionary<int, string>();
                int k = 0;
                for (int j = 0; j < inputStr.Length - i; j++)
                {
                    string substring = inputStr.Substring(j, i);
                    if (!dictCompare.ContainsValue(substring))
                    {
                        dictCompare.Add(k, substring);
                        k++;
                        Console.WriteLine(substring);
                    }
                }
            }
        }
    }
}
