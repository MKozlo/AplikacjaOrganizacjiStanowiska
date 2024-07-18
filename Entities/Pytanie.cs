using System.ComponentModel.DataAnnotations.Schema;

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities
{
    public class Pytanie
    {
        public int idPytania {  get; set; }
        public string tresc { get; set; }

        public int idKroku { get; set; }

        public Krok Krok { get; set; }
        public List<Odpowiedz> Odpowiedzi { get; set; }
    }
}
