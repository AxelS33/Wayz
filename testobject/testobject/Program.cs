using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testobject
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] o = new Object[3];
            o.SetValue(1, 0);
            o.SetValue("haha", 1);

            Console.WriteLine(o.GetValue(0));
            Console.WriteLine(o.GetValue(1));
            Console.Read();
            
            
        }
    }
}
