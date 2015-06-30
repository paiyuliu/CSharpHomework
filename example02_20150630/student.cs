using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02_20150630
{
    public class Student : IComparable<Student>
    {
        public int Math { get; set; }

        public int English { get; set; }

        public int Chinese { get; set; }

        public int Social { get; set; }

        public int Nature { get; set; }

        public int score { get; set; }

        public Student(int math, int english, int chinese, int social, int nature)
        {
            this.Math = math;
            this.English = english;
            this.Chinese = chinese;
            this.Social = social;
            this.Nature = nature;
        }

        public int CompareTo(Student other, int i)
        {
            if (i == 1) this.score = this.Math;

            if (this.score > other.score) return 1;
            else if (this.score == other.score) return 0;
            else return -1;
        }
    }
}