using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dproject_yeni
{
    public class Araba
    {
        [Key]
        public int ArabaID { get; set; }
        public string MarkaAdı { get; set; }
        public string ModelAdı { get; set; }
        public string KasaTipi { get; set; }
        public int ModelYılı { get; set; }
        public string VitesTipi { get; set; }
    }
}
