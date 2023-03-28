﻿using BlazorOrders.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorOrders.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options) {}
        public DbSet<Client>? Clients { get; set; }
        public DbSet<Order>? Orders { get; set; }
    }

}