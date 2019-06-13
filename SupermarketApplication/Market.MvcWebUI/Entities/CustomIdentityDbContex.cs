using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Market.MvcWebUI.Entities
{
    public class CustomIdentityDbContex:IdentityDbContext<CustomIdentityUser,CustomIdentityRole,string>
    {
        public CustomIdentityDbContex(DbContextOptions<CustomIdentityDbContex>options):base(options)
        {
        }
    }
}
