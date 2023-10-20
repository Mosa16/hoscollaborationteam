using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace www.sowetocityelectrical.co.za.Pages
{
    public class OurModel : PageModel
    {
        private readonly ILogger<OurModel> _logger;

        public OurModel(ILogger<OurModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}