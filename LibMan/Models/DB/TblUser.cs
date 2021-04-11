using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibMan.Models.DB
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblLibrary = new HashSet<TblLibrary>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string BirthDate { get; set; }
        [Required]
        public string Username { get; set; }
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{2,3}\.[0-9]{2,3}\.[0-9]{2,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{2,3})(\]?)$")]
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string PhotoName { get; set; }

        public virtual ICollection<TblLibrary> TblLibrary { get; set; }
    }
}
