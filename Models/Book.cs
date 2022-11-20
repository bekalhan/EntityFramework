using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace EFCore.Models
{
	public class Book
	{
        [Key]
        public int BookId { get; set; }

        [Required]
        [Display(Name = "Book Name")]
        [MaxLength(12, ErrorMessage = "Book name must not be more than 12 character")]
        public String BookName { get; set; }


        public int AuthorId { get; set; }

        [ValidateNever]
        public Author Author { get; set; }
    }
}

