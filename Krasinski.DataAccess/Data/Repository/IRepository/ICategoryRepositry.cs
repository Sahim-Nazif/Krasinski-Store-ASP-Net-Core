using Krasinski.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Krasinski.DataAccess.Data.Repository.IRepository
{
    public interface ICategoryRepositry:IRepository<Category>
    {

        IEnumerable<SelectListItem> GetCategoryListForDropDown();

        public void Update(Category category);
    }
}
