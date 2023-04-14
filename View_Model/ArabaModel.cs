using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentApiV2._0.View_Model
{
    public class ArabaModel
    {
        public string carId { get; set; }
        public string carMarka { get; set; }
        public string carModel { get; set; }
        public string carYakit { get; set; }
        public string carYolcu { get; set; }
        public string carKatId { get; set; }
        public string carFiyat { get; set; }
        public string carTelNo { get; set; }
        public byte[] carImg { get; set; }
    }
}