﻿using System;

namespace PuneCrafters.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int LocationId { get; set; }
        public string Role { get; set; }
    }
}