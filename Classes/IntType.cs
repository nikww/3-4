using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class IntType : IType<int> 
    {
        Random rand = new Random();

        public int User_case()
        {
            return int.Parse(Console.ReadLine());
        }

        public int Rndm_case()
        {
            return rand.Next(100000);
        }
    }
}
