using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5RestoHelper.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public int discountType { get; set; }
        public int accessLevel { get; set; }


        public User()
        {

        }

        public User(int id, string nickname, string password, int discountType, int accessLevel)
        {
            this.Id = id;
            this.Nickname = nickname;
            this.Password = password;
            this.discountType = discountType;
            this.accessLevel = accessLevel;
        }
    }
}
