using Business;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace XUnitTest
{
    public class POITest
    {
        private readonly Service _service;
        private DbContextOptions<XYIncContext> options = null;
        private XYIncContext context = null;

        public POITest()
        {
            options = new DbContextOptionsBuilder<XYIncContext>().Options;

            context = new XYIncContext(options);

            _service = new Service(context);
        }        

        [Fact]
        public void TestGetAll()
        {
            var result = _service.GetAll();

            Assert.True(result.Count > 0);
        }

        [Fact]
        public void TestCreate()
        {
            var result = _service.Create(new Model.Request.CreatePOI { CoordX = 10, CoordY = 5, Name = "Teste1" });

            Assert.True(result != null);
        }

        [Fact]
        public void TestGetByDMax()
        {
            var result = _service.GetByDMax(new Model.Request.GetByDMax { CoordX = 5, CoordY = 2, DMax = 20 });

            Assert.True(result.Count > 0);
        }
    }
}
