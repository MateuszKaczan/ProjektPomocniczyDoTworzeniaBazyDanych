using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektPomocniczyDoTworzeniaBazyDanych
{
    public class Zlecenie
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public int Przebieg { get; set; }
        public string ImieINazwiskoWlasciciela { get; set; }
        public string MarkaAuta { get; set; }
        public string ModelAuta { get; set; }
        public string Silnik { get; set; }
        public bool WymianaOleju { get; set; }
        public bool FiltrOleju { get; set; }
        public bool filtrPaliwa { get; set; }
        public bool FiltrPowietrza { get; set; }
        public bool FiltrKabinowy { get; set; }
        public bool Plynhamulcowy { get; set; }
        public bool PlynChlodniczy { get; set; }
        public bool PrzegladKlimatyzacji { get; set; }
        public bool Swiece { get; set; }
        public bool Rozrzad { get; set; }
        public bool PaskiNapeduSprzetu { get; set; }
        public bool ZlecenieZakonczone { get; set; }

    }
}
