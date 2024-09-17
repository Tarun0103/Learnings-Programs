using Practice_Programs.Basic_Programs;
using System;
using The_Programs.Basic_Programs;

namespace MainSpace
{
    public class Main_Programs
    {
        static void Main(string[] args)
        {
            BasicPrograms obj = new BasicPrograms();

            /* --- Numbers ---
             
            obj.EvenOrOdd();
            obj.OddNumbersInRange();
            obj.PositivOrNegative();
            obj.SwapNumbers();
            obj.multipleOf3and5();
             obj.SumOfDigits();
            obj.ReverseNumber();
            */

            //Strings
            StringsPrograms sp = new StringsPrograms();
            //sp.ReverseString();
            //sp.ReverseStringUsingArray();
            //sp.CountWordsInString();
            //sp.CountOfCharacters();
            //sp.FindAllSubString();
            sp.CountCharInString();
            

            //Numbers
            NumbersPrograms np = new NumbersPrograms();
            //np.PalindromeNumber();
            //np.ArmStrongNumber();
            // np.firstHundredNumbers();
            // np.Fibnacci();
            np.factorialOfNumber();
            np.StrongNumber();
            np.firstHundredNumbersinReverse();

            //Arrays
            ArraysPrograms ap = new ArraysPrograms();
           // ap.MaxMinValueInArray();
          //  ap.SecondMaxInArray();
        }
    }
}