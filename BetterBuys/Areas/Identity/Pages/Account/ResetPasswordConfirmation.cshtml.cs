﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetterBuys.Interfaces;
using BetterBuys.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BetterBuys.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResetPasswordConfirmationModel : PageModel
    {

        private readonly IProductVMService _productVMService;

        public ResetPasswordConfirmationModel(IProductVMService productVMService)
        {
            _productVMService = productVMService;
        }

        public ProductIndexVM ProductIndex { get; set; } = new ProductIndexVM();
        public void OnGet()
        {
            ProductIndex = _productVMService.GetProductsVM(HttpContext, null);
        }
    }
}
