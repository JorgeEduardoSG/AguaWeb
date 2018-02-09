using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agua.Models;

namespace Agua.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Calcular(DateTime ProximoCumple, int minutos)
        {
            /// Aquí tienen que hacer todo
            /// La fecha que y los minutos vienen del formulario 
            /// Investigar Model Binding 
            /// int NB = 12, Faltantes, B;
        int NB=12, B, Faltantes;
         DateTime LoL = DateTime.Today;
         TimeSpan P = ProximoCumple - LoL;
         int fecha = P.Days;
         Faltantes = NB* minutos;
         B = Faltantes * fecha; 


            ViewBag.Dias =  fecha;
            ViewBag.Botellas = B;


            return View();
        }

    }
}
