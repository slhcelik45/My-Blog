using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Model
{
    public class Label
    {
        public Label()
        {
            this.Articles=new HashSet<Article>();
        }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Etiket Adı")]
        public string Name { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
