using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Person
    {
    }
    public class Person
    {
        private int nilai = 0;
        public int Nilai
        {
            get { return Nilai; }
            set
            {
                if (value > 50)
                    nilai = value;
            }
        }
    }
}
