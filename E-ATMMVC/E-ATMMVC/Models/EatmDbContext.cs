using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_ATMMVC.Models
{
    public class EatmDbContext:DbContext
    {
        public EatmDbContext()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<AccountModel> AccountModels { get; set; }
    }
}