using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibMan.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace LibMan
{
    public class JsonDataModel : PageModel
    {
        
        public async Task<IActionResult> OnPostAsync(IFormFile image)
        {
            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/bookjson",
                        image.FileName);
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }
            return RedirectToPage("./JsonBooks");
        }


        public IActionResult OnPostRegister()
        {
            
            return RedirectToPage("./JsonExport");
        }


    }
}