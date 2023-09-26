using System.ComponentModel.DataAnnotations;

namespace ProjectJMM.Models
{
    public class Item 
    {
        [Key]
        public int Id { get; set; }
        public string Borrow { get; set; }
        public string lender { get; set; }
        public string ItemName { get; set; }


    }
}
