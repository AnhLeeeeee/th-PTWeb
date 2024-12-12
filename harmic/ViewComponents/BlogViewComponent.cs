﻿using harmic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace harmic.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly HarmicContext _context;


        public BlogViewComponent(HarmicContext context)
        {

            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbBlogs.Include(m => m.Category)
                .Where(m => (bool)m.IsActive);
            return await Task.FromResult<IViewComponentResult>
            (View(items.OrderByDescending(m => m.BlogId).ToList()));
        }
    }
    
}