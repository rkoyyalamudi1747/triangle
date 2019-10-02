using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class Trianglesolver
    {
        private static int side1;
        private static int side2;
        private static int side3;

        public static string Analyze(int s1, int s2, int s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
            string r = string.Empty;

            if (((s1 + s2) >= s3) && ((s2 + s3) >= s1) && ((s1 + s3) >= s2))
            {

                {
                    r = "valid triangle";
                    Console.WriteLine(r);
                  
                }

                while ((s1 == s2) && (s2 == s3))
                {
                    r = "equilateral";
                    Console.WriteLine(r);
                    break;
                }
                while (((s1 == s2) && (s2!= s3) )|| ((s1 == s3) && (s1 != s2))|| ((s2 == s3) && (s1 != s3)))
                {
                    r = "isosceles";
                    Console.WriteLine(r);
                    break;
                }
                while ((s1 != s2) && (s2 != s3) &&(s3!=s1))
                {
                    r = "scalene";ss
                    Console.WriteLine(r);
                    break;
                }
            }
            else
            {
               r="not a valid triangle";
                Console.WriteLine(r);
            }
            
            return r;
        }
    }
}
       
               
            






