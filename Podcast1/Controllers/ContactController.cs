using System;
using Microsoft.AspNetCore.Mvc;
using Podcast1.DataAccessLayer;
using Podcast1.ViewModels;

namespace Podcast1.Controllers
{
	public class ContactController : Controller
	{
        private readonly AppDbContext _dbcontext;


        public ContactController(AppDbContext appDbContext)
        {
            _dbcontext = appDbContext;
        }

        public IActionResult Index()
        {
            var contact = _dbcontext.Contacts.FirstOrDefault();

            var viewModel = new ContactViewModel
            {
                Contacts = contact
            };

            return View();
        }
    }
}

