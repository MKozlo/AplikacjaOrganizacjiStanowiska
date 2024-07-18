namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities
{
    public class PlanDzialan
    {
        public int idPlanuDzialan {  get; set; }
        public int? idKontroli { get; set; }
        public string temat {  get; set; }
        public string dzial {  get; set; }
        public string obszar { get; set; }
        public int idSprawdzajacego { get; set; }
        public DateTime data { get; set; }

        public Sprawdzajacy Sprawdzajacy { get; set; }
        public Kontrola Kontrola { get; set; }
        public List<Dzialanie> Dzialania { get; set; }
    }
}
