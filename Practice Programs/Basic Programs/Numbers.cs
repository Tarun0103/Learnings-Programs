using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Programs.Basic_Programs
{
    public class NumbersPrograms
    {
        public void ArmStrongNumber()
        {
            // 151 = (1*1*1) + (5*5*5) + (1*1*1)
            int num, sum = 0, rem, temp;
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("Arm");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public void PalindromeNumber() 
        {
            /*
             * 1234 - 4 is remainder
             * 123 divisor
             */
            //12321,121,32123,95159
            int num, sum, revNum = 0, rem;
            num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            while (num > 0)
            {
                rem = num % 10;
                revNum = revNum*10 + rem;
                num = num / 10;
            }
            if (revNum == temp)
            {
                Console.WriteLine("Palendrome");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public void Fibnacci()
        {
            int num1 = 0, num2 = 1, num3, range, len=0;
            range = Convert.ToInt32(Console.ReadLine());
            while (len < range)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3 + " ");
                num1 = num2;
                num2 = num3;
                len++;
            }
        }
        public void firstHundredNumbers()
        {
            Console.WriteLine("Enter range ");
            int range = Convert.ToInt32(Console.ReadLine()), num = 0;
            while(num <= range)
            {
                Console.WriteLine(num);
                num++;
            }
        }
        public void firstHundredNumbersinReverse()
        {
            Console.WriteLine("Enter range ");
            int range = Convert.ToInt32(Console.ReadLine()), num = range;
            while(num <= range && num > 0)
            {
                Console.WriteLine(num);
                num--;
            }
        }
        public void factorialOfNumber()
        {
            int num, fact = 1;
            Console.WriteLine("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"factorial of {num} is {fact}");
        }
        public void StrongNumber()
        {
            // 1! + 4! + 5! = 145
            int num, sum = 0, rem, temp;
            Console.WriteLine("Enter the number ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                int fact = 1;
                for (int i = 0; i <= rem; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Number is strong");
            }
            else
            {
                Console.WriteLine("Number is not Strong");
            }
        }
    }
}
