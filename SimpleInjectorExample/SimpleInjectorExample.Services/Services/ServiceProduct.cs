using System.Collections.Generic;
using SimpleInjectorExample.Domain.Entities;
using SimpleInjectorExample.Domain.Interfaces.Repositories;
using SimpleInjectorExample.Services.Interfaces;

namespace SimpleInjectorExample.Services.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProductRepository _productRepository;

        public ServiceProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}