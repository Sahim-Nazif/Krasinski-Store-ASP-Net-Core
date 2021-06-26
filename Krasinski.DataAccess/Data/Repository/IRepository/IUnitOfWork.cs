using System;
using System.Collections.Generic;
using System.Text;

namespace Krasinski.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork :IDisposable
    {
        ICategoryRepositry Category { get; }
        IFrequencyRepository Frequency { get; }
        public void Save();

    }
}
