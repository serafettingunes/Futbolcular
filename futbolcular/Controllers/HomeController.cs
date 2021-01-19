using futbolcular.Models;
using futbolcular.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace futbolcular.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            teknikdirektor td = new teknikdirektor { ID=1,Ad="Zinedine",Soyad="Zidane",Yas=45,Url= "https://upload.wikimedia.org/wikipedia/commons/f/f3/Zinedine_Zidane_by_Tasnim_03.jpg" };
            List<futbocularx> f = new hazirFutbolcuListesi();
            return View(new teknikdirektorFutbolcularListesiViewModel {teknikdirektorBilgisi=td,futbolcuBigisi=f});
        }
        public ActionResult FutbolcuDetayi(int id)
        {
            List<futbocularx> futbolcu = new hazirFutbolcuListesi();
            futbocularx aradigimFutbolcu = futbolcu.Find(x=>x.ID==id);
            return View(aradigimFutbolcu);
        }
    }
}