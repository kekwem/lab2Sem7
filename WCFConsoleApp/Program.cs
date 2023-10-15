using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using WCFConsoleApp.ServiceReference;

namespace WCFConsoleApp
{
    internal class Program
    {
        public static void menu()
        {
            Console.WriteLine("1 - dodawanie");
            Console.WriteLine("2 - odejmowanie");
            Console.WriteLine("3 - mnozenie");
            Console.WriteLine("4 - dzielenie");
            Console.WriteLine("0 - wyjscie");
        }

        public static double[] wpiszDane(double[] tablica)
        {
            int liczba = tablica.Length;
            for (int i = 0; i < liczba; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Wpisz czesc rzeczewista");
                else
                    Console.WriteLine("Wpisz czesc urojona");
                tablica[i] = Double.Parse(Console.ReadLine());
            }
            return tablica;
        }

        static void Main(string[] args)
        {
            CalculatorSeviceClient client = new CalculatorSeviceClient();
            string result;
            int wyb = 10;
            double[] tablica = new double[4];
            while (wyb != 0)
            {
                menu();
                wyb = int.Parse(Console.ReadLine());
                if (wyb != 0)
                    wpiszDane(tablica);

                switch (wyb)
                {
                    case 1:
                        result = client.dodawanie4Param(tablica[0], tablica[1], tablica[2], tablica[3]);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        result = client.odejmowanie4Param(tablica[0], tablica[1], tablica[2], tablica[3]);
                        Console.WriteLine(result);
                        break;
                    case 3:
                        result = client.mnozenie4Param(tablica[0], tablica[1], tablica[2], tablica[3]);
                        Console.WriteLine(result);
                        break;
                    case 4:
                        result = client.dzielenie4Param(tablica[0], tablica[1], tablica[2], tablica[3]);
                        Console.WriteLine(result);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("brak takiej opcji!");
                        break;
                }
            }
        }
    }
}
