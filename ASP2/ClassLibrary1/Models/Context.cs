using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DataWork.Models
{
    internal class Context : DbContext
    {
        public DbSet<Respons> Respons { get; set; }
        public DbSet<Form> Forms { get; set; }
    }
}