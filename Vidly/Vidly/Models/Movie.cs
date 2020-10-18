using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }
        [Required] public int GenreId { get; set; }
        [Required] public DateTime ReleaseDate { get; set; }
        [Required] public DateTime AddedDate { get; set; }
        [Required] public int NumberInStock { get; set; }
    }
}