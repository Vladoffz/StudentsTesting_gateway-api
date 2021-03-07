﻿using System;

namespace Gateway_Services.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}