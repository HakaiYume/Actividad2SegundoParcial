using System.Collections;
using Microsoft.AspNetCore.Mvc;
using alcoholemia.Application;
using System.Collections.Generic;

/* 
    Universidad Tecnológica Metropolitana
    Aplicaciones Web Orientadas a Objetos
    Docente: Chuc Uc Joel Ivan
    Actividad: alcoholemia
    Alumno: Daniel Francisco Puch Ceballos
    Cuatrimestre: 4
    Parcial: 2
    Grupo: A
*/

namespace alcoholemia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class alcoholemiaController : ControllerBase
    {
        [HttpPost]
        [Route("Calcular/")]
        public string calcular(string bebida, int cantidad, double peso)
        {
            var services = new Services();
            var result = services.calcular_alcoholemia(bebida, cantidad, peso);
            return result;
        }
    }
}