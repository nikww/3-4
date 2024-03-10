using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IType<T>
    {
        T User_case();
        T Rndm_case();
    }
}
