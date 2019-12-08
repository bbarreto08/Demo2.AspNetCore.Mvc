using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.AspNetCore.Mvc.Data;
using Demo.AspNetCore.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.AspNetCore.Mvc.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext context)
        {
            _contexto = context;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Teste",
                DataNascimento = DateTime.Now,
                Email = "email@email.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a=>a.Email == "email@email.com");
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "Teste");

            aluno.Nome = "Teste 2";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}