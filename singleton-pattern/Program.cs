using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Kettle kettle = Kettle.GetInstance();

            kettle.Fill();
            kettle.Boil();
            kettle.Drain();

            Console.ReadLine();
        }
    }
}
