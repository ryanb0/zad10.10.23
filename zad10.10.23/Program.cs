using System;
using System.Security.Cryptography.X509Certificates;
using static a;

class a
{
    public static void Main()
    {
        List<Magazyn> magazyny = new List<Magazyn>();

        //funkcje 

        int dodajMagazyn()
        {

            Console.Write("Podaj nazwę producenta: "); string a = Console.ReadLine();
            Console.Write("Podaj nazwę produktu: "); string b = Console.ReadLine();
            Console.Write("Podaj kategorię produktu: "); int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj kod produktu: "); string d = Console.ReadLine();
            Console.Write("Podaj cenę produktu: "); double e = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj opis produktu: "); string f = Console.ReadLine();

            Console.Write("Podaj ulicę: "); string g = Console.ReadLine();
            Console.Write("Podaj Kod Pocztowy: "); string h = Console.ReadLine();
            Console.Write("Podaj Miejscowość: "); string i = Console.ReadLine();
            Console.Write("Podaj Numer Posesji: "); string j = Console.ReadLine();
            Console.Write("Podaj Numer Lokalu: "); string k = Console.ReadLine();
            int najnowszyMagazyn = Convert.ToInt32(magazyny.Count);
            Console.WriteLine(najnowszyMagazyn);

            magazyny.Add(new Magazyn());
            magazyny[najnowszyMagazyn].proddodaj(a, b, c, d, e, f);
            magazyny[najnowszyMagazyn].adrdodaj(g, h, i, j, k);

            foreach (Produkt aProdukt in magazyny[najnowszyMagazyn].produkty)
            {
                Console.WriteLine(aProdukt);
            }

            return 0;
        }
        int usunMagazyn(int wyborMagazynu)
        {
            magazyny.RemoveAt(wyborMagazynu);
            return 0;
        }
        int usunProduktOdMagazynu()
        {
            foreach (Magazyn aMagazyn in magazyny)
            {
                Console.WriteLine(aMagazyn);
            }
            Console.Write("Wybierz Magazyn: "); int wyborMagazynu = Convert.ToInt32(Console.ReadLine());

            foreach (Produkt aProdukt in magazyny[wyborMagazynu].produkty)
            {
                Console.WriteLine(aProdukt);
            }
            Console.Write("Wybierz Produkt z Magazynu: "); int wyborProduktu = Convert.ToInt32(Console.ReadLine());

            magazyny[wyborMagazynu].produkty.RemoveAt(wyborProduktu);
            return 0;
        }


        // wywolywanie funkcji
        dodajMagazyn();
        usunProduktOdMagazynu();


        /*foreach (Produkt aProdukt in magazyny[0].produkty)
        {
            Console.WriteLine(aProdukt);
        }*/
    }
    


    //KLASY 

    public class Produkt
    {
        public string nazwaProducenta;
        public string nazwaProduktu;
        public int kategoria;
        public string kodproduktu;
        public double cena;
        public string opis;

        public override string ToString()
        {
            return "Producet: " + nazwaProducenta;
        }
    }
    public class Magazyn
    {
        public List<Produkt> produkty = new List<Produkt>();
        public List<Adres> adresy = new List<Adres>();

        public void proddodaj( string prodNazwaProducenta, string prodNazwaProduktu, int prodKategoria, string prodKodProduktu, double prodCena, string prodOpis)
        {
            produkty.Add(new Produkt()
            {
                nazwaProducenta = prodNazwaProducenta,
                nazwaProduktu = prodNazwaProduktu,
                kategoria = prodKategoria,
                kodproduktu = prodKodProduktu,
                cena = prodCena,
                opis = prodOpis
            });
        }

        public void adrdodaj( string adrUl, string adrKP, string adrMi, string AdrNP, string adrNL)
        {
            adresy.Add(new Adres()
            {
                ulica = adrUl,
                kodpocztowy = adrKP,
                miejscowosc = adrMi,
                numerPosesji = AdrNP,
                numerLokalu = adrNL,
            });
        }
    }

    public class Adres
    {
        public string ulica;
        public string kodpocztowy;
        public string miejscowosc;
        public string numerPosesji;
        public string numerLokalu;
    }

}
