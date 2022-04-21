using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_Mvc_01.Controllers
{

    //eğer bir classın controller davranışını segilemesi yani;
    //gelen bir requesti karşılayabilir özellik kazanmasını istiyorsak
    //o classı controller sınıfından türetmeliyiz.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //action method: eğer metot bir controller içindeyse
            //buna action method denir.hatta çoğu zaman
            //sadece action sözcüğü ile ifade edilebilir.

            //bu action uygulamamızın anasayfasına girdiğinde tetiklenmiş olacak.
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
