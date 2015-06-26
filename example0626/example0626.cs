using ClassEmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example0626
{
    internal class example0626
    {
        private static void Main(string[] args)
        {
            Employee tom = new Employee();// 建立Employee員工類別的tom物件
            tom.Salary = 50000;              // 設定薪水
            Console.WriteLine("tom員工薪水{0}", tom.Salary); // 顯示薪水
            Console.WriteLine("================");
            Console.WriteLine();
            Manager peter = new Manager(); // 建立Manager經理類別peter物件
            peter.Salary = 50000;     // 設定薪水
            Console.WriteLine("peter經理薪水{0}", peter.Salary);// 顯示薪水
            peter.Bonus = 30000;        // 設定peter的獎金30000
            Console.WriteLine("peter經理獎金{0}", peter.Bonus);// 顯示獎金
            peter.ShowTotal();            // 顯示peter實領薪水
            Console.Read();

            Sales boy = new Sales();
            boy.Premium = 10000;
            //boy.Bonus = 5000;
            boy.Salary = 999;
            boy.ShowTotal();
        }
    }
}