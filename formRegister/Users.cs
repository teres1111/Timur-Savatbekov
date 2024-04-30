using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formRegister
{
    public class User
    {
        public int  Id { get; set; }
        public string? FIO { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public Role Role { get; set; } // Роль пользователя
    }
    
}
