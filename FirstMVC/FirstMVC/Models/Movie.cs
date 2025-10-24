using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Display(Name = "Название")]
        [StringLength(150)]
        [MaxLength(150)]
        public string? Title { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Дата релиза")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Жанр")]
        [StringLength(10)]
        [MaxLength(10)]
        public string? Genre { get; set; }

        [Display(Name = "Цена")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(16, 2)")]
        public decimal Price { get; set; }


        [Display(Name = "Рейтинг")]
        [Range(1,10,ErrorMessage = "Рейтинг от 1 до 10")]
        [Required(ErrorMessage = "Введите рейтинг")]
        public int? Rating { get; set; }
    }
}
