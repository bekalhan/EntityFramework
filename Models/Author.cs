using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
	public class Author
	{
        [Key]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Please provide a author name")]
        public String AuthorName { get; set; }

        [Required(ErrorMessage = "Please provide a author surname")]
        public String AuthorSurname { get; set; }

        [ValidateNever]
        public ICollection<Book> Books { get; set; }
    }
}

