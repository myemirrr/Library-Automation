using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class KitapTuru
    {
        [Key]
        public int Id { get; set; }

        [Required] //not null 
        [DisplayName("Kitap Türü Adı")]
        [MaxLength(20)]
        public string Ad { get; set; }


    }
}
