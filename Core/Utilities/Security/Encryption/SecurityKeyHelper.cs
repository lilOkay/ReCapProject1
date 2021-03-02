using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utils.Security.Encryption
{
    public class SecurityKeyHelper
    {//biz burada bir anhtar alıyoruz ve sonrasıda bu anahtarı signingcredantialhelperda kullanıyoruz
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}