using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http;
using RoomEase.Data;
using RoomEase.Models;

namespace RoomEase.Controllers

{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChoresController : ControllerBase
    {

        private readonly ApiContext _context;

        public ChoresController(ApiContext context)

        {
            _context = context;

        }
        //Crete/Edit

        [HttpPost]
        public JsonResult CreateEdit(ChoresList chores)
        {
            if (chores.ChoreId == 0)
            {
                _context.Chores.Add(chores);
            }
            else
            {
                var choresInDb = _context.Chores.Find(chores.ChoreId);

                if (choresInDb == null)
                    return new JsonResult(NotFound());

                choresInDb = chores;

            }

            _context.SaveChanges();

            return new JsonResult(Ok(chores));


        }

        //Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result= _context.Chores.Find(id);
            if (result == null)
                return new JsonResult(NotFound());
            return new JsonResult(Ok(result));

        }
        
        //Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Chores.Find(id);
            if (result == null)
                return new JsonResult(NotFound());
            _context.Chores.Remove(result);
            _context.SaveChanges();
            return new JsonResult(NoContent());


        } 

        // Get all
        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context. Chores. ToList();
            return new JsonResult (Ok(result));
        }
        
    }
}