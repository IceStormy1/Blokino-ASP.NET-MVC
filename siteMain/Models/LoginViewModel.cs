using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace siteMain.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Логин")]
        public string UserName { get; set; }


        [Required]
        [Display(Name = "Пароль")]
        [UIHint("password")]
        public string Password { get; set; }


        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }

    }
}
