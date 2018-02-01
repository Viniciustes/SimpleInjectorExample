using System.Collections.Generic;
using SimpleInjectorExample.Domain.Entities;
using SimpleInjectorExample.Domain.Interfaces.Repositories;

namespace SimpleInjectorExample.Infrastructure.Repositories
{
    public class RepositoryProduct : IProductRepository
    {
        public IList<Product> GetAll()
        {
            return new List<Product>() { new Product("Product1"), new Product("Product2"), new Product("Product3") };
        }
    }
}