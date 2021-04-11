using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LibMan.Models.DB
{
    public partial class TblLibrary
    {
        public int BookId { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Translator { get; set; }
        public string Publisher { get; set; }
        public string Descripton { get; set; }
        public string BookCoverName { get; set; }
        public string Catagories { get; set; }
        public string Status { get; set; }
        public string Rate { get; set; }

        public virtual TblUser User { get; set; }

    }
}
