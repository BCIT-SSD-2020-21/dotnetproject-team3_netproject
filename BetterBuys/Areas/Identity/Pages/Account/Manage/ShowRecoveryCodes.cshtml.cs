﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BetterBuys.Interfaces;
using BetterBuys.ViewModels;

namespace BetterBuys.Areas.Identity.Pages.Account.Manage
{
    public class ShowRecoveryCodesModel : PageModel
    {

        private readonly IProductVMService _productVMService;

        public ShowRecoveryCodesModel(IProductVMService productVMService)
        {
            _productVMService = productVMService;
        }
        [TempData]
        public string[] RecoveryCodes { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public ProductIndexVM ProductIndex { get; set; } = new ProductIndexVM();

        public IActionResult OnGet(int? categoryId)
        {
            ProductIndex = _productVMService.GetProductsVM(HttpContext, categoryId);
            if (RecoveryCodes == null || RecoveryCodes.Length == 0)
            {
                return RedirectToPage("./TwoFactorAuthentication");
            }

            return Page();
        }
    }
}
