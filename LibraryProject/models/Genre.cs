using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        
        public List<Book> Books { get; set; }
    }
}
