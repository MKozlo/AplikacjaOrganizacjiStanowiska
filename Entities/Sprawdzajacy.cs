namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities
{
    public class Sprawdzajacy
    {
        public int idSprawdzajacego {  get; set; }
        public string imie {  get; set; }
        public string nazwisko { get; set; }

        public List<Kontrola> Kontrole {  get; set; }
        public List<PlanDzialan> PlanyDzialan { get; set; }
    }
}
