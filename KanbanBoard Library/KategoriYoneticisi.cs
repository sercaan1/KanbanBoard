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
    public class KategoriYoneticisi
    {
        [JsonProperty]
        private BindingList<Kategori> kategoriler { get; set; } = new BindingList<Kategori>();
        public void KategoriEkle(Kategori kategori)
        {
            kategoriler.Add(kategori);
        }
        public void KategoriCikar(Kategori kategori)
        {
            kategoriler.Remove(kategori);
        }
        public BindingList<Kategori> KategorileriGetir()
        {
            return kategoriler;
        }
    }
}
