using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LibMan.Models.DB;

namespace LibMan
{
    public class CreateModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public CreateModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TblUser TblUser { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblUser.Add(TblUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
