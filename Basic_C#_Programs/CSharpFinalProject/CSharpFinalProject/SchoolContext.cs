﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinalProject
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(): base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
