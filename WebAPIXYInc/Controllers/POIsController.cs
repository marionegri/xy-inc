using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIXYInc.Entidades;
using WebAPIXYInc.Entidades.Request;

namespace WebAPIXYInc.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class POIsController : Controller
    {
        /// <summary>
        /// Retorna todos os POIs
        /// </summary>
        /// <returns></returns>
        [HttpGet("pois")]
        public List<POI> GetAll()
        {
            return new List<POI>();
        }

        /// <summary>
        /// Cadastra novos POIs
        /// </summary>
        /// <param name="poi"></param>
        /// <returns></returns>
        [HttpPost("pois")]
        public POI Create(CreatePOI poi)
        {
            return new POI();
        }

        /// <summary>
        /// Retornar todos os POIs que estejam a uma distância menor ou igual a d-max 
        /// a partir do ponto de referência
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("pois/dmax")]
        public List<POI> GetByDMax(RequestGetByDMax request)
        {
            return new List<POI>();
        }
    }
}
