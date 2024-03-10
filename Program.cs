using System;
using System.Collections.Generic;

namespace ConsoleApp3
{

    public class HelloWorld
    {
        static void Main()
        {
            IntType t_int = new IntType();
            DoubleType t_double = new DoubleType();
            StringType t_string = new StringType();
            BoolType t_bool = new BoolType();
            IPrinter[] examples_print = new IPrinter[8];

            Console.WriteLine("Введите количество элементов в одномерных массивах разных типов данных:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите как нужно заполнить одномерные массивы разных типов данных (0 - рандомными числами, 1 - с клавиатуры пользователем):");
            int t = int.Parse(Console.ReadLine());
            bool f = t == 1 ? true : false;
            examples_print[0] = new One<int>(t_int, n, f);
            examples_print[1] = new One<double>(t_double, n, f);
            examples_print[2] = new One<string>(t_string, n, f);
            examples_print[3] = new One<bool>(t_bool, n, f);


            Console.WriteLine("Введите количество строк и столбцов в двумернах массивах разных типов данных:");
            int n1 = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите как нужно заполнить двумернык массивы разных типов данных (0 - рандомными числами, 1 - с клавиатуры пользователем):");
            int v = int.Parse(Console.ReadLine());
            bool r = v == 1 ? true : false;
            examples_print[4] = new Two<int>(t_int, n1, m1, r);
            examples_print[5] = new Two<double>(t_double, n1, m1, r);
            examples_print[6] = new Two<string>(t_string, n1, m1, r);
            examples_print[7] = new Two<bool>(t_bool, n1, m1, r);

            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                examples_print[i].array_output();
            }
        }
    }


}