using ConversionMoneda.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ConversionMoneda.Controllers
{
    public class HomeController : Controller
	{
		//pesos- cantidad
		//conversion-resultado
		//moneda -tipo
		public IActionResult Index(IndexViewModel vm)
		{
			if(vm.Moneda == "mx")
			{
				vm.conversion = vm.pesos / 18m;
			}
			else if(vm.Moneda == "us")
			{
				vm.conversion = vm.pesos * 18m;
			}
			return View(vm);
		}
	}
}
