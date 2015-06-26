using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fingerGame
{
    internal class ClassFinger
    {
        private int finger;

        public int Finger
        {
            set { finger = value; }
            get { return finger; }
        }

        public void Setfinger(int Finger)
        {
            finger = Finger;
        }

        public String GetFingerDesc()
        {
            String fingerDesc;
            if (finger == 1)
                fingerDesc = "剪刀";
            else if (finger == 2)
                fingerDesc = "石頭";
            else if (finger == 3)
                fingerDesc = "布";
            else
                fingerDesc = "錯誤";
            return fingerDesc;
        }
    }

    internal class GameResult
    {
        private int peopleAns;
        private int cupAns;
        private String result;

        public int PeopleAns
        {
            set { peopleAns = value; }
        }

        public int CupAns
        {
            set { cupAns = value; }
        }

        public String GetResult()
        {
            int Result;

            Math.Abs(-2);
            Math.Sign(-2);

            Result = peopleAns - cupAns;
            if (Result == 0)
            { result = "平手"; }
            else if (Result == 1)
            { result = "你贏了"; }
            else if (Result == 2)
            { result = "你輸了"; }
            else if (Result == -1)
            { result = "你輸了"; }
            else if (Result == -2)
            { result = "你贏了"; }
            else
            { result = "錯誤"; }
            return result;
        }
    }
}