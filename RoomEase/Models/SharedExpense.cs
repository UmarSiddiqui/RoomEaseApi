using System.ComponentModel.DataAnnotations;

namespace RoomEase.Models
{
    public class SharedExpense
    {

        [Key]
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public string ExpenseDescription { get; set; }
        public float ExpenseAmount { get; set; }
        //public DateOnly ExpenseDate { get; set; }
        public SharedExpense()
        {


        }
    }
}
