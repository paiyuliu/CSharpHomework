using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01_20150630
{
    public class CPU : Product
    {
        public double Frequency { get; set; }

        public CPU(string name, double price, double frequency)
            : base(name, price)
        { this.Frequency = frequency; }

        //public new void SaySomething()
        //override void SaySomething()
        public new void SaySomething()
        {
            Console.WriteLine("{0}", this.Name);
            Console.WriteLine("這是CPU類別的SaySomething");
            base.SaySomething();
            Console.WriteLine("這是CPU類別的SaySomething的結尾");
        }
    }
}