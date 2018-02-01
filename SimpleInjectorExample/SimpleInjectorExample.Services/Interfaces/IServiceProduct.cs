using SimpleInjectorExample.Domain.Entities;
using System.Collections.Generic;

namespace SimpleInjectorExample.Services.Interfaces
{
    public interface IServiceProduct
    {
        IList<Product> GetAll();
    }
}