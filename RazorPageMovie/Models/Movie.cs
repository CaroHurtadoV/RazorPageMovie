using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        //El simbolo ? se utiliza para indicar que el dato puede ir nulo
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        //Las etiquetas se utilizan para dar un formato especifico al tipo de dato que se solicita
        [Display(Name = "Realese Date")]
        [DataType(DataType.Date)]
        public DateTime RealeseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; } = string.Empty;

    }
}
