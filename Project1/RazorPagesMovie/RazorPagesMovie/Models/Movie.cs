using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        //标题
        [StringLength(60, MinimumLength = 3)]//限制标题长度
        [Required]
        public string Title { get; set; } = string.Empty;

        //发行日期
        //[Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        //价格
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        //类别
        [RegularExpression(@"^[A-Z]+[a-zA-z\s]*$")]
        [Required]
        [StringLength(30)]
        [Column(TypeName = "demical(18,2)")]
        public string? Genre { get; set; } = string.Empty;

        //分级
        [RegularExpression(@"^[A-Z]+[a-zA-z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        [Column(TypeName = "demical(18,2)")]
      
        public string Rating { get; set; } = string.Empty;
    }
}
