using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibMan
{
    public class DetailsBookModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public DetailsBookModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }

        public TblLibrary TblLibrary { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblLibrary = await _context.TblLibrary
                .Include(t => t.User).FirstOrDefaultAsync(m => m.BookId == id);

            if (TblLibrary == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}