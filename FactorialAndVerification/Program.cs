using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialAndVerification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int fact = 1;
            //Factorial(n, fact);

            //Console.WriteLine("Enter mail address : ");
            //string mail = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("Enter password: ");
            //int passWord = Convert.ToInt32(Console.ReadLine());
            //Verification(mail, passWord);
        }

        static void Factorial(int n , int fact)
        {
            for (int i = 1; i <= n; i++)
            {  
                fact = fact * i;
            }
            Console.WriteLine("Factorial:" + fact);
        }

        static void Verification(string mail, int passWord)
        {


            if (mail == "cavid@code.edu.az" && passWord == 12345)
            {
                Console.WriteLine("Wellcome");
            }
            else
            {
                Console.WriteLine("mail or password is uncorrect");
            }
                    


            
        }

        
    }

}
