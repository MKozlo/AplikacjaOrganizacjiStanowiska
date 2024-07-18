using System.ComponentModel.DataAnnotations.Schema;

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities
{
    public class Krok
    {
        public int idKroku {  get; set; }
        public string tresc {  get; set; }

        public int idPozycji { get; set; }

        public Pozycja Pozycja { get; set; }
        public List<Pytanie> Pytania { get; set; }
    }
}
