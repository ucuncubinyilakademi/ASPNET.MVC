using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _12_Models.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Kullanıcı adı Lazım")]
        [MaxLength(10,ErrorMessage ="Kısa Yaz biraz MAX 10")]
        public string Username { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password")]
        [Required]
        public string RePassword { get; set; }
    }
}