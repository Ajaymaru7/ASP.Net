using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace G_Prg_Book.Models
{
    public class Book
    {
        public int BookID { get; set; }
        [Required(ErrorMessage = "Book Title is required.")]
        public string BookTitle { get; set; }
        [Required(ErrorMessage = "Book Authors is required.")]
        public string BookAuthors { get; set; }
        [Required(ErrorMessage = "Publisher Name is required.")]
        public string PublisherName { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "ISDN No. is required.")]
        public string ISDN { get; set; }
    }
}