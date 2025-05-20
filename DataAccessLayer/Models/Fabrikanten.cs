using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Fabrikant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }
    }
}
