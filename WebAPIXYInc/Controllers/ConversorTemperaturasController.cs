using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIXYInc.Entidades;

namespace WebAPIXYInc.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    public class ConversorTemperaturasController : Controller
    {
        /// <summary>
        /// Transforma uma temperatura em Fahrenheit para o equivalente nas escalas Celsius e Kelvin.
        /// </summary>
        /// <param name="temperatura">Temperatura em Fahrenheit</param>
        /// <returns>Objeto contendo valores para uma temperatura nas escalas Fahrenheit, Celsius e Kelvin.</returns>
        [HttpGet("Fahrenheit/{temperatura}")]
        public Temperatura GetConversaoFahrenheit(double temperatura)
        {
            var dados = new Temperatura();
            dados.ValorFahrenheit = temperatura;
            dados.ValorCelsius = Math.Round((temperatura - 32.0) / 1.8, 2);
            dados.ValorKelvin = dados.ValorCelsius + 273.15;

            return dados;
        }
    }
}
