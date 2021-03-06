﻿using Roomy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Roomy.Data
{
    public class RoomyGaryDbContext : DbContext
    {
        public RoomyGaryDbContext() : base("roomygary")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Civility> Civilities { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<RoomFile> RoomFiles { get; set; }

    }
}