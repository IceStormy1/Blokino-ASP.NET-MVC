using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace siteMain.Domain.Entities
{
    public class TextFields:EntityBase
    {
        [Required]
        public string CodeWord { get; set; } //В панели админа и на сайте обращаться к этому текстовому полю

        [Display(Name = "Название страницы(заголовок)")]
        public override string Title { get; set; }

        [Display(Name = "Содержание страницы")]
        public override string Text { get; set; } = "Содержание заполняется администратором";
    }
}
