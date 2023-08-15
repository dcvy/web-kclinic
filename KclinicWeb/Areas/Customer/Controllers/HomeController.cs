using Kclinic.DataAccess.Repository.IRepository;
using Kclinic.Models;
using Kclinic.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace KclinicWeb.Controllers;
[Area("Customer")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
		var viewModel = new HomeVM
		{
			Blogs = _unitOfWork.Blog.GetAll(includeProperties: "Category,CoverType"),
			Products = _unitOfWork.Product.GetAll()

	    };

		return View(viewModel);
	}

    public IActionResult Details(int id)
    {
        ShoppingCart cartObj = new()
        {
            Count=1,
            Blog = _unitOfWork.Blog.GetFirstOrDefault(u => u.Id == id, includeProperties: "Category,CoverType"),
        };

        return View(cartObj);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
