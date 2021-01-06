using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WypozyczalniaPojazdowElektrycznych3.Models
{
    [Table("Models")]
    public class Model
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
       
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
