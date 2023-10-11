using System.ComponentModel.DataAnnotations;

namespace RoomEase.Models
{
    public class ChoresList
    {
        [Key]
        public int ChoreId { get; set; }
        public string ChoreName { get; set; }
        public string CreatedBy { get; set; }
        
        public ChoresList()
        {

        }
    }
}