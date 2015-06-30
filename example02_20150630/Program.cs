using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02_20150630
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] student = new Student[5];
            student[0] = new Student(55, 55, 55, 55, 55);
            student[1] = new Student(65, 55, 55, 55, 55);
            student[2] = new Student(45, 55, 55, 55, 55);
            student[3] = new Student(95, 55, 55, 55, 55);
            student[4] = new Student(100, 55, 55, 55, 55);

            Console.WriteLine("排序前");
            for (int index = 0; index < student.Length; index++)
            { Console.WriteLine("第{0}位學生，數學成績{1}", index, student[index].Math); }

            Array.Sort(student);
            Console.WriteLine("排序後");
            for (int index = 0; index < student.Length; index++)
            {
                Console.WriteLine("第{0}位學生，數學成績{1}", index, student[index].Math);
            }
        }
    }
}