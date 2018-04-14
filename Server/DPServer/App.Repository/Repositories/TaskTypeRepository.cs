using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Model;
using App.Repository.Interfaces;

namespace App.Repository.Repositories
{
    public class TaskTypeRepository : BaseRepository<TaskType>, ITaskTypeRepository
    {

        public TaskTypeRepository(BusinessDbContext context) : base(context)
        {

        }

        public TaskType GetTaskTypeByName(string name)
        {
            return businessDbContext.TaskTypes.SingleOrDefault(t => t.Type.Equals(name));
        }

        public BusinessDbContext businessDbContext
        {
            get { return Context as BusinessDbContext; }
        }
    }
}
