using eShop.CoreBusiness.Models;
using eShop.UseCase.PluginInterfaces.DataStore;
using System.Collections.Generic;

namespace eShop.UseCase.SearchProductScreen
{
    public class SearchProduct : ISearchProduct
    {
        private IProductRepository productRepository;
        public SearchProduct(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(string filter = null)
        {
            return productRepository.GetProducts(filter);
        }
    }
}
