﻿namespace ProjectBase.Domain.Entities
{
    public class UserRole
    {
        public string Username { get; set; }
        public int RoleId { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

    }
}
