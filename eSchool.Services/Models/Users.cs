using System;
using System.Collections.Generic;

namespace eSchool.Services.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RolesId { get; set; }

        public virtual Roles Roles { get; set; }
    }
}
