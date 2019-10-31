using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NetCore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Display(Name="Book Name")]
        public string Name { get; set; }

        public string ISBN { get; set; }

        public string Author { get; set; }
    }
}