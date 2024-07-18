namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities
{
    public class WynikOdpowiedzi
    {
        public int idWynikuOdpowiedzi {  get; set; }
        public int? idPozycji { get; set; }
        public int? idOdpowiedzi { get; set; }

        public Pozycja Pozycja { get; set; }
        public Odpowiedz Odpowiedz { get; set; }
    }
}
