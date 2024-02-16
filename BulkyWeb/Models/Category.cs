using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        //These are the columns in our category table
        //This is a data annotation for a primary key
        [Key]
        public int Id { get; set; }
        [Required] //This data annotation means required field
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
