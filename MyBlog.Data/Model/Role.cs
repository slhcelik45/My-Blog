using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Model
{
    public class Role
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Rol Adı")][Required]
        [StringLength(50,ErrorMessage = "Lütfen 50 Karekterden Fazla Girmeyiniz!")]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
