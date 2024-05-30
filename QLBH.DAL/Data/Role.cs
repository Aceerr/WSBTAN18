﻿using System;
using System.Collections.Generic;

namespace QLBH.DAL.Data
{
    public partial class Role
    {
        public Role()
        {
            ManagerAccounts = new HashSet<ManagerAccount>();
        }

        public int RoleId { get; set; }
        public string? RoleName { get; set; }

        public virtual ICollection<ManagerAccount> ManagerAccounts { get; set; }
    }
}