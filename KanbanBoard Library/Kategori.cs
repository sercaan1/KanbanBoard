using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard_Library
{
    public class Kategori
    {
        public Kategori()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public string Baslik { get; set; }
        public Color Colour { get; set; }
        public override string ToString()
        {
            return Baslik;
        }
    }
}
