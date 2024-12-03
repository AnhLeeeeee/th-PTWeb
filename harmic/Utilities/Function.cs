using Microsoft.AspNetCore.Mvc;

namespace harmic.Utilities
{
    public class Function : Controller
    {
        public static string TitleSlugGenerationAlias(string title)
        {
            return SlugGenerator.SlugGenerator.GenerateSlug(title);
        }
    }
}
