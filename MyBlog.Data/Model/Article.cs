using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Model
{
    public class Article
    {
        public Article()
        {
            this.Labels=new HashSet<Label>();
        }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Makale Başlık")][Required]
        [StringLength(150,ErrorMessage = "LÜtfen 150 Karekterden Fazla Girmeyiniz!")]
        public string Title { get; set; }

        [Display(Name = "Makele İçerik")][Required]
        [StringLength(500,ErrorMessage = "Lütfen 500 Karekterden Fazla Girmeyiniz!")]
        public string Content { get; set; }

        private DateTime _date=DateTime.Now.Date;
        [Display(Name = "Eklame Tarihi")]
        public DateTime InsertDate
        {
            get { return _date;}
            set { _date = value;}
        }

        [Display(Name = "Okunma Sayısı")]
        public int ReadCount { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Picture> Pictures { get; set; }
        public ICollection<Label> Labels { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
