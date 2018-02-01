using SimpleInjectorExample.Domain.Entities;
using System.Collections.Generic;

namespace SimpleInjectorExample.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        IList<Product> GetAll();
    }
}