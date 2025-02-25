using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace Mvmovie.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index (BMI bmi)
        {
            var result = bmi.CanNang/(bmi.ChieuCao*bmi.ChieuCao);
          if(result<15.8){
              ViewBag.message = $"Xin chào bạn {bmi.HoTen} có chiều cao là: {bmi.ChieuCao} m có cân nặng là: {bmi.CanNang} kg có chỉ số BMI là {result} bạn gầy";
          }
          else 
          if(result>=15.8&& result<=24.9){
              ViewBag.message = $"Xin chào {bmi.HoTen} tuổi có chiều cao là: {bmi.ChieuCao} m có cân nặng là: {bmi.CanNang} kg có chỉ số BMI là {result} bạn bình thương";
          }
          else 
          if(result>=25&& result<=29.9){
              ViewBag.message = $"Xin chào {bmi.HoTen} tuổi có chiều cao là: {bmi.ChieuCao} m có cân nặng là: {bmi.CanNang} kg có chỉ số BMI là {result} bạn thừa cân";
          }
          else 
          if(result>=30&& result<=34.9){
              ViewBag.message = $"Xin chào {bmi.HoTen}  tuổi có chiều cao là: {bmi.ChieuCao} m có cân nặng là: {bmi.CanNang} kg có chỉ số BMI là {result} bạn bé phì độ 1";
          }
           else 
          if(result>=35&& result<=39.9){
              ViewBag.message = $"Xin chào {bmi.HoTen}  tuổi có chiều cao là: {bmi.ChieuCao} m có cân nặng là: {bmi.CanNang} kg có chỉ số BMI là {result} bạn bé phì độ 2";
          }
          else {
              ViewBag.message = $"Xin chào {bmi.HoTen}  tuổi có chiều cao là: {bmi.ChieuCao} m có cân nặng là: {bmi.CanNang} kg có chỉ số BMI là {result} bạn bé phì độ 3";

          }
            return View();
        }
    }
}
