using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("People")]
    public class PersonPhoto
    {
        [Key]
        [ForeignKey("PhotoOf")]
        public int PersonId { get; set; }
        [Column(TypeName ="image")]
        public byte[] Photo { get; set; }
        public string Caption { get; set; }
        [Required]
        public Person PhotoOf { get; set; }
    }
}
