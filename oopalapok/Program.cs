using oopalapok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopalapok
{
    public class szemely
    {
        public string nev = "márk";
        public int kor =30;
    }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        szemely tanulo = new szemely();
        Console.WriteLine($"A tanuló neve: {tanulo.nev} és {tanulo.kor} éves");
    }
    }
}
