using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class fizzBuzz
    {
        public string TextReturn(int integer)
        {
            double isFiz = integer % 3;
            double isBuz = integer % 5;
            if (isFiz == 0 && isBuz == 0 && integer !=0)
            {
                //Console.WriteLine("Value of i: {0} FizzBuzz", integer);
                return "fizzBuzz";
            }
            if (isFiz == 0 && isBuz != 0)
            {
                //Console.WriteLine("Value of i: {0} Fizz", integer);
                return "Fizz";
             
            }
            if (isBuz == 0 && isFiz != 0)
            {
                //Console.WriteLine("Value of i: {0} Buzz",integer);
                return "Buzz";
            }
            if (integer == 0 || isBuz != 0 && isFiz != 0)
            {

                //Console.WriteLine("Value of i: {0} ", integer);
                return "";
            }
            else return "";
        }
        static void Main(string[] args)
        {
            fizzBuzz fb = new fizzBuzz();
            for (int i = 0; i < 101; i++)
            {
                string text = fb.TextReturn(i);
                Console.WriteLine("{0} {1}", i, text);
            }
            Console.ReadLine();

            
        }
    }
}
