using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01_20150630
{
    public class ProduceListCalculator
    {
        public List<Product> ProductList;

        public void ShowReport()
        {
            double totalPrice = 0.0;
            for (int index = 0; index < ProductList.Count; index++)
            {
                totalPrice += ProductList[index].Price;
                Console.WriteLine(ProductList[index].ToString());
                Console.WriteLine("總價是{0}", totalPrice);
            }
        }
    }
}