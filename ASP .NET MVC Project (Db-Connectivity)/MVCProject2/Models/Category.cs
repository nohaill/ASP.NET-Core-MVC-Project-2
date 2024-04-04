using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCProject2.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        [Required]
        [DisplayName("Name")]
        public string name { get; set; }

        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
