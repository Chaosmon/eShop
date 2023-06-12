using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.ViewModels.Common
{
    public class PagedResult<T>
    {
        public List<T> Iteams { get; set; }
        public int TotalRecord { get; set; }
    }
}
