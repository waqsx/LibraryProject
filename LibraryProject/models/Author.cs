using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.models
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? LastName { get; set; }
        
        public List<Book>? Books { get; set; }

        public Author() { }
        public Author(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        public Author(Book book)
        {
            Books.Add(book);
        }

        public override string ToString()
        {
            return $"name: {Name} lastName: {LastName} id: {Id}";
        }
    }

   



}
