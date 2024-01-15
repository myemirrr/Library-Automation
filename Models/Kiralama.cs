using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Kiralama
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "Öğrenci Numarası")]
        [Required]
        public int OgrenciId { get; set; }


        [ValidateNever]
		[Display(Name = "Kitap Adı ")]
		public int KitapId { get; set; }

        [ForeignKey("KitapId")]
        [ValidateNever]
        public Kitap Kitap { get; set; }



    }
}
