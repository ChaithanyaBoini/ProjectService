using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectService.Models.DataLayer
{
    public class AddressDbOPerations
    {
        public static int GetLastAddressId()
        {
            ProjectEntities AE = new ProjectEntities();
            var id = AE.Addresses.OrderByDescending(item => item.Id).Take(1).FirstOrDefault();
            if (id == null)
            {
                return 101;
            }
            else
            {
                int? no = id.Id;
                no = no + 1;
                return (int)no;
            }
        }
    }
}