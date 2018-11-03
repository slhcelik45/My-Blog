using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Model
{
    public class Comment
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Yorum İçerik")]
        [StringLength(500,ErrorMessage = "Lütfen 500 Karekterden Fazla Girmeyiniz!")]
        public string Content { get; set; }

        private DateTime _date=DateTime.Now.Date;

        [Display(Name = "Yorum Tarihi")]
        public DateTime InsertDate
        {
            get { return _date;}
            set { _date = value;}
        }

        [Display(Name = "Beğeni")]
        public int Like { get; set; }

        public int ArticleId { get; set; }
        public Article Article { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
