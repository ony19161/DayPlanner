using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new App.Repository.UnitOfWork(new App.Model.BusinessDbContext()))
            {
                var taskType = new TaskType
                {
                    Id = Guid.NewGuid().ToString(),
                    Type = "Personal",
                    CreatedBy = "Admin",
                    ModifiedBy = "Admin",
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    CreatedFrom = "Console",
                    ModifiedFrom = "Console"
                };
                unitOfWork.TaskTypes.Add(taskType);
                unitOfWork.Commit();
            }
        }
    }
}
