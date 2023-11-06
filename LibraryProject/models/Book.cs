using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public Author? Author { get; set; }
        public Genre? Genre { get; set; }
        public DateTime PublishingYear { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int BooksCount { get; set; }

        public Book() { }

        public Book(string title,Author author,Genre genre,decimal price,int count) 
        {
            Title = title;
            Author = author;
            Genre = genre;
            Price = price;
            BooksCount = count;
        }


    }
}
