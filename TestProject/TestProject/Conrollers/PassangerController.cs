using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProject.Shared.Entity;
using TestProject.Shared.Services;

namespace TestProject.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassangerController : ControllerBase
    {
        private readonly IPassnagerServices _PassnagerService;
        public PassangerController(IPassnagerServices passnagerServices)
        {
            _PassnagerService = passnagerServices;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Passanger>> GetpassangerById(int Id)
        {
            var passanger = await _PassnagerService.GetPassnagerById(Id);
            return Ok(passanger);
        }

        [HttpPost]
        public async Task<ActionResult<Passanger>> AddGames(Passanger passanger) 
        {
        var AddedPassanger = await _PassnagerService.AddPassnager(passanger);
            return Ok(AddedPassanger);
        }
        [HttpPut]
        public async Task<ActionResult<Passanger>> EditPassanger(int id , Passanger passanger)
        {
            var UpdatePassanger = await _PassnagerService.EditPassnager(id , passanger);
            return Ok(UpdatePassanger);
        }
        [HttpDelete ("{id}")]
        public async Task<ActionResult<Passanger>> DeletePassanger(int id )
        {
            var DeletePassanger = await _PassnagerService.DeletePassanger(id);
            return Ok(DeletePassanger);
        }

    }
}
