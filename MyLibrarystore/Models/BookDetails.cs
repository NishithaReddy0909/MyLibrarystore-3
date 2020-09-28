using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrarystore.Models
{
    public class BookDetails
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Book Name")]
        public string BookName { get; set; }
        [Required]
        [Display(Name = "Author Name")]
        public string Author { get; set; }

        [Required]

        public string ISBN { get; set; }

        [Required]
        [Display(Name = "Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }

        [Required]

        public string Genre { get; set; }

    }
}
