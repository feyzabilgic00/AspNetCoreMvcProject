using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Admin:IEntity
    {
        [Key]
        public int AdminId { get; set; }
        [StringLength(20,ErrorMessage ="Kullanıcı 20 karakterden fazla olamaz")]
        public string User { get; set; }
        [StringLength(20, ErrorMessage = "Şifre 20 karakterden fazla olamaz")]
        public string Password { get; set; }
    }
}
