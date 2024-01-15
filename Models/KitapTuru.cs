using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class KitapTuru
    {
        [Key]
        [DisplayName("Kitap Türü Numara")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Bu alan boş bırakılamaz!")]
        [DisplayName("Kitap Türü Adı")]
        [MaxLength(20)]
        public string Ad { get; set; }


    }
}
