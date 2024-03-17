﻿using Microsoft.EntityFrameworkCore;
using TierZooAPI.Models;

namespace TierZooAPI.Data;

public class TierZooContext : DbContext
{
    public TierZooContext(DbContextOptions<TierZooContext> options) : base(options)
    {

    }
    public DbSet<Species> Species { get; set; }

    public DbSet<Genre> Genre { get; set; }

    public DbSet<Perk> Perk { get; set; }
}
