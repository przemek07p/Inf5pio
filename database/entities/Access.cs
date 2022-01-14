using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.entities
{
    public class Access : IAccessBase
    {
        [Key]
        public int AccessId { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
