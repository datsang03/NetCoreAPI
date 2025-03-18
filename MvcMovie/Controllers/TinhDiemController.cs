using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class TinhDiemController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index(TinhDiem tinhDiem)
        {
            var td = tinhDiem.DiemA*0.6 + tinhDiem.DiemB*0.3 + tinhDiem.DiemC*0.1;
            ViewBag.td =$"{tinhDiem.FullName} có điểm là {td}";
            return View();
        }
    }
}