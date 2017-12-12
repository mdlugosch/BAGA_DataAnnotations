using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Trip
    {
        /*
         * Primärschlüssel lautet hier nicht Id oder zB. TripID daher erkennt
         * EF durch die Namensgebung nicht den Schlüssel. Dieser muss hier mit
         * der Annotation [Key] gesetzt werden um EF entsprechend zu konfigurieren.
         * Guids werden nicht wie Int-Keys automatisch zugewiesen. EF muss die
         * Datenbank benachrichten das diese dem Attribut automatisch einen Wert
         * zuweisen muss ansonsten wird das Guid Attribut immer mit Nullen initialisiert
         * was beim zweiten neuen Datensatz zu einem Abbruch mit Fehlermeldung führt.
         */
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Identifier { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal CostUSD { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
