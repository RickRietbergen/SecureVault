﻿namespace SecureVault.Database.Models
{
    public class UserCreateModel
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
