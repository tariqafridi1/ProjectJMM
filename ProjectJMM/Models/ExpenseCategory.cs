using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjectJMM.Models
{
    public class ExpenseCategory
    {
            [Key]
            public int Id { get; set; }
            [DisplayName("Category")]
            [Required]
            public string CategoryType { get; set; }
        
    }
}
