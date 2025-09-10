using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index( int Number1,int Number2,string Operation )
        {
            Double result=0;
            switch (Operation)
            {
                case "Add":
                    result = Number1 + Number2;
                    break;
                case "Subtract":
                   result = Number1 - Number2;
                    break;
                case "Multiply":
                    result = Number1 * Number2;
                    break;
                case "Divide":
                    if (Number2 != 0)
                        result = Number1 /Number2;
                    else
                        ViewBag.Error = "Không thể chia cho 0!";
                    break;
                default:
                    ViewBag.Error = "Vui lòng chọn phép toán.";
                    break;
            }
            ViewBag.Result =$"Kết quả là :{result}";
            return View(result);
        }
    }
}
