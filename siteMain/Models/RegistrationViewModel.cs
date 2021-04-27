using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace siteMain.Models
{
    public class RegistrationViewModel
    {
        [Required, MaxLength(20)]
        [Display(Name = "Логин")]
        public string LoginReg { get; set; }
        
        [Required, DataType(DataType.Password), MinLength(6)]
        [Display(Name = "Пароль")]
        public string PasswordReg { get; set; }

        [Display(Name = "Повторите введенный пароль")]
        [DataType(DataType.Password), Compare(nameof(PasswordReg))]
        public string ConfirmPassword { get; set; }
        
        [Required, MaxLength(60)]
        [Display(Name = "Электронная почта")]
        public string EmailReg { get; set; }

        [MaxLength(12)]
        [Display(Name = "Номер телефона")]
        public string PhoneReg { get; set; }

    }
}
