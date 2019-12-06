using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demo.AspNetCore.Mvc.Modulos.Produto.Controllers
{
    [Area("Produto")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Produtos/Busca")]
        public IActionResult Busca()
        {
            return View();
        }
    }
}