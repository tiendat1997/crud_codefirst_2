using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace crud_codefirst_2.Models
{    
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]        
        public string Title { get; set; }

        [Required]
        public string Authors { get; set; }

        [Column("PublishYear")]
        [Display(Name = "Publish Year")]
        public string PublishYear { get; set; }

        [Column("Price")]
        [Display(Name = "Price")]
        public double BasePrice { get; set; }
    }
}