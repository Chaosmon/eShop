using eShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagedRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
