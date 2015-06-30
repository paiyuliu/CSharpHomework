using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01_20150630
{
    //public class Product : IComparable<Product> //泛型

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public double Price
        {
            get;
            set;
        }

        private int amount;

        public void SaySomething()
        { Console.WriteLine("這是product類別的SaySomething"); }

        public int Amount
        {
            get { return amount; }
            set { amount = value < 0 ? 0 : amount; }
        }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0},數量:{1},小計:{2}", this.Name, this.Amount, this.Amount * this.Price);
        }

        public int CompareTo(Product other)
        {
            if (this.Price > other.Price) return 1;
            else if (this.Price == other.Price) return 0;
            else return -1;
        }
    }
}