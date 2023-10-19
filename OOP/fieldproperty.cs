using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class fieldpropherty
    {
        private string materi;

        public string Materi
        {
            get { return materi; }
            set { materi = value; }
        }

        public class Person
        {
            private int nilai = 0;
            public int Nilai
            {
                get { return nilai; }
                set
                {
                    if (value > 50)
                        nilai = value;
                }
            }
        }
    }
}