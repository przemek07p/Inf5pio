﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.entities
{
    public class Car : IVehicleBase
    {
        [Key]
        public int VehicleId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public ICollection<Access> Accesses { get; set; }

        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
