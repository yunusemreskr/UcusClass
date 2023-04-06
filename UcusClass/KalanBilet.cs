using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcusClass
{
    internal class KalanBilet 
    {
    
        public void Kalanbilet(Bilgiler ucus) 
        {

            int ucuskalan = ucus.yolcu - ucus.bilet;

            
            Console.WriteLine("Ucakta " + ucuskalan + " adet bilet kalmistir.");


        }
    
    }

}
