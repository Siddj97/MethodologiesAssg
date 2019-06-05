using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] arg)
        {
           // TriangleSolver.Analyze(3,3,3);
            bool choose = false;
            string selection;
           
                while(choose ==false)
                {
                Console.WriteLine("Press 1  to Enter Dimentions of triangle");
                Console.WriteLine("Press 2  to Exit");
                selection = Console.ReadLine();
                if(selection != "1"  && selection != "2")
                {
                    Console.WriteLine("Kindly Press 1 or 2  givn input is not valid  ");
                }
                else if (int.Parse(selection) == 1)
                {
                    
                    int s1, s2, s3;

                    s1 =  My_Function("s1");
                    s2 =  My_Function("s2");
                    s3 =  My_Function("s3");

                    Console.WriteLine($"Your Entered Values are first {s1} , second {s2} , third{s3}  and makes ");
                    TriangleSolver.Analyze(s1,s2,s3);  
                   
                }

                else if (int.Parse(selection) == 2)
                {
                    System.Environment.Exit(0);
                }
            }
         }
        public static int My_Function(string side)
        {


            int num = 1;
            bool vaild = false;
            while (vaild == false)
            {
                Console.Write($"Enter the sides of Triangle {side}= ");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                bool outcome = int.TryParse(userInput, out num);

                if (outcome == false)
                 {
                    Console.WriteLine("Kindly Enter valid input");
                }
                else if (num <= 0)
                {
                    Console.WriteLine("Kindly Put values in possitive integer and not zero");
                }
                else 
                {
                    vaild = true;
                    Console.WriteLine($"Enterd value");
                }


            }
            return num;
        }
    }
}
     