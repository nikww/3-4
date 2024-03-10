using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class StringType : IType<string>
    {
        Random rand = new Random();

        public string User_case()
        {
            return Console.ReadLine();
        }

        public string Rndm_case()
        {
            int len = rand.Next(100);
            string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            string s = "";

            for (int i = 0; i < len; i++)
            {
                s += chars[rand.Next(chars.Length)];
            }
            return s;
        }
    }
}
