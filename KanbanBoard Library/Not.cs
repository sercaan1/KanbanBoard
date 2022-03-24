using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard_Library
{
    public class Not
    {
        public Not()
        {
            Id = Guid.NewGuid();
            NotDurum = EnumNotDurum.ToDo;
        }
        public Guid Id { get; set; }
        public string Icerik { get; set; }
        public Kategori Kategori { get; set; }
        public DateTime CreationTime { get; set; }
        public EnumNotDurum NotDurum { get; set; }
    }
}
