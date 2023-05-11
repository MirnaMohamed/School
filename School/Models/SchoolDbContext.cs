﻿using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        : base(options) { }
        public DbSet<Student> Students => Set<Student>();
    }

}
