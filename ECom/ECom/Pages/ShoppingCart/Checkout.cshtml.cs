using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ECom.Models;
using ECom.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECom
{
    public class CheckoutModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager;
        private IEmailSender _email;
        private ICartManager _cart;
        private IPayment _payment;

        [BindProperty]
        public CheckoutInput Input { get; set; }
        public void OnGet()
        {

        }
        public class CheckoutInput
        {
            [Display(Name = "Purchased Date:")]
            public DateTime Date { get; set; }

            [Required]
            [Display(Name = "First Name:")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name:")]
            public string LastName { get; set; }

            [Required]
            public string Address { get; set; }

            [Display(Name = "Address 2:")]
            public string Address2 { get; set; }

            [Required]
            public string City { get; set; }

            [Required]
            public string State { get; set; }

            [Required]
            [DataType(DataType.PostalCode)]
            [Compare("Zip", ErrorMessage = "The is an invalid zip code")]
            public string Zip { get; set; }

        }

    }
}