using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppRazorTrainingSite.Data;
using AppRazorTrainingSite.Models;

namespace AppRazorTrainingSite.Areas.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext ctx;

        public CreateModel(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Fruit Fruit { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || ctx.Fruits == null || Fruit == null)
            {
                return Page();
            }

            ctx.Fruits.Add(Fruit);
            await ctx.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
