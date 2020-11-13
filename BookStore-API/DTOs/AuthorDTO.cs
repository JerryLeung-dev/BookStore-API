using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.DTOs
{
    /// <summary>
    /// DTO and Data class do not directly interact
    /// </summary>
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Bio { get; set; }

        public virtual IList<BookDTO> Books { get; set; }
    }

    public class AuthorCreateDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Bio { get; set; }
    }

    public class AuthorUpdateDTO
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Bio { get; set; }
    }
}
