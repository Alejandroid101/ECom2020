using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ECom.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECom.Pages.Account
{
    public class LoginModel : PageModel
    {
        private SignInManager<ApplicationUser> _signInManager;

        //created property to reference the type
        [BindProperty]
        public InputModel Input { get; set; }

        //need this to be able to check if the password associated with the user is correct.
        public LoginModel(SignInManager<ApplicationUser>signInManager)
        {
            _signInManager = signInManager;
        }


        public void OnGet()
        {

        }

        //will get hit when the user clicks the login button
        public async Task <IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //check if the password associated with the user is correct
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, false);
                if (result.Succeeded)
                {
                    //if sign in was successful then redirect to index page on home controller 
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "Invalid Login Attempt");
                    return Page();
                }
            }
            return Page();
        }


        /// <summary>
        /// 
        /// </summary>
        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember Me")]
            public bool RememberMe { get; set; }
        }
    }
}