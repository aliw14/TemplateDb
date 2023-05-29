using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Podcast1.DataAccessLayer;

namespace Podcast1.ViewComponents
{
	public class FooterViewComponent : ViewComponent
	{
		private readonly AppDbContext _dbcontext;

		public FooterViewComponent(AppDbContext dbContext)
		{
			_dbcontext = dbContext;
		}

		public IViewComponentResult Invoke()
		{
			var footer = _dbcontext.Footers.Include(x => x.Social).FirstOrDefault();
			//var footer = _dbcontext.Footers.Include(x => x.SocialNetworks).SingleOrDefault();
			return View(footer);
        }
    }
}

