using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_david_rider.Pages;

public class IndexModel(ILogger<IndexModel> logger, IConfiguration configuration) : PageModel
{
    public void OnGet()
    {
        ViewData["Greeting"] = configuration["Greeting"];
    }
}