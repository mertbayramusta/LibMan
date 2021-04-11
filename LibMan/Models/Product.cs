using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;

namespace LibMan.Models
{
    public class Product
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Translator { get; set; }
        public string Publisher { get; set; }
        public string Descripton { get; set; }
        public string Catagories { get; set; }
        public string Status { get; set; }
        public string Rate { get; set; }
        public string Id { get; set; }
        
        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string Url { get; set; }
        
        public int[] Rating { get; set; }
        public override string ToString()=> System.Text.Json.JsonSerializer.Serialize<Product>(this);
       

    }
}
