using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VendaPrancha.Models;

namespace VendaPrancha.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Aluno aluno = new Aluno();
            aluno.AlunoId = 1;
            aluno.Nome = "Rodrigo";
            aluno.Nota =7.5;

            Aluno aluno2 = new Aluno();
            aluno.AlunoId = 2;
            aluno.Nome = "Jessica";
            aluno.Nota = 9;

            Aluno aluno3 = new Aluno();
            aluno.AlunoId = 3;
            aluno.Nome = "Andrea";
            aluno.Nota = 9.5;

            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(aluno);
            alunos.Add(aluno2);
            alunos.Add(aluno3);

        ViewBag.Alunos = alunos;

            ViewBag.Disciplina = "Desenvolvimento de sistemas 2";
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
