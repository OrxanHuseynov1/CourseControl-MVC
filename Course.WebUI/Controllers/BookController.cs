using Course.Application.Abstract;
using Course.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.WebUI.Controllers;

public class BookController(IBookService bookService) : Controller
{
    private readonly IBookService _bookService = bookService;
    public IActionResult Index()
    {
        var model = new BookListViewModel
        {
            Books = _bookService.GetAll()
        };

        return View(model);
    }
}
