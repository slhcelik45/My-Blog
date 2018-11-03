using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Model
{
    public class Picture
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Makale Resim")][Required]
        [StringLength(250)]
        public string Images { get; set; }

        [Display(Name = "Makale Video")]
        public string Video { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
