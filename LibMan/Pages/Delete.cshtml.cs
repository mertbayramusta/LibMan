using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibMan.Models.DB;

namespace LibMan
{
    public class DeleteModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public DeleteModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblUser TblUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblUser = await _context.TblUser.FirstOrDefaultAsync(m => m.Id == id);

            if (TblUser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblUser = await _context.TblUser.FindAsync(id);

            if (TblUser != null)
            {
                _context.TblUser.Remove(TblUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
