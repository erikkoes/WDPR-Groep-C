using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using src.Models;

    public class Context : IdentityDbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }
    }
