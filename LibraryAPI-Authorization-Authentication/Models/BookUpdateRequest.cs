using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models
{
    public class BookUpdateRequest
    {
        [Required]
        [RegularExpression("title|author|publicationYear|isbn", ErrorMessage = "Field must be one of: title, author, publicationYear, isbn")]
        public string Field { get; set; } = string.Empty;

        [Required]
        public object Value { get; set; } = null!;
    }
}