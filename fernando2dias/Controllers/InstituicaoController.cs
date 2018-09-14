using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fernando2dias.Models;


namespace fernando2dias.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes = new List<Instituicao>()
        {
            new Instituicao(){InstituicaoID =1, Nome = "UniParaná", Endereco = "Paraná" },
            new Instituicao(){InstituicaoID =2, Nome = "UniSanta", Endereco = "Santa Catarina" },
            new Instituicao(){InstituicaoID =3, Nome = "UniSãoPaulo", Endereco = "São Paulo" },
            new Instituicao(){InstituicaoID =4, Nome = "UniRJ", Endereco = "Rio de Janeiro" },
            new Instituicao(){InstituicaoID =5, Nome = "UniRS", Endereco = "Rio Grande do Sul" }
        };

        public IActionResult Index()
        {
            return View(instituicoes);
        }
    }
}