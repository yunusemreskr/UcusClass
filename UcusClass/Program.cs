using UcusClass;

internal class Program
{
    private static void Main(string[] args)
    {

        Bilgiler ucus1 = new Bilgiler();
        ucus1.kod = "THY-23";
        ucus1.kalkis = "IST";
        ucus1.varis = "ANK";
        ucus1.saat = "15.30";
        ucus1.vakit = 45;
        ucus1.yolcu = 260;
        ucus1.bilet = 180;

        Bilgiler ucus2 = new Bilgiler();
        ucus2.kod = "THY-12";
        ucus2.kalkis = "ANT";
        ucus2.varis = "AMS";
        ucus2.saat = "19.00";
        ucus2.vakit = 55;
        ucus2.yolcu = 180;
        ucus2.bilet = 180;

        Bilgiler[] ucuslar = new Bilgiler[] { ucus1, ucus2 };

        //Ucuslari gormek icin dongu

        foreach (Bilgiler ucus in ucuslar)
        {
            Console.WriteLine("Ucuslarimiz : " + ucus.kod +  " sefer sayili " + ucus.kalkis + " - " + ucus.varis + " ucuslarimizdir.");
        }



        KalanBilet kalanBilet = new KalanBilet();

        kalanBilet.Kalanbilet(ucus1);



        Anons anons = new Anons();

        anons.Anons1(ucus2);

        
        Bilet bilet = new Bilet();

        bilet.biletAlma(ucus1);


        Console.WriteLine(ucus1.yolcu);


    }
}