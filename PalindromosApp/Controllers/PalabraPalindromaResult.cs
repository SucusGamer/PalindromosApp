using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Nombre de la escuela: Universidad Tecnológica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Objetos
Nombre del Maestro:Joel Ivan Chuc Uc 
Nombre de la actividad: Ejercicio II.- Palindromos
Nombre del alumno: Guillermo Aldair Paredes Ayala
Cuatrimestre: 4
Grupo: B
Parcial: 1
*/

namespace PalindromosApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalabraPalindromaResult : ControllerBase
    {
        [HttpGet]
        public IActionResult PalindromoResultado(string guardar)
        {
            var P = new Palindromo();
            P.palindromo = guardar;

            var PalabraFinal = string.Empty;
            var PalabraContar = guardar;

            int i = PalabraContar.Length;

            var PalindrFinal = "";

            for (int j = i - 1; j >= 0; j--)
            {
                PalabraFinal = PalabraFinal + PalabraContar[j];
            }
            if (PalabraFinal.ToLower().Replace(" ", string.Empty) == PalabraContar.ToLower().Replace(" ", string.Empty))
            {
                PalindrFinal = (PalabraContar + " en efecto, es palindrome");
            }
            else
            {
                PalindrFinal = (PalabraContar + " no es palindrome");
            }
            int CountPalabras = PalabraContar.Length - PalabraContar.Replace(" ", string.Empty).Count() + 1;
            var ResultadoInvert = ("La palabra ingresada: " + PalindrFinal.ToLower() + " y su invertido es: " + PalabraFinal.ToLower() + ", el número de palabras es: " + CountPalabras);
            return Ok(ResultadoInvert.ToLower());

        }
    }
}
