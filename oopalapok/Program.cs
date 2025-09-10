using oopalapok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oopalapok
{
    public class szemely
    {
        private string nev;
        private int kor;

        public szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }
        public string kiir()
        {
            return $"A tanuló neve: {nev} és {kor} éves";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            szemely tanulo1 = new szemely("Mark", 19);
            Console.WriteLine(tanulo1.kiir());
            szemely tanulo2 = new szemely("John", 21);
            Console.WriteLine(tanulo2.kiir());
            // Console.WriteLine($"A tanuló neve: {tanulo.nev} és {tanulo.kor} éves");
        }
    }
}

