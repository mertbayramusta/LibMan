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
    public class JsonExportModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public JsonExportModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }

        public IList<TblLibrary> TblLibrary { get; set; }
        public async Task OnGetAsync()
        {
            TblLibrary = await _context.TblLibrary
                .Include(t => t.User).ToListAsync();
        }

    }
}