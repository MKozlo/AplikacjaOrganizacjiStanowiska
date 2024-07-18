using Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Entities;
using Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Pytanie(int pozycjaIndex = 1, int krokIndex = 1, int pytanieIndex = 1)
        {
            var pytanie = _appDbContext.Pytania
                .Where(p => p.Krok.idKroku == krokIndex)
                .Skip(Math.Max(0, pytanieIndex - 1))
                .FirstOrDefault();

            if (pytanie == null)
            {
                var nextKrok = _appDbContext.Kroki
                    .Where(k => k.idPozycji == pozycjaIndex && k.idKroku > krokIndex)
                    .OrderBy(k => k.idKroku)
                    .FirstOrDefault();

                if (nextKrok == null)
                {
                    var nextPozycja = _appDbContext.Pozycje
                        .Where(p => p.idPozycji > pozycjaIndex)
                        .OrderBy(p => p.idPozycji)
                        .FirstOrDefault();

                    if (nextPozycja != null)
                    {
                        pozycjaIndex = nextPozycja.idPozycji;
                        krokIndex = _appDbContext.Kroki
                            .Where(k => k.idPozycji == pozycjaIndex)
                            .OrderBy(k => k.idKroku)
                            .Select(k => k.idKroku)
                            .FirstOrDefault();
                        pytanieIndex = 1;
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    krokIndex = nextKrok.idKroku;
                    pytanieIndex = 1;
                }

                pytanie = _appDbContext.Pytania
                    .Where(p => p.Krok.idKroku == krokIndex)
                    .Skip(Math.Max(0, pytanieIndex - 1))
                    .FirstOrDefault();
            }

            var krok = _appDbContext.Kroki
                .FirstOrDefault(k => k.idKroku == krokIndex);
            var pozycja = _appDbContext.Pozycje
                .FirstOrDefault(p => p.idPozycji == pozycjaIndex);

            if (krok == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var viewModel = new QuestionViewModel
            {
                Position = pozycjaIndex,
                PositionContent = pozycja?.nazwa ?? "",
                Step = krokIndex,
                StepContent = krok?.tresc ?? "",
                Question = pytanieIndex,
                QuestionContent = pytanie?.tresc ?? "",
                Answers = pytanie != null ? _appDbContext.Odpowiedzi
                    .Where(o => o.idPytania == pytanie.idPytania)
                    .Select(a => new AnswerViewModel
                    {
                        Id = a.idOdpowiedzi,
                        Content = a.tresc
                    })
                    .ToList() : new List<AnswerViewModel>(),
                HasPrevious = pytanieIndex > 1 || krokIndex > 1 || pozycjaIndex > 1
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
