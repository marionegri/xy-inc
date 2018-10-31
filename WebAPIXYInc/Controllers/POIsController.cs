using System;
using System.Collections.Generic;
using Business;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Model.Request;
using Model.Response;

namespace WebAPIXYInc.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [EnableCors("Policy")]
    public class POIsController : Controller
    {
        private readonly Service _services;

        public POIsController(Service services)
        {
            _services = services;
        }

        /// <summary>
        ///  Listar todos os POIs cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet("pois")]
        public List<POI> GetAll()
        {
            try
            {
                var result = _services.GetAll();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cadastrar pontos de interesse POIs
        /// </summary>
        /// <param name="poi"></param>
        /// <returns></returns>
        [HttpPost("pois")]
        public POI Create([FromBody]CreatePOI poi)
        {
            try
            {
                var entity = _services.Create(poi);

                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retornar todos os POIs que estejam a uma distância menor ou igual a d-max 
        /// a partir do ponto de referência
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet("pois/dmax")]
        public List<POI> GetByDMax([FromQuery]GetByDMax request)
        {
            try
            {
                var result = _services.GetByDMax(request);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
