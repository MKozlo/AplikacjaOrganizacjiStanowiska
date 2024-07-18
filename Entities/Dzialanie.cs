namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities
{
    public class Dzialanie
    {
        public int idDzialania {  get; set; }
        public int? idPlanuDzialan {  get; set; }
        public DateTime data {  get; set; }
        public string miejsceTemat { get; set; }
        public string obserwacjeProblemy { get; set; }
        public string dzialania { get; set; }
        public int idOdpowiedzialnego { get; set; }
        public DateTime doKiedy {  get; set; }
        public string komentarz {  get; set; }

        public PlanDzialan PlanDzialan { get; set; }
        public Odpowiedzialny Odpowiedzialny { get; set; }
    }
}
