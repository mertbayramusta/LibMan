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
    public class UserListModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public UserListModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }

        public IList<TblUser> TblUser { get; set; }

        public async Task OnGetAsync()
        {
            TblUser = await _context.TblUser.ToListAsync();
        }
    }
}