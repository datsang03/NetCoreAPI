using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;
public class TinhTienController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(TinhTien tinhTien)
    {
        var thanhtien = tinhTien.SoLuong*tinhTien.Gia;
        ViewBag.thanhtien =$"Giá của {tinhTien.SP} với số lượng {tinhTien.SoLuong} có giá là {thanhtien}";
        return View();
    }
}
public class Bill
{
}