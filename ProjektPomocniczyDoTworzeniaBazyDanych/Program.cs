using System;
using System.Collections.Generic;
using System.IO;

namespace ProjektPomocniczyDoTworzeniaBazyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"files/imionaInazwiska.txt");
            string[] linesOfCars = File.ReadAllLines("files/NazwySamochodow.txt");
            string[] linesofDate = File.ReadAllLines("files/Daty.txt");

            Zlecenie z = new Zlecenie();

            z.Data = linesofDate[1];
            Random _random = new Random();
            z.Przebieg = _random.Next(70000, 300000);
            z.ImieINazwiskoWlasciciela = lines[1];
            string [] Car = linesOfCars[1].Split(' ');
            z.MarkaAuta = Car[0];
            foreach (var item in Car[1])
            {
                z.ModelAuta = z.ModelAuta + item;               /// do poprawki zeby nie bralo pierwszego wyrazu
            }
          



    }
    }
}
