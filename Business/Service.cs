using Data.Models;
using Model.Request;
using Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class Service
    {
        private readonly XYIncContext _context;

        public Service(XYIncContext context)
        {
            _context = context;
        }

        public List<POI> GetAll()
        {
            try
            {
                var result = new List<POI>();

                result = _context.TbPoi.Select(x => new POI { Id = x.Id, Name = x.Name, CoordX = x.CoordX, CoordY = x.CoordY }).ToList();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public POI Create(CreatePOI obj)
        {
            try
            {
                var newObj = new TbPoi { Name = obj.Name, CoordX = obj.CoordX, CoordY = obj.CoordY };
                _context.TbPoi.Add(newObj);

                _context.SaveChanges();

                return new POI { Id = newObj.Id, Name = newObj.Name, CoordX = newObj.CoordX, CoordY = newObj.CoordY };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<POI> GetByDMax(GetByDMax request)
        {
            try
            {
                var result = new List<POI>();

                result = _context.TbPoi.Where(x => Math.Round(Math.Sqrt((Math.Pow((request.CoordX - x.CoordX), 2)) + (Math.Pow((request.CoordY - x.CoordY), 2)))) <= request.DMax)
                                        .Select(x => new POI
                                        {
                                            Id = x.Id,
                                            Name = x.Name,
                                            CoordX = x.CoordX,
                                            CoordY = x.CoordY
                                        }).ToList();
                
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
