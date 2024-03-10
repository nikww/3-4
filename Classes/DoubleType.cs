using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class DoubleType : IType<double>
    {
        Random rand = new Random();

        public double User_case()
        {
            return double.Parse(Console.ReadLine());
        }

        public double Rndm_case()
        {
            return (double)rand.Next(100000);
        }
    }
}
