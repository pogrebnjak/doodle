using System.Collections.Generic;
using System.Web.Mvc;
using Calculator.TwoArguments;


namespace CalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        private List<SelectListItem> operations = new List<SelectListItem>()
        {
            new SelectListItem()
            {
                Text = "+", Value = "Add"
            },
            new SelectListItem()
            {
            Text = "-", Value = "Substraction"
        },
            new SelectListItem()
            {
                Text = "*", Value = "Multiply"
            },
            new SelectListItem()
            {
                Text = "/", Value = "Division"
            },
           
            new SelectListItem()
            {
                Text = "x^y", Value = "Powerxy"
            }
            };
        [HttpPost]
        public ActionResult Index(double firstNumber, double secondNumber, string operation)
        {
            ICalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            ViewBag.result = calculator.Calculate(firstNumber, secondNumber);
            ViewBag.operations = operations;
            return View();
        }

        public ActionResult Index()
        {

            ViewBag.operations = operations;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}