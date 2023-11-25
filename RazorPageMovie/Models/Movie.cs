using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        //El simbolo ? se utiliza para indicar que el dato puede ir nulo
        public string? Title { get; set; }
        //Las etiquetas se utilizan para dar un formato especifico al tipo de dato que se solicita
        [DataType(DataType.Date)]
        public DateTime RealeseDate { get; set; }
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

    }
}
