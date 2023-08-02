using ProjectService.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectService.Models
{
    public class DBoperations
    {
        ProjectEntities pro = new ProjectEntities();
        public string register(Login l)
        {
            ProjectEntities pro=new ProjectEntities();
            l.password=BCrypt.Net.BCrypt.HashPassword(l.password);
            pro.Logins.Add(l);
            pro.SaveChanges();
            return "success";
        }

       
            public Boolean validateUser(Loginvalidation  credentials, out Login user)
            {
                user=pro.Logins.FirstOrDefault(x => x.email==credentials.email);
                if (user==null)
                {
                    return false;

                }
                else
                {
                    return BCrypt.Net.BCrypt.Verify(credentials.password, user.password);
                }
            }

        public Login extracttype(Loginvalidation l)
        {
            var s = l.email;
            var x = (from a in pro.Logins
                    where a.email.Equals(s)
                    select a).FirstOrDefault();
            return x;

        }


        
    }
}