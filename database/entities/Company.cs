using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.entities
{
    public class Company : ICompanyBase
    {
        [Key]
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int VatId { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
