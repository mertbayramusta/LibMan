using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Http;

namespace LibMan
{
    public class IndexModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public IndexModel(LibMan.Models.DB.LibManContext context)
        {
            _context = context;
        }
        [BindProperty] public string Username { get; set; }

        [BindProperty] public string Password { get; set; }

        public string Msg { get; set; }

        public IList<TblUser> TblUser { get; set; }

        public async Task OnGetAsync()
        {
            TblUser = await _context.TblUser.ToListAsync();
        }

        private bool UsersExists(string username, string password)
        {
            bool usern = false, pass = false;


            usern = _context.TblUser.Any(e => e.Username == username); 
            pass = _context.TblUser.Any(e => e.Password == password);

            if (usern == true && pass == true) { return true; }

            else { return false; }

        }
        public IActionResult OnPost()
        {
            if (UsersExists(Username, Password))
            {
                //HttpContext.Session.SetString("username", Username);                 
                var cust = _context.TblUser.Single(a => a.Username == Username);
                HttpContext.Session.SetString("username", cust.Username);
                // return RedirectToPage("Welcome");                 
                return RedirectToPage("Library");
            }
            else
            {

                Msg = "Invalid Entry Try Again!";

                return Page();
            }
        }
    }
}
