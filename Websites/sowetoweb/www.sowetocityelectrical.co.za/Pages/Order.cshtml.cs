﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace www.sowetocityelectrical.co.za.Pages
{
    public class OrderModel : PageModel
    {
        private readonly ILogger<OrderModel> _logger;

        public OrderModel(ILogger<OrderModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}