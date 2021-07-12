using System.ComponentModel.DataAnnotations;

namespace siteMain.Domain.Entities
{
    public class TextFields:EntityBase
    {
        [Required]
        public string CodeWord { get; set; } //В панели админа и на сайте обращаться к этому текстовому полю

        [Required]
        [MaxLength(100)]
        [Display(Name = "Название страницы(заголовок)")]
        public override string Title { get; set; }

        [Display(Name = "Содержание страницы")]
        public override string Text { get; set; } = "Содержание заполняется администратором";
    }
}
