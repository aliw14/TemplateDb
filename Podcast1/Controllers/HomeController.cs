using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Podcast1.DataAccessLayer;
using Podcast1.Models;
using Podcast1.ViewModels;

namespace Podcast1.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _dbcontext;


    public HomeController(AppDbContext appDbContext)
    {
        _dbcontext = appDbContext;
    }


    public IActionResult Index()
    {

        var social = _dbcontext.Footers.ToList();

        var viewModel = new HomeViewModel
        {
            Footer = social
        };
      
        return View(viewModel);
    }

}

