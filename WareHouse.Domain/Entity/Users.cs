using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Domain.Entity
{
    public  class Users
    {
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public string  UserMail { get; set; }
        public string  UserPhone { get; set; }
        public string  UserPassword { get; set; }
        public int RoleId { get; set; }

        public Role Role { get; set; }

        //public ICollection<UserWareHouse> UserWareHouses { get; set; }

    }
}
