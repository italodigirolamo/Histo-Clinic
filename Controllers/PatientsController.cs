using Histo_Clinic.Data;
using Histo_Clinic.Models;
using Microsoft.AspNetCore.Mvc;

namespace Histo_Clinic.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PatientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Patiens> List_patiens = _context.Patiens.ToList();
            return View(List_patiens);
        }
    }
}
