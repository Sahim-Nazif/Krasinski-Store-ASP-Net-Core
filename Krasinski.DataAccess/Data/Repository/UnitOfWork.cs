using Krasinski.DataAccess.Data.Repository.IRepository;
using Krasinski_Store.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Krasinski.DataAccess.Data.Repository
{
   public  class UnitOfWork:IUnitOfWork
    {

        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepositry(_db);
            Frequency = new FrequencyRepository(_db);
            Service = new ServiceRepository(_db);

        }

        public ICategoryRepositry Category { get; private set; }

        public IFrequencyRepository Frequency { get; private set; }
        public IServiceRepository Service { get; private set; }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
