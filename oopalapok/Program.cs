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
    public class Bankszamla 
    {
        private int egyenleg;

        public int Egyenleg 
        {
            get { return egyenleg; }
            set 
            {
                if(value>0)
                egyenleg = value; 
            else
                Console.WriteLine("Az egyenleg nem lehetnulla");
            }
        }

        private void betesz() 
        
        {
        
        }
        private void kivesz() 
        {

        }

    }

    public class halgato : szemely 
    
    {
        private int neptunkod;
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {



            szemely tanulo1 = new szemely();
            tanulo1.nev = "John";
            Console.WriteLine(tanulo1.nev);
            tanulo1.kor = 23;
            Console.WriteLine(tanulo1.kor);


            Bankszamla szamla1 = new Bankszamla();
            szamla1.Egyenleg = 1000;
            Console.WriteLine(szamla1.Egyenleg);
            /*  szemely tanulo1 = new szemely("Mark", 19);
              Console.WriteLine(tanulo1.kiir());
              szemely tanulo2 = new szemely("John", 21);
              Console.WriteLine(tanulo2.kiir());*/
            // Console.WriteLine($"A tanuló neve: {tanulo.nev} és {tanulo.kor} éves");
        }
    }
}

