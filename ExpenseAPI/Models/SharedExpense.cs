namespace ExpenseAPI.Models
{
    public class SharedExpense
    {

        public int ID { get; set; }
        public string ExpenseName { get; set; }
        public string ExpenseDescription { get; set; }
        public float ExpenseAmount { get; set; }
        public SharedExpense()
        {


        }
    }
}
