using System;
using System.Collections.Generic;
using System.Text;

namespace Krasinski.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork :IDisposable
    {
        ICategoryRepositry Category { get; }
        public void Save();

    }
}
