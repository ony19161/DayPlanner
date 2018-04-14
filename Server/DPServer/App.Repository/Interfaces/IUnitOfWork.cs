using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITaskTypeRepository TaskTypes { get; }
        bool Commit();
    }
}
