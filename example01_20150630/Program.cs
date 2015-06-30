using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01_20150630
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Product iphone6 = new Product("iphone6", 28000.0);
            // CPU cpu = new CPU("Intel i74970", 12000, 3.8);

            // iphone6.SaySomething();
            //      Console.WriteLine("");
            //      cpu.SaySomething();

            //      Product anotherCPU = new CPU("Intel i3 4370", 6000.0, 3.5);//這是常用的實作物件方法，用最大的包最小的 稱為"向上轉型"或"裝箱(boxing)"
            //    anotherCPU.SaySomething();
            //anotherCPU.Frequency 沒有這個欄位
            //如果想要看到，就要轉回去
            //       ((CPU)anotherCPU).Frequency = 123;//稱為"向下轉型"或"拆箱"
            //       (anotherCPU as CPU).Frequency = 456; //這是另外一種寫法
            //    Console.WriteLine("");
            //那SaySomething是？  我們CPU有寫override SaySomething
            //當我們把product的vertial 及cpu.override拿掉
            //       anotherCPU.SaySomething();
            //       Console.WriteLine("");
            //       ((CPU)anotherCPU).SaySomething();

            //    ProduceListCalculator calculator = new ProduceListCalculator();
            //     calculator.ProductList = new List<Product>();//這是啥米？
            //    calculator.ProductList.Add(iphone6);
            //   calculator.ProductList.Add(cpu);
            //   calculator.ProductList.Add(anotherCPU);
            //  calculator.ShowReport();

            Product[] products = new Product[5];
            products[0] = new Product("product 1", 1500);
            products[1] = new Product("product 1", 1200);
            products[2] = new Product("product 1", 2500);
            products[3] = new Product("product 1", 3000);
            products[4] = new Product("product 1", 900);

            Console.WriteLine("排序前");
            for (int index = 0; index < products.Length; index++)
            { Console.WriteLine(products[index].Price); }

            Array.Sort(products);
            Console.WriteLine("排序後");
            for (int index = 0; index < products.Length; index++)
            { Console.WriteLine(products[index].Price); }
        }
    }
}