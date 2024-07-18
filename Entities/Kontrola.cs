namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities
{
    public class Kontrola
    {
        public int idKontroli {  get; set; }
        public int? idOdpowiedzialnego { get; set; }
        public int? idSprawdzajacego { get; set; }
        public string obszarStanowisko { get; set; }
        public DateTime dataKontroli { get; set; }

        public List<Pozycja> Pozycje { get; set; }
        public List<PlanDzialan> PlanyDzialan { get; set; }
        public Odpowiedzialny Odpowiedzialny { get; set; }
        public Sprawdzajacy Sprawdzajacy { get; set; }
    }
}
