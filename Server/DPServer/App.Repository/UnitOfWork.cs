using App.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Model;
using App.Repository.Repositories;

namespace App.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BusinessDbContext _context;

        public UnitOfWork(BusinessDbContext context)
        {
            _context = context;
            TaskTypes = new TaskTypeRepository(_context);
        }

        public ITaskTypeRepository TaskTypes { get; private set; }

        public bool Commit()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                // add log message here
                return false;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
