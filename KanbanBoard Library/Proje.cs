using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard_Library
{
    public class Proje
    {
        public Proje()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public string Baslik { get; set; }
        public List<Not> notlar { get; set; } = new List<Not>();
        public DateTime CreationTime { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public void NotuToDoYap(Guid id)
        {
            Not not = notlar.FirstOrDefault(x => x.Id == id);
            not.NotDurum = EnumNotDurum.ToDo;
        }
        public void NotuDoinYap(Guid id)
        {
            Not not = notlar.FirstOrDefault(x => x.Id == id);
            not.NotDurum = EnumNotDurum.Doin;
        }
        public void NotuDoneYap(Guid id)
        {
            Not not = notlar.FirstOrDefault(x => x.Id == id);
            not.NotDurum = EnumNotDurum.Done;
        }
    }
}
