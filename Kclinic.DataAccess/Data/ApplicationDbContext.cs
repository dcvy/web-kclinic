﻿
using Kclinic.Models;
using Microsoft.EntityFrameworkCore;

namespace Kclinic.DataAccess;
public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories {  get; set; }
    public DbSet<CoverType> CoverTypes { get; set; }
    public DbSet<Blog> Blogs { get; set; }
}