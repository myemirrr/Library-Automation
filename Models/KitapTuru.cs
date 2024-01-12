using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class KitapTuru
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        public string Ad { get; set; }


    }
}
