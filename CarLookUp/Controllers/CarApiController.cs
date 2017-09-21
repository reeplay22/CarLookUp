using CarLookUp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarLookUp.Services;
using CarLookUp.Core;

namespace CarLookUp.Controllers
{
    public class CarApiController : ApiController
    {
        private ICarService _carService;

        public CarApiController(ICarService carService)
        {
            _carService = carService;
        }

        // DELETE: api/Car/5
        public void Delete(Guid id)
        {
            //HttpResponseMessage content = new HttpResponseMessage();
            //content.StatusCode = HttpStatusCode.OK;

            _carService.DeleteCar(id);
        }

        // GET: api/Car
        public IEnumerable<CarClass> Get()
        {
            return _carService.GetCars();
        }

        // GET: api/Car/5
        public CarClass Get(Guid id)
        {
            return _carService.GetCarById(id);
        }

        // POST: api/Car
        public void Post([FromBody]CarClass car)
        {
            _carService.CreateCar(car);
        }

        // PUT: api/Car/5
        public void Put(Guid id, [FromBody]CarClass value)
        {
            _carService.UpdateCar(id, value);
        }
    }
}
