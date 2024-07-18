namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities
{
    public class Odpowiedzialny
    {
        public int idOdpowiedzialnego {  get; set; }
        public string imie {  get; set; }
        public string nazwisko { get; set; }

        public List<Kontrola> Kontrole {  get; set; }
        public List<Dzialanie> Dzialania { get; set; }

    }
}
