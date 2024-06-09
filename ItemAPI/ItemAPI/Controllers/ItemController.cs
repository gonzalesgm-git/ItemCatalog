using Item.Application.Commands;
using Item.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ItemAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        private readonly ISender _sender;
        public ItemController(ISender sender)
        {
           _sender = sender;
        }

        // GET: api/Items
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item.Domain.Models.Item>>> GetItems()
        {
            var items = await _sender.Send(new GetItemsQuery());
            return Ok(items);
        }

       
        //// PUT: api/Items/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, Item.Domain.Models.Item item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            var res = await _sender.Send(new UpdateItemCommand(item));
            return NoContent();
        }

        //// POST: api/Items
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Item.Domain.Models.Item>> PostItem(Item.Domain.Models.Item item)
        {
            var res = await _sender.Send(new SaveItemCommand(item));
            return Ok(res);
        }

        //// DELETE: api/Items/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            
            var res = await _sender.Send(new DeleteItemCommand(id));
            return NoContent();
        }

    }
}
