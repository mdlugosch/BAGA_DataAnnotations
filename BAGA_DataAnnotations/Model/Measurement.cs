using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [ComplexType]
    public class Measurement
    {
        public decimal Reading { get; set; }
        public string Units { get; set; }
    }
}
