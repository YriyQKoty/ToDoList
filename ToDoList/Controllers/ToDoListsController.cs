using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Interfaces;


namespace ToDoList.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ToDoListsController : ControllerBase
    {
        private IToDoListService _service;

        public ToDoListsController(IToDoListService service)
        {
            _service = service;
        }

        [HttpGet("{id:min(1)}")]
        public async Task<IActionResult> GetListById([FromRoute] int id)
        {
            var result = await _service.GetList(id);
            if (!result.Succeeded)
            {
                return  NotFound("There is no list with such ID!");
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllLists()
        {
            var result = await _service.GetAllLists();
            if (!result.Succeeded)
            {
                return NotFound("Oops, there is no available lists!");
            }
        
            return Ok(result);
        }
        
    }
}