using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using LibMan.Models;
using LibMan.WebSite.Services;
using LibMan.Models.DB;

namespace LibMan.Pages
{
    public class JsonBooksModel : PageModel
    {
        private readonly ILogger<JsonBooksModel> _logger;
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }
        public JsonBooksModel(ILogger<JsonBooksModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
        public void OnPost()
        {
            using (StreamWriter file = System.IO.File.CreateText(@"D:\path.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, Products);
            }

        }
    }
}