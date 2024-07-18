using System.ComponentModel.DataAnnotations.Schema;

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities
{
    public class Pozycja
    {
        public int idPozycji {  get; set; }
        public string nazwa {  get; set; }
        public int? poprzedniWynik { get; set; }
        public int? wynikCalkowity { get; set; }

        public int? idKontroli { get; set; }

        public  Kontrola Kontrola { get; set; }
        public List<Krok> Kroki { get; set; }
        public List<WynikOdpowiedzi> WynikiOdpowiedzi { get; set; }
    }
}
