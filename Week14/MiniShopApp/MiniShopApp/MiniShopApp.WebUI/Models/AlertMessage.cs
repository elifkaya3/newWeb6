using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class AlertMessage
    {
        //uygulamamızda çeşitli durumlarda ihtiyaç duyduğumuz uyarı mesajları için kullanılacak

        public string Message { get; set; }//uyarı mesajı
        public string AlertType { get; set; }//uyarı tipi
    }
}
