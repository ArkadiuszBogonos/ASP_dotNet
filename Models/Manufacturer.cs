using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WypozyczalniaPojazdowElektrycznych3.Models
{
    [Table("Manufacturers")]
    public class Manufacturer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}
