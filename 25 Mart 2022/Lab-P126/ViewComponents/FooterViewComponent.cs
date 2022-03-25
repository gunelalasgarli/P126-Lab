using Lab_P126.Data;
using Lab_P126.Models;
using Lab_P126.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_P126.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly LayoutService _layout;

        public FooterViewComponent(LayoutService layout)
        {
            _layout = layout;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Dictionary<string, string> layoutService = _layout.GetSettings();

            return View(layoutService);
        }
    }
}
