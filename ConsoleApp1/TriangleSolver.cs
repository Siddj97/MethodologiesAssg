using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class TriangleSolver
    {
       public static int s1;
       public static int s2;
       public static int s3;

        
       
        public static string Analyze(int s1, int s2 , int s3) {
            string  gogo = "";

            if ((s1 + s2 > s3) && (s2 + s3 > s1) && (s3 + s1 > s2))
            {
                Console.WriteLine("Forms a Triangle we can procede further");


                if (s1 == s2 && s2 == s3 && s3 == s1)
                {
                    Console.WriteLine("For the given userInput Equilateral Triangle");
                }
                else if (s1 == s2 || s2 == s3 || s3 == s1)
                {
                    Console.WriteLine("For the given userInput Isosceles Triangle");

                }
                else if (s1 != s2 && s2 != s3 && s3 != s1)
                {
                    Console.WriteLine("For the given userInput  Scalene Triangle");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Doesnot Form Triangle ");
            }

            return gogo;
        }
    }

}
     

