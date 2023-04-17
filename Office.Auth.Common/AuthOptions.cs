﻿using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Office.Auth.Common
{
    public class AuthOptions
    {
        public string Issuer { get; set; }
        public  string Audience { get; set; }
        public string Secret { get; set; }
        public int TokenLifeTime { get; set; } //secs
        public SymmetricSecurityKey GetSymmetricSecurityKey() 
        {
            return new SymmetricSecurityKey (Encoding.ASCII.GetBytes(Secret)); // UTF8
        }
           
    }
}