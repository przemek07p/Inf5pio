using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.entities
{
    public interface INoteBase
    {
        public int NoteId { get; set; }
        public string Type { get; set; }
        public DateTime Created { get; set; }
    }
}
