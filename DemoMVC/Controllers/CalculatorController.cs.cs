using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator model)
        {
            switch (model.Operation)
            {
                case "Add":
                    model.Result = model.Number1 + model.Number2;
                    break;
                case "Sub":
                    model.Result = model.Number1 - model.Number2;
                    break;
                case "Mul":
                    model.Result = model.Number1 * model.Number2;
                    break;
                case "Div":
                    model.Result = model.Number2 != 0 ? model.Number1 / model.Number2 : double.NaN;
                    break;
            }

            ViewBag.Result = model.Result;
            return View(model);
        }
    }
}
