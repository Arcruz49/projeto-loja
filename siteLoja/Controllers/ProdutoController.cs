using Microsoft.AspNetCore.Mvc;
using siteLoja.Models;

namespace siteLoja.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly shopDBContext db = new shopDBContext();
        public IActionResult List()
        {

            try
            {
                var produtos = (from a in db.CadProdutos
                                select a).ToList();

                return View(produtos);
            }
            catch (Exception ex) 
            {
                return Content(ex.Message);
            }

        }
    }
}
