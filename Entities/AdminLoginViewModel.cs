using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AdminLoginViewModel
    {
        [StringLength(50), Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Şifre"), StringLength(50), Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
