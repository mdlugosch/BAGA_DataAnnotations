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
    public class Person
    {
        public Person()
        {
            Address = new Address();
            Info = new PersonalInfo
            {
                Weight = new Measurement(),
                Height = new Measurement()
            };
        }

        /*
         * Der Primärschlüssel ist in dieser Klasse ein Integer. EF lässt diese
         * über die Datenbank automatisch beschreiben. Werte die für den Primärschlüssel
         * in einem neuen Datensatz zugewiesen werden werden daher von EF ignoriert. Soll
         * dies nicht so sein dann muss der Primärschlüssel auf die DatabaseGeneratedOption
         * "none" eingestellt werden damit die zuweisung vom Programmierer übernommen werden
         * kann/ muss.
         */
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int SocialSecurityNumber { get; set; }
        [Key]
        public int PersonId { get; set; }
        [ConcurrencyCheck]
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public PersonalInfo Info { get; set; }

        public List<Lodging> PrimaryContactFor { get; set; }
        public List<Lodging> SecondaryContactFor { get; set; }
        [Required]
        public PersonPhoto Photo { get; set; }
    }
}
