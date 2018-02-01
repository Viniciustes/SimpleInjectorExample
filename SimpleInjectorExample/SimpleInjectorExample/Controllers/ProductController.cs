using SimpleInjectorExample.Application.Interfaces;
using System.Web.Mvc;

namespace SimpleInjectorExample.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAppProduct _appProduct;

        public ProductController(IAppProduct appProduct)
        {
            _appProduct = appProduct;
        }

        // GET: Product
        public ActionResult Index()
        {
            var listProduct = _appProduct.GetAll();
            return View(listProduct);
        }
    }
}