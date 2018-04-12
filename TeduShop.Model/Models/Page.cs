using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page :Auditable
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Column(TypeName ="varchar")]
        [Required]
        [MaxLength(250)]
        public string Alias { get; set; }
        public string Content { get; set; }
    }
}
