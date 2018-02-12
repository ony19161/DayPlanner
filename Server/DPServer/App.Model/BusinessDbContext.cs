using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext() : base("DefaultBusinessConnection")
        {

        }

        public static BusinessDbContext Create()
        {
            return new BusinessDbContext();
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<TaskState> TaskStates { get; set; }
        public DbSet<TaskReminder> TaskReminders { get; set; }

    }
}
