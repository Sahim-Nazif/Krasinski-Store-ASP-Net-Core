using Krasinski.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Krasinski.DataAccess.Data.Repository.IRepository
{
    public interface IFrequencyRepository:IRepository<Frequency>
    {
        IEnumerable<SelectListItem> GetFrequencyListForDropDown();

        public void Update(Frequency frequency);
    }
}
