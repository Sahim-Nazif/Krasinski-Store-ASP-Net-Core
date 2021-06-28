using System;
using System.Collections.Generic;
using System.Text;

namespace Krasinski.Models.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public IEnumerable<Service> ServiceList { get; set; }
    }
}
