using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard_Library
{
    [JsonObject]
    public class ProjeYoneticisi
    {
        [JsonProperty]
        private BindingList<Proje> projeler { get; set; } = new BindingList<Proje>();
        public void ProjeEkle(Proje proje)
        {
            projeler.Add(proje);
        }
        public void ProjeCikar(Proje proje)
        {
            projeler.Remove(proje);
        }
        public BindingList<Proje> ProjeleriGetir()
        {
            return projeler;
        }
        public bool ProjeVarMi(Proje proje)
        {
            proje = projeler.FirstOrDefault(x => x.Id == proje.Id);
            return proje == null ? false : true;
        }
    }
}
