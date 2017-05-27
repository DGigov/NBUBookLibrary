using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NbuBookLibrary.Models.BooksModels
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public decimal Price { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public virtual Author Author { get; set; }

    }
}