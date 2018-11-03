using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Model
{
    public class Category
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Kategori Adı")][Required]
        [StringLength(50,ErrorMessage = "Lütfen 50 Karekterden Fazla Deger Girmeyiniz!")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        [StringLength(250,ErrorMessage = "Lütfen 250 Karekterden Fazla Deger Girmeyiniz!")]
        public string Explanation { get; set; }

        [Display(Name = "Aktip Pasif")]
        public bool Active { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
