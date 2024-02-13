using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProject.Shared.Entity;
using TestProject.Shared.Services;

namespace TestProject.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverServices _driverServices;
        public DriverController(IDriverServices DriverServices)
        {
              _driverServices = DriverServices;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Driver>> GetGameById(int Id)
        {
            var driver = await _driverServices.GetDriverById(Id);
            return Ok(driver);
        }

        [HttpPost]
        public async Task<ActionResult<Driver>> AddGames(Driver driver) 
        {
        var AddedDriver = await _driverServices.AddDriver(driver);
            return Ok(AddedDriver);
        }
        [HttpPut]
        public async Task<ActionResult<Driver>> EditDriver(int id , Driver driver)
        {
            var UpdateDriver = await _driverServices.EditDriver(id , driver);
            return Ok(UpdateDriver);
        }
        [HttpDelete ("{id}")]
        public async Task<ActionResult<Driver>> DeleteDriver(int id )
        {
            var DeleteDriver = await _driverServices.DeleteDriver(id);
            return Ok(DeleteDriver);
        }

    }
}
