using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }  // Primary key of the table
        [Required]
        public string Name { get; set; } // Category name
        public int DisplayOrder { get; set; }


    }
}
