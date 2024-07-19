using Microsoft.AspNetCore.Mvc;
using PoliziaMunicipaleApp.Models;
using System.Linq;

namespace PoliziaMunicipaleApp.Controllers
{
    public class AnagraficaController : Controller
    {
        private readonly PoliziaMunicipaleContext _context;

        public AnagraficaController(PoliziaMunicipaleContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Correct the property name here
            var anagrafiche = _context.Anagrafica.ToList();
            return View(anagrafiche);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Cognome,Nome,Indirizzo,Citta,CAP,Cod_Fisc")] Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                _context.Anagrafica.Add(anagrafica); // Use the correct DbSet property
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(anagrafica);
        }
    }
}
