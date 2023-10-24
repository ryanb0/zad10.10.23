using System;
using System.Security.Cryptography.X509Certificates;
using static a;

class a
{
    public static void Main()
    {
        // Tutaj jest utworzona lista "magazyny", bedzie to pozniej potrzebne.
        List<Magazyn> magazyny = new List<Magazyn>();

        
        // Funckja do wyświetlania magazynów, produktów i adresów.
        int wyswietlWszystko()
        {
            for (int i = 0; i < magazyny.Count; i++)
            {
                Console.WriteLine("\nProdukty:");
                foreach (Produkt aProdukt in magazyny[i].produkty)
                {
                    Console.WriteLine(aProdukt);
                }

                Console.WriteLine("Adresy:");
                foreach (Adres aAdres in magazyny[i].adresy)
                {
                    Console.WriteLine(aAdres);
                }
            }
            return 0;
        }

        // Tutaj się znajdują funkcję do dodawania, usuwania oraz edytowania obiektów.
        // Dodawanie
        int dodajMagazyn()
        {
            // Try ma tutaj na celu wyłapania błędu gdyby ktoś przy cenie wpisał string zamiast double.
            try
            {
                // Wpisywanie danych produktu.
                Console.Write("Podaj nazwę producenta: "); string a = Console.ReadLine();
                Console.Write("Podaj nazwę produktu: "); string b = Console.ReadLine();
                Console.Write("Podaj kategorię produktu: "); string c = Console.ReadLine();
                Console.Write("Podaj kod produktu: "); string d = Console.ReadLine();
                Console.Write("Podaj cenę produktu: "); double e = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj opis produktu: "); string f = Console.ReadLine();

                // Wpisywanie danych adresu
                Console.Write("Podaj ulicę: "); string g = Console.ReadLine();
                Console.Write("Podaj Kod Pocztowy: "); string h = Console.ReadLine();
                Console.Write("Podaj Miejscowość: "); string i = Console.ReadLine();
                Console.Write("Podaj Numer Posesji: "); string j = Console.ReadLine();
                Console.Write("Podaj Numer Lokalu: "); string k = Console.ReadLine();
                int najnowszyMagazyn = Convert.ToInt32(magazyny.Count);

                // Tutaj jest dodawany nowy magazyn do listy.
                magazyny.Add(new Magazyn());

                // Tutaj do przed chwilą utworzonego magazynu jest dodawany produkt do listy
                magazyny[najnowszyMagazyn].proddodaj(a, b, c, d, e, f);

                // Tutaj do przed chwilą utworzonego magazynu jest dodawany adres do listy
                magazyny[najnowszyMagazyn].adrdodaj(g, h, i, j, k);

                wyswietlWszystko();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Blad przy dodawaniu danych: " + exc.Message);
            }
            return 0;
        }
        int dodajProduktDoMagazynu()
        {
            // Wypisuje listę magazynów.
            foreach (Magazyn aMagazyn in magazyny)
            {
                Console.WriteLine(aMagazyn);
            }

            // Wybieranie magazynu.
            Console.Write("Wybierz Magazyn: "); int wyborMagazynu = Convert.ToInt32(Console.ReadLine());
            
            // Try ma tutaj na celu wyłapania błędu gdyby ktoś przy cenie wpisał string zamiast double.
            try
            {
                // Wpisywanie danych
                Console.Write("Podaj nazwę producenta: "); string a = Console.ReadLine();
                Console.Write("Podaj nazwę produktu: "); string b = Console.ReadLine();
                Console.Write("Podaj kategorię produktu: "); string c = Console.ReadLine();
                Console.Write("Podaj kod produktu: "); string d = Console.ReadLine();
                Console.Write("Podaj cenę produktu: "); double e = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj opis produktu: "); string f = Console.ReadLine();

                // Wywoływana jest funkcja proddodaj która dodaje produkt do listy.
                magazyny[wyborMagazynu].proddodaj(a, b, c, d, e, f);

                wyswietlWszystko();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Blad przy dodawaniu danych: " + exc.Message);
            }
            return 0;
        }
        int dodajAdresDoMagazynu()
        {
            // Wypisuje listę magazynów
            foreach (Magazyn aMagazyn in magazyny)
            {
                Console.WriteLine(aMagazyn);
            }

            // Wybór magazynu
            Console.Write("Wybierz Magazyn: "); int wyborMagazynu = Convert.ToInt32(Console.ReadLine());

            // Wpisywanie danych.
            Console.Write("Podaj ulicę: "); string g = Console.ReadLine();
            Console.Write("Podaj Kod Pocztowy: "); string h = Console.ReadLine();
            Console.Write("Podaj Miejscowość: "); string i = Console.ReadLine();
            Console.Write("Podaj Numer Posesji: "); string j = Console.ReadLine();
            Console.Write("Podaj Numer Lokalu: "); string k = Console.ReadLine();

            // Wywoływana jest funkcja adrdodaj która dodaje adres do listy.
            magazyny[wyborMagazynu].adrdodaj(g, h, i, j, k);

            wyswietlWszystko();

            return 0;
        }

        // Usuwanie
        int usunProduktOdMagazynu()
        {
            // Pokazywane są magazyny do wyboru
            foreach (Magazyn aMagazyn in magazyny)
            {
                Console.WriteLine(aMagazyn);
            }
            Console.Write("Wybierz Magazyn: "); int wyborMagazynu = Convert.ToInt32(Console.ReadLine());

            // Pokazywane są produkty do wyboru z wczesniej wybranego magazynu
            foreach (Produkt aProdukt in magazyny[wyborMagazynu].produkty)
            {
                Console.WriteLine(aProdukt);
            }

            // Wpisywana jest wartość która jest później użyta do usunięcia produktu
            Console.Write("Wybierz Produkt z Magazynu: "); int wyborProduktu = Convert.ToInt32(Console.ReadLine());
             
            // Usuwanie produktu
            magazyny[wyborMagazynu].produkty.RemoveAt(wyborProduktu);
            return 0;
        }
        int usunMagazyn()
        {
            // Pokazuje magazyny do wyboru
            foreach (Magazyn aMagazyn in magazyny)
            {
                Console.WriteLine(aMagazyn);
            }
            Console.Write("Wybierz Magazyn: "); int wyborMagazynu = Convert.ToInt32(Console.ReadLine());

            // Usuwa wybrany magazyn
            magazyny.RemoveAt(wyborMagazynu);
            return 0;
        }
        int usunAdresOdMagazynu()
        {
            // Pokazywane są magazyny do wyboru
            foreach (Magazyn aMagazyn in magazyny)
            {
                Console.WriteLine(aMagazyn);
            }
            Console.Write("Wybierz Magazyn: "); int wyborMagazynu = Convert.ToInt32(Console.ReadLine());

            // Pokazywane są adresy do wyboru z wczesniej wybranego magazynu
            foreach (Adres aAdres in magazyny[wyborMagazynu].adresy)
            {
                Console.WriteLine(aAdres);
            }

            // Wpisywana jest wartość która jest później użyta do usunięcia adresu
            Console.Write("Wybierz Adres z Magazynu: "); int wyborAdresu = Convert.ToInt32(Console.ReadLine());

            // Usuwanie adresu
            magazyny[wyborMagazynu].adresy.RemoveAt(wyborAdresu);
            return 0;
        }

        // Edytowanie
        int edytujProduktOdMagazynu()
        {
            // Wyswietlane są magazyny do wyboru
            foreach (Magazyn aMagazyn in magazyny)
            {
                Console.WriteLine(aMagazyn);
            }
            Console.Write("Wybierz Magazyn: "); int wyborMagazynu = Convert.ToInt32(Console.ReadLine());

            // Wyswietlane są produkty do wyboru
            foreach (Produkt aProdukt in magazyny[wyborMagazynu].produkty)
            {
                Console.WriteLine(aProdukt);
            }

            // Wybor produktu
            Console.Write("Wybierz Produkt: "); int wyborProduktu = Convert.ToInt32(Console.ReadLine());

            // try catch ma tutaj na celu wyłapania błędu gdyby ktoś przy cenie wpisał string zamiast double
            try
            {
                // Wpisywanie nowych wartości.
                Console.Write("Podaj nazwę producenta: "); string a = Console.ReadLine();
                Console.Write("Podaj nazwę produktu: "); string b = Console.ReadLine();
                Console.Write("Podaj kategorię produktu: "); string c = Console.ReadLine();
                Console.Write("Podaj kod produktu: "); string d = Console.ReadLine();
                Console.Write("Podaj cenę produktu: "); double e = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj opis produktu: "); string f = Console.ReadLine();

                // Przypisywanie nowych wartości.
                magazyny[wyborMagazynu].produkty[wyborProduktu].nazwaProducenta = a;
                magazyny[wyborMagazynu].produkty[wyborProduktu].nazwaProduktu = b;
                magazyny[wyborMagazynu].produkty[wyborProduktu].kategoria = c;
                magazyny[wyborMagazynu].produkty[wyborProduktu].kodproduktu = d;
                magazyny[wyborMagazynu].produkty[wyborProduktu].cena = e;
                magazyny[wyborMagazynu].produkty[wyborProduktu].opis = f;

                wyswietlWszystko();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Blad przy dodawaniu danych: " + exc.Message);
            }
            return 0;
        }
        int edytujAdresOdmagazynu()
        {
            // Wypisywane sa magazyny do wyboru
            foreach (Magazyn aMagazyn in magazyny)
            {
                Console.WriteLine(aMagazyn);
            }
            
            // Wybor magazynu
            Console.Write("Wybierz Magazyn: "); int wyborMagazynu = Convert.ToInt32(Console.ReadLine());

            // Wypisywane sa adresy do wyboru
            foreach (Adres aAdres in magazyny[wyborMagazynu].adresy)
            {
                Console.WriteLine(aAdres);
            }

            // Wybor adresu
            Console.Write("Wybierz Adres: "); int wyborAdresu = Convert.ToInt32(Console.ReadLine());

            // Wpisywanie nowych wartości.
            Console.Write("Podaj ulicę: "); string g = Console.ReadLine();
            Console.Write("Podaj Kod Pocztowy: "); string h = Console.ReadLine();
            Console.Write("Podaj Miejscowość: "); string i = Console.ReadLine();
            Console.Write("Podaj Numer Posesji: "); string j = Console.ReadLine();
            Console.Write("Podaj Numer Lokalu: "); string k = Console.ReadLine();

            // Przypisywanie nowych wartości.
            magazyny[wyborMagazynu].adresy[wyborAdresu].ulica = g;
            magazyny[wyborMagazynu].adresy[wyborAdresu].kodpocztowy = h;
            magazyny[wyborMagazynu].adresy[wyborAdresu].miejscowosc = i;
            magazyny[wyborMagazynu].adresy[wyborAdresu].numerPosesji = j;
            magazyny[wyborMagazynu].adresy[wyborAdresu].numerLokalu = k;

            wyswietlWszystko();

            return 0;
        }

    repeatLabel:

            // Są dwa wybory, jeden który jest od tego czy osoba chce coś dodać/edytować/usunąć. Drugi jest od tego co dokładnie osoba chcę dodać/edytować/usunąć.
            // Wybór pierwszy
            Console.WriteLine("Wybierz co chcesz zrobić:\n1.Dodawanie\n2.Edytowanie\n3.Usuwanie");
            string wybor = Console.ReadLine();

            // Wybór drugi
            Console.WriteLine("Wybierz co:\nProdukt\nMagazyn\nAdres");
            string wybor2 = Console.ReadLine();

            // Tutaj się znajduję switch, którym osoba wybiera co chce zrobić.
            // Po wyborze są wywoływane funkcję z wczesniej.
            switch (wybor, wybor2)
            {
                case ("1", "1"):
                    dodajProduktDoMagazynu();
                    break;
                case ("1", "2"):
                    dodajMagazyn();
                    break;
                case ("1", "3"):
                    dodajAdresDoMagazynu();
                    break;


                case ("2", "1"):
                    edytujProduktOdMagazynu();
                    break;
                case ("2", "2"):
                    // Magazynu nie można edytować, ponieważ nie zawiera żadnych danych które można modyfikować.
                    // Magazyn zawiera jedynie produkty oraz adresy, a te się edytuję osobno.
                    Console.WriteLine("Magazynów nie można edytować, tylko produkty lub adresy w nich.");
                    break;
                case ("2", "3"):
                    break;



                case ("3", "1"):
                    usunProduktOdMagazynu();
                    break;
                case ("3", "2"):
                    usunMagazyn();
                    break;
                case ("3", "3"):
                    usunAdresOdMagazynu();
                    break;

                default: 
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
        }

            goto repeatLabel;
    }
    


    // Tutaj się znajdują klasy.

    public class Produkt
    {
        public string nazwaProducenta;
        public string nazwaProduktu;
        public string kategoria;
        public string kodproduktu;
        public double cena;
        public string opis;

        // Tutaj override zwraca informacje o produkcie w formie String
        public override string ToString()
        {
            return "Producent: " + nazwaProducenta + "\nProdukt: " + nazwaProduktu + "\nKategoria: " + kategoria + "\nKod Produktu: " + kodproduktu + "\nCena: " + cena + "\nOpis: " + opis + "\n";
                
        }
    }
    public class Magazyn
    {
        // Te dwię listy dodają produkty oraz adresy którę należą do magazynu.
        public List<Produkt> produkty = new List<Produkt>();
        public List<Adres> adresy = new List<Adres>();

        // Funkcja, ktora dodaje produkt do wczesniej utworzonej w tej klasie listy
        public void proddodaj( string prodNazwaProducenta, string prodNazwaProduktu, string prodKategoria, string prodKodProduktu, double prodCena, string prodOpis)
        {
            // Dodawanie produktu do listy
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

        // Funkcja, ktora dodaje adres do wczesniej utworzonej w tej klasie listy
        public void adrdodaj( string adrUl, string adrKP, string adrMi, string AdrNP, string adrNL)
        {
            // Dodawanie adresu do listy
            adresy.Add(new Adres()
            {
                ulica = adrUl,
                kodpocztowy = adrKP,
                miejscowosc = adrMi,
                numerPosesji = AdrNP,
                numerLokalu = adrNL,
            });
        }

        public override string ToString()
        {
            return "Magazyn";
        }
    }

    public class Adres
    {
        public string ulica;
        public string kodpocztowy;
        public string miejscowosc;
        public string numerPosesji;
        public string numerLokalu;

        // Tutaj override zwraca informacje o adresie w formie String
        public override string ToString()
        {
            return "Ulica: " + ulica + "\nKod Pocztowy: " + kodpocztowy + "\nMiejscowosc: " + miejscowosc + "\nNumer Posesji: " + numerPosesji + "\nNumer Lokalu: " + numerLokalu + "\n";

        }
    }

}
