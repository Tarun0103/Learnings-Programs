using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Programs.Basic_Programs
{
    public class BasicPrograms
    {
        //Given Number Even or odd
        public void EvenOrOdd()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
        //Generates Odd Numbers within a Range
        public void OddNumbersInRange()
        {
            Console.WriteLine("Enter the range (two numbers) :");
            int i,j;
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            IEnumerable<int> numbers = Enumerable.Range(i, j).Where(x => x % 2 != 0);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        //Check whether number is positive or negative 
        public void PositivOrNegative()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (number == 0)
            {
                Console.WriteLine("Number is 0");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
            Console.ReadLine();
        }
        //Swapping of two numbers
        public void SwapNumbers()
        {
            int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
        // Multiple of 3 and 5 less than 100
        public void multipleOf3and5()
        {
            int i,a,b;
            for(i = 0; i<100; i++)
            {
                a = i % 3; b = i % 5;
                if(a == 0 && b == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        //Sum of digits in a number
        public void SumOfDigits()
        {
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem, sum = 0;
            while (num > 0) {
                rem = num % 10;
                sum += rem;
                num = num/10;
            }
            Console.WriteLine("Sum of Digits : " + sum);

        }

        //Reverse a number
        public void ReverseNumber()
        {
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            int temp = num;
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            //Console.ReadLine();
            if(reverse == temp)
            {
                Console.WriteLine(temp + " is palindrome");
            }
            else
            {
                Console.WriteLine("Please enter palindrome number");
            }
        }
    }
}
