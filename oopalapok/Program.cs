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
        public string nev { get; set; }
        public int kor { get; set; }
/*
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        public int Kor
        {
            get { return kor; }
            set { kor = value; }
        }

          public szemely(string Nev, int Kor)
          {
              nev = Nev;
              kor = Kor;
          }
          public string kiir()
          {
              return $"A tanuló neve: {nev} és {kor} éves";
          }*/

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            szemely tanulo1 = new szemely();
            tanulo1.Nev = "John";
            Console.WriteLine(tanulo1.Nev);
            tanulo1.Kor = 23;
            Console.WriteLine(tanulo1.Kor);
            /*  szemely tanulo1 = new szemely("Mark", 19);
              Console.WriteLine(tanulo1.kiir());
              szemely tanulo2 = new szemely("John", 21);
              Console.WriteLine(tanulo2.kiir());*/
            // Console.WriteLine($"A tanuló neve: {tanulo.nev} és {tanulo.kor} éves");
        }
    }
}

