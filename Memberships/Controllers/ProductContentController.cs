using Memberships.Extensions;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Memberships.Controllers
{
    public class ProductContentController : Controller
    {
        [Authorize]
        // GET: ProductContent
        public async Task<ActionResult> Index(int id)
        {
            var userId = Request.IsAuthenticated ? HttpContext.GetUserId() : null;
            var sections = await SectionExtensions.GetProductSectionAsync(id, userId);
            return View(sections);
        }

        public async Task<ActionResult> Content(int productId, int itemId)
        {
            var model = await SectionExtensions.GetContentAsync(productId, itemId);
            return View("Content", model);
        }
    }
}
