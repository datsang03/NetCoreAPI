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
            var result = tinhDiem.DiemA*0.6 + tinhDiem.DiemB * 0.3 + tinhDiem.DiemC *0.1;
            if(result<5){
                ViewBag.tinhdiem = $"Bạn {tinhDiem.FullName} có két quả là {result} với điểm thành phần A:{tinhDiem.DiemA},B:{tinhDiem.DiemB},C:{tinhDiem.DiemC} và trượt môn";
            }
            else
            if(result>=5&& result<6.5){
                ViewBag.tinhdiem = $"Bạn {tinhDiem.FullName} có két quả là {result} với điểm thành phần A:{tinhDiem.DiemA},B:{tinhDiem.DiemB},C:{tinhDiem.DiemC} và TRUNG BÌNH";
            }
            else
            if(result>=6.5 && result<8){
                ViewBag.tinhdiem = $"Bạn {tinhDiem.FullName} có két quả là {result} với điểm thành phần A:{tinhDiem.DiemA},B:{tinhDiem.DiemB},C:{tinhDiem.DiemC} và kHÁ";
            }
            else {
                ViewBag.tinhdiem = $"Bạn {tinhDiem.FullName} có két quả là: {result} với điểm thành phần A:{tinhDiem.DiemA},B:{tinhDiem.DiemB},C:{tinhDiem.DiemC} và giỏi";
            }
            return View();
        }
    }
}