using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AmxBookstore.Pages
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnPost()
        {
            HttpContext.Response.Cookies.Delete("jwt");
            return RedirectToPage("/Login");
        }
    }
}
