using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Experience
    {
        public int Years;
        public int Months;
        public int Days;

        public Experience(int years, int months, int days)
        {
            this.Years = years;
            this.Months = months;
            this.Days = days;
        }
    }
}
