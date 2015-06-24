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
            person.Finger = int.Parse(Console.ReadLine());
            Random computerFinger = new Random();
            computer.Finger = computerFinger.Next(1, 4);
            GameResult game = new GameResult();
            game.PeopleAns = person.Finger;
            game.CupAns = computer.Finger;
            Console.WriteLine("你出的是{0}", person.GetFingerDesc());
            Console.WriteLine("電腦出  {0}", computer.GetFingerDesc());
            Console.WriteLine("結果是{0}", game.GetResult());
        }
    }
}