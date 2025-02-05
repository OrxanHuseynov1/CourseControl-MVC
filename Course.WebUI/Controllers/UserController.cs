using Course.Application.Abstract;
using Course.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.WebUI.Controllers;

public class UserController(IUserService userService) : Controller
{
    private readonly IUserService _userService = userService;
    public IActionResult Index()
    {
        var model = new UserListViewModel
        {
            Users = _userService.GetAll()
        };
        return View(model);
    }
}
