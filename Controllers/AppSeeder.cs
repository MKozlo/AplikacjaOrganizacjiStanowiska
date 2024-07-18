using Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Controllers
{
    public class AppSeeder
    {
        private readonly AppDbContext _db;
        public AppSeeder(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public void Seed()
        {
            if (_db.Database.CanConnect())
            {
                // Seed Pozycje
                if (!_db.Pozycje.Any())
                {
                    var pozycje = new[]
                    {
                        new Pozycja { nazwa = "Selekcja" },
                        new Pozycja { nazwa = "Systematyka" },
                        new Pozycja { nazwa = "Sprzątanie" },
                        new Pozycja { nazwa = "Standaryzacja" },
                        new Pozycja { nazwa = "Samodoskonalenie" },
                        new Pozycja { nazwa = "Bezpieczeństwo" }
                    };

                    _db.Pozycje.AddRange(pozycje);
                    _db.SaveChanges();
                }

                // Seed Kroki
                if (!_db.Kroki.Any())
                {
                    var kroki = new[]
                    {
                            new Krok { tresc = "a", idPozycji = 1 },
                            new Krok { tresc = "b", idPozycji = 1 },
                            new Krok { tresc = "c", idPozycji = 1 },
                            new Krok { tresc = "d", idPozycji = 1 },
                            new Krok { tresc = "e", idPozycji = 1 },
                            new Krok { tresc = "a", idPozycji = 2 },
                            new Krok { tresc = "b", idPozycji = 2 },
                            new Krok { tresc = "c", idPozycji = 2 },
                            new Krok { tresc = "d", idPozycji = 2 },
                            new Krok { tresc = "e", idPozycji = 2 },
                            new Krok { tresc = "a", idPozycji = 3 },
                            new Krok { tresc = "b", idPozycji = 3 },
                            new Krok { tresc = "c", idPozycji = 3 },
                            new Krok { tresc = "d", idPozycji = 3 },
                            new Krok { tresc = "e", idPozycji = 3 },
                            new Krok { tresc = "a", idPozycji = 4 },
                            new Krok { tresc = "b", idPozycji = 4 },
                            new Krok { tresc = "c", idPozycji = 4 },
                            new Krok { tresc = "d", idPozycji = 4 },
                            new Krok { tresc = "e", idPozycji = 4 },
                            new Krok { tresc = "a", idPozycji = 5 },
                            new Krok { tresc = "b", idPozycji = 5 },
                            new Krok { tresc = "c", idPozycji = 5 },
                            new Krok { tresc = "d", idPozycji = 5 },
                            new Krok { tresc = "e", idPozycji = 5 },
                            new Krok { tresc = "a", idPozycji = 6 },
                            new Krok { tresc = "b", idPozycji = 6 },
                            new Krok { tresc = "c", idPozycji = 6 },
                            new Krok { tresc = "d", idPozycji = 6 },
                            new Krok { tresc = "e", idPozycji = 6 }
                    };

                    _db.Kroki.AddRange(kroki);
                    _db.SaveChanges();
                }

                // Seed Pytania
                if (!_db.Pytania.Any())
                {
                    var pytania = new[]
                    {
                        new Pytanie { tresc = "W jakim stopniu usunięto przestarzałe lub zdublowane dokumenty / wydruki / procedury / instrukcje / itp.?", idKroku = 1 },
                        new Pytanie { tresc = "Czy funcjonuje schemat postępowania, system regularnego usuwania rzeczy niepotrzebnych?", idKroku = 1 },
                        new Pytanie { tresc = "Na ile schemat postępowania, system regularnego usuwania rzeczy niepotrzebnych działa?", idKroku = 1 },

                        new Pytanie { tresc = "Czy nie ma nadmiaru materiałów, rzeczy fizycznych, opakowań?", idKroku = 2 },
                        new Pytanie { tresc = "Czy usunięto/zagospodarowano odpady?", idKroku = 2 },

                        new Pytanie { tresc = "W jakim stopniu usunięto zniszczone, uszkodzone, przestarzałe, nie mające zastosowania lub nadmierne ilości produktów / narzędzi / części ?", idKroku = 3 },

                        new Pytanie { tresc = "Czy usunięto lub naprawiono nieużywane lub uszkodzone sprzęty, wyposażenie, urządzenia transportowe, itp?", idKroku = 4 },
                        new Pytanie { tresc = "Czy są jakieś przestarzałe lub zbyteczne oznakowania podłogi, regałów, urządzeń, stanowisk pracy, ogłoszenia?", idKroku = 4 },

                        new Pytanie { tresc = "Na ile usunięto przestarzałe, nieaktualne lub zbyteczne informacje?", idKroku = 5 },
                        new Pytanie { tresc = "W jakim stopniu usunięto z urządzeń cyfrowych niepotrzebne / nieaktualne / nieużywane pliki, foldery, programy, aplikacje, skróty, sterowniki?", idKroku = 5 },
                        new Pytanie { tresc = "W jakim stopniu usunięto z urządzeń cyfrowych niepotrzebne / nieaktualne / nieużywane kontakty?", idKroku = 5 },
                        new Pytanie { tresc = "W jakim stopniu usunięto z urządzeń cyfrowych niepotrzebne / nieaktualne / nieużywane powiadomienia, subskrypcje, abonamenty?", idKroku = 5 },

                        new Pytanie { tresc = "W jakim stopniu wszystkie przedmioty fizyczne, (np..: materiały, produkty, komponenty, wyposażenie) mają zdefiniowane i oznaczone pozycje?", idKroku = 6 },
                        new Pytanie { tresc = "Na ile można łatwo stwierdzić kiedy czegoś brakuje?", idKroku = 6 },
                        new Pytanie { tresc = "Czy są zdjęcia, layouty, jednopunktowe lekcje pokazujące jak wygląda stanowisko po zakończonej pracy?", idKroku = 6 },

                        new Pytanie { tresc = "Czy wszystkie rzeczy są na zdefiniowanych pozycjach, szczególnie po zakończonej pracy?", idKroku = 7 },
                        new Pytanie { tresc = "Na ile te pozycje są logicznie zdefiniowane by zapewnić właściwy ruch osób, oraz przemieszczanie i składowanie przedmiotów fizycznych?", idKroku = 7 },
                        new Pytanie { tresc = "W jakim stopniu narzędzia, przyrządy są łatwe do znalezienia (np.: tablice cieni, przegródki, itp.)?", idKroku = 7 },
                        new Pytanie { tresc = "Czy stanowiska używane od czasu do czasu zostały zagospodarowane, objęte systemem odkładania na miejsce?", idKroku = 7 },

                        new Pytanie { tresc = "W jakim stopniu na urządzeniach cyfrowych pliki, foldery, programy, aplikacje, skróty, sterowniki mają swoje przypisane miejsce (również dysk sieciowy)?", idKroku = 8 },
                        new Pytanie { tresc = "Czy kontakty na urządzeniach cyfrowych są uporządkowane według częstości ich używania?", idKroku = 8 },
                        new Pytanie { tresc = "Do jakiego stopnia wiemy gdzie są powiadomienia, subskrypcje, abonamenty?", idKroku = 8 },
                        new Pytanie { tresc = "Czy szybko i wygodnie można znaleźć rzeczy wirtualne po dłuższym czasie ich nieużywania?", idKroku = 8 },

                        new Pytanie { tresc = "Na ile stanowiska zostały przypisane do właścicieli?", idKroku = 9 },
                        new Pytanie { tresc = "W jakim stopniu segregatory, teczki, półki, szafki, regały i ich zawartość zostały opisane?", idKroku = 9 },
                        new Pytanie { tresc = "Czy standard przekazania zmiany istnieje?", idKroku = 9 },
                        new Pytanie { tresc = "Na ile standard przekazania zmiany działa?", idKroku = 9 },

                        new Pytanie { tresc = "Czy wszystkie przedmioty, narzędzia i sprzęt są usytuowane zgodnie z częstotliwością i miejscem ich wykorzystywania?", idKroku = 10 },
                        new Pytanie { tresc = "Czy jest legenda oznaczenia kolorystycznego na obszarze?", idKroku = 10 },
                        new Pytanie { tresc = "Czy są oznaczone zakresy otwierania drzwi?", idKroku = 10 },
                        new Pytanie { tresc = "Czy na drzwiach wejściowych lub obok jest layout pomieszczenia z identyfikacją osób znajdujących się wewnątrz?", idKroku = 10 },

                        new Pytanie { tresc = "Czy poziom czystości urządzeń, również logostycznych, maszyn, szafek, półek, pojemników, regałów, stanowiska pracy, etc. jest odpowiedni do ich funkcji i zapewnia sprawne działanie?", idKroku = 11 },

                        new Pytanie { tresc = "Czy poziom czystości wskazuje na to, że obszar jest sprzątany regularnie?", idKroku = 12 },
                        new Pytanie { tresc = "Czy jest i działa harmonogram sprzątania?", idKroku = 12 },

                        new Pytanie { tresc = "Czy ilości i rodzaje odpadów na obszarze wskazują na to, że odpady są poprawnie sortowane i że kosze z odpadami są regularnie opróżniane?", idKroku = 13 },
                        new Pytanie { tresc = "Czy w pomieszczeniu znajduje się kącik czystości?", idKroku = 13 },
                        new Pytanie { tresc = "Czy przyrządy służące do sprzątania są sprawne, czyste i odkładane na miejsce?", idKroku = 13 },

                        new Pytanie { tresc = "Czy rzeczy osobiste mają swoje miejsce, nie są narażone na zniszczenie lub utratę?", idKroku = 14 },
                        new Pytanie { tresc = "Czy w pomieszczeniu spożywane są produkty spożywcze?", idKroku = 14 },
                        new Pytanie { tresc = "Czy źródła zanieczyszczeń zostały opanowane w stopniu pozwalającym uniknąć powtarzającego się sprzątania?", idKroku = 14 },
                        new Pytanie { tresc = "Czy są zniszczone posadzki, ściany, okna, drzwi, sufit, meble?", idKroku = 14 },
                        new Pytanie { tresc = "Na ile miejsca trudnodostępne zostały zidentyfikowane i objęte systemem czystości?", idKroku = 14 },

                        new Pytanie { tresc = "Na ile funkcjonuje standard regularnego czyszczenia, opróżniania folderów/plików temp, temporary, pamięci cache, plików log, historii działań i historii przeglądarki/rek internetowych oraz nieaktualnych kontaktów?", idKroku = 15 },

                        new Pytanie { tresc = "Czy zdefiniowany jest standard stanowiska pracy w zależności od stosowanej na nim technologii, typu wykonywanej pracy?", idKroku = 16 },

                        new Pytanie { tresc = "Czy zdefiniowany jest standard oznakowania podłogi i stanowisk pracy oraz czy jest pokazany?", idKroku = 17 },
                        new Pytanie { tresc = "Na ile w tym momencie funkcjonowania jest to najlepszy możliwy standard dla tego stanowiska i rzeczy na nim się znajdujących?", idKroku = 17 },

                        new Pytanie { tresc = "Czy jest tablica 'zarządzania wizualnego', informacyjna?", idKroku = 18 },
                        new Pytanie { tresc = "Czy wskaźniki są właściwe dla zakresu działalności i aktualne?", idKroku = 18 },
                        new Pytanie { tresc = "Czy jest widoczny plan doskonalenia w obszarze?", idKroku = 18 },
                        new Pytanie { tresc = "Czy są wywieszone zdjęcia 'przed' i 'po'?", idKroku = 18 },
                        new Pytanie { tresc = "Czy przyrządy, części są standaryzowane z resztą organizacji?", idKroku = 18 },

                        new Pytanie { tresc = "Czy każdy pracownik jest poinformowany o tym kiedy nowe normy, zasady, standardy są wdrażane na obszarze?", idKroku = 19 },
                        new Pytanie { tresc = "Czy wszyscy pracownicy są systematycznie informowani o wynikach sprawdzania organizacji pracy na stanowiskach?", idKroku = 19 },
                        new Pytanie { tresc = "Czy zdefiniowany jest standard czystości dla obszaru?", idKroku = 19 },
                        new Pytanie { tresc = "Czy są widoczne i aktualne harmonogramy sprzątania, podział obowiązków?", idKroku = 19 },

                        new Pytanie { tresc = "W jakim stopniu na urządzeniach cyfrowych pliki, foldery, programy, aplikacje, skróty, sterowniki mają swoje ustandaryzowane nazwy?", idKroku = 20 },
                        new Pytanie { tresc = "Czy kontakty na urządzeniach cyfrowych są nazwane według jakiegoś systemu / standardu?", idKroku = 20 },
                        new Pytanie { tresc = "Czy pracownik zastępujący szybko odnajdzie się na tych urządzeniach cyfrowych?", idKroku = 20 },
                        new Pytanie { tresc = "Do jakiego stopnia powiadomienia, subskrypcje, abonamenty są usystematyzowane?", idKroku = 20 },
                        new Pytanie { tresc = "Na ile wersja oprogramowania, aplikacji jest ustandaryzowana z resztą organizacji?", idKroku = 20 },


                        new Pytanie { tresc = "Na ile problemy rozpoznane podczas poprzedniego sprawdzenia są rozwiązane?", idKroku = 21 },

                        new Pytanie { tresc = "Czy odbywają się regularne spotkania zespołu w obszarze?", idKroku = 22 },
                        new Pytanie { tresc = "Czy akcje ze spotkań są realizowane? (patrz aplikacje Problem Solving)", idKroku = 22 },

                        new Pytanie { tresc = "Czy istnieje sformalizowany system wykorzystywania pomysłów pracowników do doskonalenia swojej pracy (patrz aplikacje Kaizen)?", idKroku = 23 },
                        new Pytanie { tresc = "Do jakiego stopnia na obszarze funkcjonuje zgłaszanie pomysłów (patrz aplikacje Kreatywności)?", idKroku = 23 },

                        new Pytanie { tresc = "Na ile informacje są regularnie uaktualniane?", idKroku = 24 },

                        new Pytanie { tresc = "Na ile otoczenie cyfrowe, wirtualne inspiruje pracownika do kreatywności, działania?", idKroku = 25 },
                        new Pytanie { tresc = "W jakim stopniu otoczenie cyfrowe, wirtualne jest proste w obsłudze i pomaga przy codziennych zadaniach?", idKroku = 25 },
                        new Pytanie { tresc = "Czy osoby z działu/ów IT reagują szybko i wspierają wiedzą oraz działaniami ten obszar?", idKroku = 25 },
                        new Pytanie { tresc = "Jak szybko wprowadzane są aktualizacje oprogramowania, aplikacji, systemów?", idKroku = 25 },

                        new Pytanie { tresc = "Czy drogi komunikacyjne nie są zastawione?", idKroku = 26 },
                        new Pytanie { tresc = "Czy drogi komunikacyjne nie są śliskie (woda, chemia)?", idKroku = 26 },
                        new Pytanie { tresc = "Czy pracownicy na obszarze są prawidłowo ubrani?", idKroku = 26 },
                        new Pytanie { tresc = "Czy pracownicy stosują wymagane środki ochrony indywidualnej odpowiednie do wykonywanej pracy?", idKroku = 26 },
                        new Pytanie { tresc = "Czy apteczki pierwszej pomocy są prawidłowo opisane, zgodne co do zawartości i rozmieszczone w odpowiednich miejscach?", idKroku = 26 },
                        new Pytanie { tresc = "Czy jest wyznaczona i przeszkolona osoba do udzielania pierwszej pomocy?", idKroku = 26 },

                        new Pytanie { tresc = "W jakim stopniu dane na urządzeniach cyfrowych, wirtualnych są odpowiednio zabezpieczone?", idKroku = 27 },
                        new Pytanie { tresc = "Czy ryzyko utraty loginu, hasła zostały przedyskutowane i przećwiczone?", idKroku = 27 },
                        new Pytanie { tresc = "W jakim stopniu loginy i hasła są przechowywane bezpiecznie?", idKroku = 27 },

                        new Pytanie { tresc = "Czy działa oświetlenie?", idKroku = 28 },
                        new Pytanie { tresc = "Czy działa wentylacja?", idKroku = 28 },
                        new Pytanie { tresc = "Czy siedziska są prawidłowe?", idKroku = 28 },
                        new Pytanie { tresc = "Czy stoły są ustawione prawidłowo?", idKroku = 28 },
                        new Pytanie { tresc = "Czy prawidłowo zabezpieczone i oznakowane są miejsca niebezpieczne, o podwyższonym ryzyku?", idKroku = 28 },

                        new Pytanie { tresc = "Czy eksploatowane narzędzia i urządzenia są kompletne?", idKroku = 29 },
                        new Pytanie { tresc = "Czy eksploatowany sprzęt jest sprawny?", idKroku = 29 },
                        new Pytanie { tresc = "Czy są na stanowisku wymagane instrukcje stanowiskowe bezpieczeństwa?", idKroku = 29 },
                        new Pytanie { tresc = "Czy na każdym urządzeniu znajdują się zabezpieczenia i osłony zapobiegające wypadkom?", idKroku = 29 },
                        new Pytanie { tresc = "Czy są i czy są sprawne wyłączniki bezpieczeństwa?", idKroku = 29 },
                        new Pytanie { tresc = "Czy urządzenia mają aktualny przegląd?", idKroku = 29 },

                        new Pytanie { tresc = "Czy sprzęt p.poż. znajduje się na swoim miejscu i nie jest zastawiony?", idKroku = 30 },
                        new Pytanie { tresc = "Czy wyjścia ewakuacyjne są otwarte i czy znajduje się obok skrzynka z kluczem?", idKroku = 30 },
                        new Pytanie { tresc = "Czy nie brakuje gdzieś oznakowania p.poż.?", idKroku = 30 },
                        new Pytanie { tresc = "Czy sposób wykonywania prac niebezpiecznych nie powoduje zagrożenia pożarowego?", idKroku = 30 },
                        new Pytanie { tresc = "Czy są drożne drogi i wyjścia ewakuacyjne?", idKroku = 30 },
                    };

                    _db.Pytania.AddRange(pytania);
                    _db.SaveChanges();
                }

                // Seed Odpowiedzi
                if (!_db.Odpowiedzi.Any())
                {
                    var odpowiedzi = new[]
                    {
                        "0%",
                        "40%",
                        "70%",
                        "90%",
                        "100%",
                        "nie dotyczy"
                    };

                    var pytania = _db.Pytania.ToList();

                    foreach (var pytanie in pytania)
                    {
                        foreach (var trescOdpowiedzi in odpowiedzi)
                        {
                            _db.Odpowiedzi.Add(new Odpowiedz { tresc = trescOdpowiedzi, idPytania = pytanie.idPytania });
                        }
                    }

                    _db.SaveChanges();
                }
            }
        }
    }
}