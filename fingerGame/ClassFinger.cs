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

        public void Setfinger(int Finger)
        {
            finger = Finger;
        }

        public String Getfinger()
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

        public void SetResult(int PeopleAns, int CupAns)
        {
            peopleAns = PeopleAns;
            cupAns = CupAns;
        }

        private Boolean GetResult()
        {
            return true;
        }
    }
}