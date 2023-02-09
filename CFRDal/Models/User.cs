﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFRDal.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get;set; }
        public string Username { get; set; }
        public string? DisplayName { get; set;}
        public string Password { get; set; }
        public string PfpUrl { get; set; }
        public string? Bio { get; set; }
    }
}
