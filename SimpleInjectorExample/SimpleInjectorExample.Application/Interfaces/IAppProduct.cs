using SimpleInjectorExample.Domain.Entities;
using System.Collections.Generic;

namespace SimpleInjectorExample.Application.Interfaces
{
    public interface IAppProduct
    {
        IList<Product> GetAll();
    }
}