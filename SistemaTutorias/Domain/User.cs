﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTutorias.Domain
{
    internal class User
    {
        
        
        public string username { get; set; }
        public string password { get; set; }
        public int usertype { get; set; }

        public User() { 
        
        
        }
        public User(string username, string password, int usertype) { 
            this.username = username;
            this.password = password;
            this.usertype = usertype;   

        }
    }
}
