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
        var thanhtien = tinhTien.Quantity*tinhTien.Price;
        ViewBag.thanhtien =$"Giá của {tinhTien.NameProduct} với số lượng {tinhTien.Quantity} có giá là {thanhtien}";
        return View();
    }
}
public class Bill
{
}