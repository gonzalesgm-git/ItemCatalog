using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ItemAPI.Models;
using MediatR;
using Item.Application.Queries;
using Item.Application.Commands;


namespace ItemAPI.Controllers
{
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

        //// GET: api/Items/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Item.Domain.Models.Item>> GetItem(int id)
        //{
        //    var item = await _context.Items.FindAsync(id);

        //    if (item == null)
        //    {
        //        return NotFound();
        //    }

        //    return item;
        //}

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
            
            var res = _sender.Send(new DeleteItemCommand(id));
            return NoContent();
        }

    }
}
