using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fingerGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ClassFinger person = new ClassFinger();
            ClassFinger computer = new ClassFinger();

            Console.WriteLine("請出拳 1剪刀 2石頭 3布");

            person.Setfinger(int.Parse(Console.ReadLine()));
            Random computerFinger = new Random();
            computer.Setfinger(computerFinger.Next(1, 4));
            //int test = abc;
            Console.WriteLine(person.Getfinger());
            Console.WriteLine(computer.Getfinger());
        }
    }
}