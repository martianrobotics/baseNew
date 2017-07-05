using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseNew
{
    class xBase
    {
        //public void Execute()
        public virtual void Execute()
        {
            Console.WriteLine("Base.Execute");
        }
    }

    class xDerived:xBase
    {
        public override void Execute()
        {
            Console.WriteLine("Derived.Execute");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            xBase b = new xBase();
            b.Execute();
            b = new xDerived();
            b.Execute();
            Console.ReadKey();
        }
    }
}
