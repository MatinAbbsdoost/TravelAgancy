using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProject.Shared.Entity;
using TestProject.Shared.Services;

namespace TestProject.Conrollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdventureController : ControllerBase
    {
        private readonly IAdventureServices _adventureService;
        public AdventureController(IAdventureServices adventureServices)
        {
              _adventureService = adventureServices;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Adventure>> GetAdventureById(int Id)
        {
            var adventure = await _adventureService.GetAdventureById(Id);
            return Ok(adventure);
        }

        [HttpPost]
        public async Task<ActionResult<Adventure>> AddAdventure(Adventure adventure) 
        {
        var AddedAdventure = await _adventureService.AddAdventure(adventure);
            return Ok(AddedAdventure);
        }
        [HttpPut]
        public async Task<ActionResult<Adventure>> EditAdventure( Adventure adventure)
        {
            var UpdateAdventure = await _adventureService.EditAdventure(adventure);
            return Ok(UpdateAdventure);
        }
        [HttpDelete ("{id}")]
        public async Task<ActionResult<Adventure>> DeleteAdventure(int id )
        {
            var DeleteAdventure = await _adventureService.DeleteAdventures(id);
            return Ok(DeleteAdventure);
        }

    }
}
