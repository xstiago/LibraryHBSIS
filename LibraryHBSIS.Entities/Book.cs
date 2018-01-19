using System.ComponentModel.DataAnnotations;

namespace LibraryHBSIS.Entities
{
    public class Book
    {
        public int BookID { get; set; }

        [Required]
        [MaxLength(500)]
        public string Title { get; set; }

        [Required]
        [MaxLength(200)]
        public string Author { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string PublishingCompany { get; set; }
    }
}
