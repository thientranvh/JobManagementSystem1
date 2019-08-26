using JobManagementSystem.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataAccess
{
    public class DbInitializer
    {
        public static void Initialize(JobSystemDbContext context)
        {
            if (!((RelationalDatabaseCreator)context.Database.GetService<IDatabaseCreator>()).Exists())
            {
                context.Database.EnsureCreated();
            }
            else
            {
                context.Database.Migrate();
            }
        }
    }
}
