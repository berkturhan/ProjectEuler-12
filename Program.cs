using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler12
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = 1; ;
            double triang = 1;

            


            while(CalcViaPrimeFactors(triang) < 501)
            {
                n++;
                triang = n * (n + 1) / 2;
            }
                Console.WriteLine(triang);
                Console.ReadLine();
            

        }

        public static int CalcViaPrimeFactors(double a)
        {
            int result = 1;
            for (int b = 2; a > 1; b++)
            {
                if (a % b == 0)
                {
                    int x = 0;
                    while (a % b == 0)
                    {
                        a /= b;
                        x++;
                    }
                    result = result * (x + 1);

                }
                
            }
            return result;
        }
    }
}
