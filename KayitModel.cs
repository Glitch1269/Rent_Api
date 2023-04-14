using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentApiV2._0.View_Model
{
    public class KayitModel
    {
        public string kayId { get; set; }
        public string kayCarId { get; set; }
        public string kayKatId { get; set; }

        public ArabaModel arabaBilgi { get; set; }
        public KategoriModel kategoriBilgi { get; set; }
    }
}