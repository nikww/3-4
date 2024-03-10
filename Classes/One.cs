using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public sealed class One<T> : BaseClass
    {
        private T[] array;
        private IType<T> type;
        public One(IType<T> cur_type, int cnt, bool way_to_fill = false) : base(way_to_fill)
        {
            type = cur_type;
            array = new T[cnt];
            Fill();
        }


        protected override void FillByUser()
        {
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = type.User_case();
            }
        }

        protected override void RndmFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = type.Rndm_case();
            }
        }

        public override void array_output()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
