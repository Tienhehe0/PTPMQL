using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMI model)
        {
            if (model.Height > 0)
            {
                model.Result = model.Weight / (model.Height * model.Height);

                if (model.Result < 18.5)
                    model.Status = "Gầy";
                else if (model.Result < 24.9)
                    model.Status = "Bình thường";
                else if (model.Result < 29.9)
                    model.Status = "Thừa cân";
                else
                    model.Status = "Béo phì";
            }
            else
            {
                model.Result = 0;
                model.Status = "Chiều cao không hợp lệ";
            }

            ViewBag.Result = model.Result;
            ViewBag.Status = model.Status;
            return View(model);
        }
    }
}
