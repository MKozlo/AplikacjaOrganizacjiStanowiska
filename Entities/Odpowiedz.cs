using System.ComponentModel.DataAnnotations.Schema;

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities
{
    public class Odpowiedz
    {
        public int idOdpowiedzi { get; set; }
        public string tresc {  get; set; }

        public int idPytania { get; set; }

        public Pytanie Pytanie { get; set; }
        public List<WynikOdpowiedzi> WynikiOdpowiedzi { get; set; }
    }
}
