using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class BoolType : IType<bool>
    {
        Random rand = new Random();

        public bool User_case()
        {
            return int.Parse(Console.ReadLine()) != 0;
        }

        public bool Rndm_case()
        {
            return rand.Next(100000) <= 50000;
        }
    }
}
