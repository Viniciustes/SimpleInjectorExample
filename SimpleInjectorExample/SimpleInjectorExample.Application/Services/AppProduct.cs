using System.Collections.Generic;
using SimpleInjectorExample.Application.Interfaces;
using SimpleInjectorExample.Domain.Entities;
using SimpleInjectorExample.Services.Interfaces;

namespace SimpleInjectorExample.Application.Services
{
    public class AppProduct : IAppProduct
    {
        private readonly IServiceProduct _serviceProduct;

        public AppProduct(IServiceProduct serviceProduct)
        {
            _serviceProduct = serviceProduct;
        }

        public IList<Product> GetAll()
        {
            return _serviceProduct.GetAll();
        }
    }
}