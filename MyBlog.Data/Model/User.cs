using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Model
{
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Kullanıcı Ad ve Soyad")][Required]
        [StringLength(100,ErrorMessage = "Lütfen 100 Karekterden Fazla Gireyiniz!")]
        public string NameSurname { get; set; }

        [Display(Name = "E-mail")][Required]
        [StringLength(100)]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            ErrorMessage ="Lüften Mail Adresini Doğru Giriniz!" )]
        public string Email { get; set; }

        [Display(Name = "Şifre")][Required]
        [MaxLength(16,ErrorMessage = "Lütfen 16 Karekterden Fazla Girmeyiiz!"),MinLength(4,ErrorMessage = "Lütfen 4 Karekterden Az Girmeyiniz!")]
        [DataType(DataType.Password)][StringLength(16)]
        public string Password { get; set; }

        [Display(Name = "Cinsiyet")]
        public string Gender { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime DateOfBirth { get; set; }

        private DateTime _date=DateTime.Now.Date;
        [Display(Name = "Kayıt Tarihi")]
        public DateTime InsertDate
        {
            get { return _date;}
            set { _date = value;}
        }

        [Display(Name = "Kullanıcı Resmi")]
        [StringLength(250)]
        public string Image { get; set; }

        public int RolId { get; set; }
        public Role Role { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
