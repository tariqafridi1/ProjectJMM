using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjectJMM.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expanse")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        public int Amount { get; set;}
    }
}
