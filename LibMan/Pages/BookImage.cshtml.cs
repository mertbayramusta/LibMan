using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibMan.Pages
{
    public class BookImageModel : PageModel
    {
        private readonly LibMan.Models.DB.LibManContext _context;

        public BookImageModel(LibMan.Models.DB.LibManContext context) { _context = context; }

        public IList<TblUser> TblUser { get; set; }

        public void OnGetAsync()
        {
        }
        public async Task<IActionResult> OnPostAsync(IFormFile image)
        {
            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/uploads",
                        image.FileName);
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }
            return RedirectToPage("./Library");
        }
    }
}