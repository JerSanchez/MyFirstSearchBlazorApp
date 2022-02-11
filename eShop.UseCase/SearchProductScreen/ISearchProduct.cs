using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCase.SearchProductScreen
{
    public interface ISearchProduct
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}