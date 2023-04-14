using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentApiV2._0.View_Model
{
    public class KullaniciModel
    {
        public string userId { get; set; }
        public string userAdi { get; set; }
        public string userMail { get; set; }
        public string userPassword { get; set; }
        public string userIsAdmin { get; set; }
        public byte[] userImage { get; set; }
    }
}