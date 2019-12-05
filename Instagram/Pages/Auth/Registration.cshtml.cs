using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Instagram.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Instagram.Pages.Auth
{
    public class RegistrationModel : PageModel
    {
        private readonly AuthService authService;

        public RegistrationModel(AuthService authService)
        {
            this.authService = authService;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync(string name, string password)
        {
            var token = await authService.Registrate(name, password);

            if (String.IsNullOrEmpty(token))
            {
                return Unauthorized();
            }

            return RedirectToPage("./Index");
        }
    }
}