using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Kitap
    {
      [Key]
      [Display(Name = "Kitap Numarası")]
      public int Id { get; set; }
      [Required]
      [Display(Name = "Kitap Adı")]
      public string KitapAdi { get; set; }
      [Display(Name = "Kitap Tanım")]
      public string Tanim { get; set;}
      [Required]
      public string Yazar { get; set; }
      [Required]
      [Range(10,5000)]
      public double Fiyat { get; set; }
      [ValidateNever]
      [Display(Name = "Kitap Türü")]
      public int KitapTuruId { get; set; }
      [ForeignKey("KitapTuruId")]
      [ValidateNever]
      public KitapTuru KitapTuru { get; set; }
      [ValidateNever]
      [Display(Name ="Resim Kaynağı")]
      public string ResimUrl {  get; set; }    
    }
}
