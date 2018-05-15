using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ErrorHandlingProofs.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync(string button)
        {
            if (string.IsNullOrWhiteSpace(button))
            {
                throw new ArgumentNullException(nameof(button));
            }

            switch (button)
            {
                case "ApplicationException":
                    throw new ApplicationException($"{button} Exception");
                    break;
                case "NotFoundResult":
                    return new NotFoundResult();
                    break;
                case "StatusCodeResult-500":
                    return new StatusCodeResult(500);
                    break;
                case "ArgumentNullException":
                    throw new ArgumentNullException(nameof(button));
                    break;
                default:
                    throw new Exception($"{button} is unknown!");
            }
 

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
