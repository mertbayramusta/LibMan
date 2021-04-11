using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibMan
{
    public class SignUpModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public SignUpModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TblUser TblUser { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblUser.Add(TblUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("./UserImage");
        }
    }
}