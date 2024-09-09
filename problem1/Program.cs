using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a  first number: ");// prompts user to enter first number.
            int firstnumber = Convert.ToInt32(Console.ReadLine());// 
            Console.WriteLine("your first number is " + firstnumber);//prints out first number

            Console.WriteLine("enter second number: ");// prompts user to enter second number.
            int secondnumber = Convert.ToInt32(Console.ReadLine());//
            Console.WriteLine("your second number: " + secondnumber);// prints out second number

            Console.WriteLine("enter third number:");//prompts user to enter third number.
            int thirdnumber = Convert.ToInt32(Console.ReadLine());//
            Console.WriteLine("your third number: " + thirdnumber);//prints out third number

            if (firstnumber > secondnumber && firstnumber > thirdnumber)// if firstnumber is greater secondnumber and firstnumber is greater than thirdnumber 
            {
                Console.WriteLine("number 1 is largest number"); // if ture than print out number 1 is the largest number. 
            }
            if (secondnumber > firstnumber && secondnumber > thirdnumber)// if secondnumber is greater firstnumber and secondnumber is greater than thirdnumber.
            {
                Console.WriteLine("number 2 is largest number"); //if ture than print out number 2 is the largest number.
            }

            if (thirdnumber > firstnumber && thirdnumber > secondnumber)// if thirdnumber is greater firstnumber and thirdnumber is greater than secondnumber.
            {
                Console.WriteLine("number 3 is largest number");//if ture than print out number 3 is the largest number. 
            }


        }
    }
}
