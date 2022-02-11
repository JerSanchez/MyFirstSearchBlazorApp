﻿using eShop.CoreBusiness.Models;
using System.Collections.Generic;

namespace eShop.UseCase.PluginInterfaces.DataStore
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts(string filter = null);
    }
}