using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Polymorphism
    {
    }
    class Bentuk
    {
        public virtual void Gambar()
        {
            Console.Write("Ini adalah base class Bentuk");
        }
    }
    class Lingkaran : Bentuk
    {
        public override void Gambar()
        {
            Console.WriteLine("Menggambar Lingkaran...");
        }
        class Persegi : Bentuk
        {
            public override void Gambar()
            {
                Console.WriteLine("Menggambar Persgi...");
            }
        }
    }
}
