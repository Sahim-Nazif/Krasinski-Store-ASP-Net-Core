using Krasinski.DataAccess.Data.Repository.IRepository;
using Krasinski.Models;
using Krasinski_Store.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krasinski.DataAccess.Data.Repository
{
    public class ServiceRepository:Repository<Service>, IServiceRepository
    {
        private readonly ApplicationDbContext _db;

        public ServiceRepository(ApplicationDbContext db):base (db)
        {
            _db = db;
        }

        public void Update(Service service)
        {
            var ObjFromDb= _db.Service.FirstOrDefault(s => s.Id == service.Id);

            ObjFromDb.Name = service.Name;
            ObjFromDb.Price = service.Price;
            ObjFromDb.LongDesc = service.LongDesc;
            ObjFromDb.ImageUrl = service.ImageUrl;
            ObjFromDb.CategoryId = service.CategoryId;
            ObjFromDb.FrequencyId = service.CategoryId;

            _db.SaveChanges();
        }
    }
}
