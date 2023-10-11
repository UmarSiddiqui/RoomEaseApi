using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http;
using RoomEase.Data;
using RoomEase.Models;


namespace RoomEase.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {

        private readonly ApiContext _context;
        public ExpenseController(ApiContext context)

        {
            _context = context;

        }
        //Crete/Edit

        [HttpPost]
        public JsonResult CreateEdit(SharedExpense expense)
        {
            if (expense.ExpenseId == 0)
            {
                _context.Expenses.Add(expense);
            }
            else
            {
                var expenseInDb = _context.Expenses.Find(expense.ExpenseId);

                if (expenseInDb == null)
                    return new JsonResult(NotFound());

                expenseInDb = expense;

            }

            _context.SaveChanges();

            return new JsonResult(Ok(expense));


        }

        //Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result= _context.Expenses.Find(id);
            if (result == null)
                return new JsonResult(NotFound());
            return new JsonResult(Ok(result));

        }
        
        //Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Expenses.Find(id);
            if (result == null)
                return new JsonResult(NotFound());
            _context.Expenses.Remove(result);
            _context.SaveChanges();
            return new JsonResult(NoContent());


        } 

        // Get all
        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context. Expenses. ToList();
            return new JsonResult (Ok(result));
        }
        
    }
}
