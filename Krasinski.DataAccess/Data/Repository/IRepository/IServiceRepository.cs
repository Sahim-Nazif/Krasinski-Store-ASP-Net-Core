using Krasinski.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Krasinski.DataAccess.Data.Repository.IRepository
{
    public interface IServiceRepository:IRepository<Service>
    {
        public void Update(Service service);
    }
}
