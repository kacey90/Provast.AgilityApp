using Microsoft.EntityFrameworkCore;
using ProvastSAP.Security.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProvastSAP.Security.Configurations
{
    public class SecurityModelConfiguration
    {
        public static void ModelConfiguration(ref ModelBuilder builder)
        {
            //Action
            builder.Entity<Entities.Action>().HasAlternateKey(m => m.Name);
            builder.Entity<Entities.Action>().Property(m => m.CreateDate).HasDefaultValueSql("getDate()");
            builder.Entity<Entities.Action>().Property(m => m.UpdateDate).HasDefaultValueSql("getDate()");

            //Group
            builder.Entity<Group>().Property(m => m.CreateDate).HasDefaultValueSql("getDate()");
            builder.Entity<Group>().Property(m => m.UpdateDate).HasDefaultValueSql("getDate()");

            //SecurityObject
            builder.Entity<SecurityObject>().HasAlternateKey(m => m.Name);
            builder.Entity<SecurityObject>().Property(m => m.CreateDate).HasDefaultValueSql("getDate()");
            builder.Entity<SecurityObject>().Property(m => m.UpdateDate).HasDefaultValueSql("getDate()");

            //User
            builder.Entity<User>().HasAlternateKey(m => m.Name);
            builder.Entity<User>().Property(m => m.CreateDate).HasDefaultValueSql("getDate()");
            builder.Entity<User>().Property(m => m.UpdateDate).HasDefaultValueSql("getDate()");

        }
    }
}
