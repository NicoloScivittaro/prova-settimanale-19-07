using Microsoft.AspNetCore.Mvc;
using PoliziaMunicipaleApp.Models;
using System.Linq;

namespace PoliziaMunicipaleApp.Controllers
{
    public class VerbaleController : Controller
    {
        private readonly PoliziaMunicipaleContext _context;

        // Costruttore del controller
        public VerbaleController(PoliziaMunicipaleContext context)
        {
            _context = context;
        }

        // Azione per visualizzare il form di creazione
        public IActionResult Create()
        {
            var viewModel = new VerbaleViewModel
            {
                Anagrafica = _context.Anagrafica.ToList(),
                TipoViolazione = _context.TipoViolazione.ToList(),
                Verbale = new Verbale() 
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VerbaleViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Verbale.Add(viewModel.Verbale); 
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            viewModel.Anagrafica = _context.Anagrafica.ToList();
            viewModel.TipoViolazione = _context.TipoViolazione.ToList();
            return View(viewModel);
        }

        public IActionResult Index()
        {
            var verbali = _context.Verbale.ToList();
            return View(verbali);
        }
    }
}