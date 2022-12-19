using BusinessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonelController : Controller
    {
        public IPersonelService personalService;

        public PersonelController(IPersonelService personalService)
        {
            this.personalService = personalService;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var personelgetir = personalService.GetAll();
            return View(personelgetir);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Personel pers)
        {
            personalService.AddPersonel(pers);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var personelGetir = personalService.getPersonelByID(id);
            return View(personelGetir);
        }
        [HttpPost]
        public IActionResult Update(Personel pers)
        {
            personalService.UpdatePersonel(pers);
            return RedirectToAction("GetAll");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
