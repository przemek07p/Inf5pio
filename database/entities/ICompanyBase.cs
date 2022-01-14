using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.entities
{
    public interface ICompanyBase
    {
        public int CompanyId { get; set; }
        public  string Name { get; set; }
        public string Address { get; set; }
        public int VatId { get; set; }

    }
}
