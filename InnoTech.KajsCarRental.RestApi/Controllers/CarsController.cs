using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InnoTech.CarRental.Core.ApplicationService;
using InnoTech.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InnoTech.KajsCarRental.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            return _carService.GetCars();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Car> Get(int id)
        {
            return _carService.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Car> Post([FromBody] Car car)
        {
            car.Id = 0;
            return _carService.AddCar(car);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Car> Delete(int id)
        {
             _carService.DeleteCar(id);
            return Ok("Det virkede bare!");
        }
    }
}
