using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibMan
{
    public class WelcomeModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public WelcomeModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }

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
    }
}