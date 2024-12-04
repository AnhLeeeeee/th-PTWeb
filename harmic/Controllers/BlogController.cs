using harmic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace harmic.Controllers
{
    public class BlogController : Controller
    {
        private readonly Harmic1Context _context;
        private readonly object i;

        public BlogController(Harmic1Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("/blog/{alias}-{id}.html")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TbBlogs == null)
            {
                return NotFound();
            }    
            var blog = await _context.TbBlogs 
                .FirstOrDefaultAsync(m => m.BlogId == id);
            if (blog == null)
            {
                return NotFound();
            }
            ViewBag.BlogComment = _context.TbBlogComments.Where(i => i.BlogId == id).ToList();
            return View(blog);
                
        }

    }

}
