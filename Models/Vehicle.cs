using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WypozyczalniaPojazdowElektrycznych3.Models
{
    [Table("Vehicles")]
    public class Vehicle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public string Color { get; set; }

        [DataType(DataType.Date)]
        public DateTime? RentTermin { get; set; }

    }
}
