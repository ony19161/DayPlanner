using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Model;
using App.Repository.Interfaces;

namespace App.Repository.Interfaces
{
    public interface ITaskTypeRepository : IRepository<TaskType>
    {
        TaskType GetTaskTypeByName(string name);
    }
}
