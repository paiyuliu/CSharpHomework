using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployeeLibrary
{
    public class Employee
    {// 定義Employee員工類別
        protected int _salary;   // Employee員工類別有Salary薪水屬性

        //virtual 一個虛擬的方法,可以讓被繼續的物件修改
        virtual public int Salary       // 薪水介於20000~40000之間
        {
            get { return _salary; }
            set
            {
                if (value < 20000) // 薪水最少20000
                    _salary = 20000;
                else if (value > 40000)// 薪水最多40000
                    _salary = 40000;
                else
                    _salary = value;
            }
        }

        public virtual void ShowTotal()   // 加入顯示實領獎金方法
        { Console.WriteLine("底薪：{0}", Salary); }
    }

    public class Manager : Employee
    {
        public int Bonus { get; set; }     // 加入Bonus獎金屬性

        public override int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 20000) // 薪水最少20000
                    _salary = 20000;
                else if (value > 80000)// 薪水最多80000
                    _salary = 80000;
                else
                    _salary = value;
            }
        }

        public override void ShowTotal()   // 加入顯示實領獎金方法
        {
            base.ShowTotal();
            Console.WriteLine("實領薪水+獎金：{0}", Bonus + Salary);
        }

        public override string ToString()
        {
            string s = string.Empty;
            s = base.ToString();
            s += string.Format("底薪：{0}", Salary);
            s += string.Format("實領薪水+獎金：{0}", Bonus + Salary);
            //this.ToString();
            return s;
            //return base.ToString();
        }
    }

    public class Sales : Employee
    {
        public override int Salary
        {
            get { return _salary; }
            set { _salary = 22000; }
        }

        public int Premium //業績
        {
            get;
            set;
        }

        public float Bonus
        {
            get { return Premium * 0.1f; }
            //set;
        }

        public int GetTotal()
        {
            return Premium + (int)Bonus + Salary;
        }

        public void ShowTotal()
        {
            Console.WriteLine("總共可以領{0}", GetTotal());
        }
    }
}