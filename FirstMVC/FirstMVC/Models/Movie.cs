using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        public string? Title { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Дата релиза")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Жанр")]
        public string? Genre { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }
    }
}
