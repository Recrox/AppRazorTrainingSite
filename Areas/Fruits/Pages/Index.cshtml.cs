using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppRazorTrainingSite.Data;
using AppRazorTrainingSite.Models;

namespace AppRazorTrainingSite.Areas.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppRazorTrainingSite.Data.ApplicationDbContext _context;

        public IndexModel(AppRazorTrainingSite.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Fruit> Fruit { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Fruits != null)
            {
                Fruit = await _context.Fruits.ToListAsync();
            }
        }
    }
}
