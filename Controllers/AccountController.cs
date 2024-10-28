using Microsoft.AspNetCore.Mvc;
using PracticeExam.Models; // Thay thế YourNamespace bằng namespace của bạn

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View(); // Trả về view đăng nhập
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        // Bỏ qua kiểm tra và cho phép đăng nhập thành công với bất kỳ thông tin nào
        return RedirectToAction("Index", "Home");
    }
}
