using eShop.CoreBusiness.Models;

namespace eShop.UseCase.SearchProductScreen
{
    public interface IViewProduct
    {
        Product Execute(int id);
    }
}