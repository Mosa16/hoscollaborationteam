using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace www.sowetocityelectrical.co.za.Pages
{
    public class ArtisansModel : PageModel
    {
        private readonly ILogger<ArtisansModel> _logger;

        public ArtisansModel(ILogger<ArtisansModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}