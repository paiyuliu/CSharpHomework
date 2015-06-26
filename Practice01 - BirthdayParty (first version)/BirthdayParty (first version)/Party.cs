using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BirthdayParty__first_version_
{
    public class Party
    {
        public const int CostOfFoodPerPerson = 25;

        public virtual decimal Cost
        {
            get;
            set;
        }

        public bool FancyDecorations { get; set; }

        public int NumberOfPeople { get; set; }

        public virtual decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            return costOfDecorations;
        }
    }
}