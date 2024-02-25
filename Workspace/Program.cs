using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    public  class Program
    {
        static void Main(string[] args)
        {
            string mesaj = "merhaba";
            double tutar = 100000; // db den gelir.
            int sayi = 100;
            bool girisYapmisMi=false;

            string ad = " Engin ";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 1234567910;

            Vatandaş vatandaş1 = new Vatandaş();
            vatandaş1.





            Console.WriteLine(mesaj );

        }
    }  public  class Vatandaş
    {
        public string  Ad { get; set; }
        public string  Soyad { get; set; }
        public int DoğumYili { get; set; }
        public long TcNo  { get; set; }



    }

}
