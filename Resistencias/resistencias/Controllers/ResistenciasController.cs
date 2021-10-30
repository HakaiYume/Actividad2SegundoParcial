using System.Collections;
using Microsoft.AspNetCore.Mvc;
using resistencias.Application;
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

namespace resistencias.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResistenciasController : ControllerBase
    {
        [HttpPost]
        [Route("Calcular/")]
        public string calcular(string banda1, string banda2, string banda3, string banda4)
        {
            var services = new Services();
            var result = services.calcular_alcoholemia(banda1, banda2, banda3, banda4);
            return result;
        }
    }
}