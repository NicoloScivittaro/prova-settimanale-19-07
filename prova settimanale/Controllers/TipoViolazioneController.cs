using Microsoft.AspNetCore.Mvc;
using PoliziaMunicipaleApp.Models;
using System.Linq;

namespace PoliziaMunicipaleApp.Controllers
{
    public class TipoViolazioneController : Controller
    {
        private readonly PoliziaMunicipaleContext _context;

        public TipoViolazioneController(PoliziaMunicipaleContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var tipoViolazioni = _context.TipoViolazione.ToList();
            return View(tipoViolazioni);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Descrizione")] TipoViolazione tipoViolazione)
        {
            if (ModelState.IsValid)
            {
                _context.TipoViolazione.Add(tipoViolazione);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoViolazione);
        }
    }
}
