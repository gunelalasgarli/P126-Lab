#pragma checksum "C:\Users\ASUS\source\repos\Lab-P126\Views\Shared\Components\Slider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9e79771a8a9bf9872e6d28c0e44d5f1ce2f1b1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Slider/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\Lab-P126\Views\_ViewImports.cshtml"
using Lab_P126;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\Lab-P126\Views\_ViewImports.cshtml"
using Lab_P126.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\Lab-P126\Views\_ViewImports.cshtml"
using Lab_P126.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9e79771a8a9bf9872e6d28c0e44d5f1ce2f1b1f", @"/Views/Shared/Components/Slider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f626deab9d58b17075629ff1d9e62ff0f138107", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Slider>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\Lab-P126\Views\Shared\Components\Slider\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"hero-single-slide\">\r\n        <div class=\"hero-slider-item bg-img\" data-bg=\"assets/img/slider/");
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\Lab-P126\Views\Shared\Components\Slider\Default.cshtml"
                                                                   Write(item.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            <div class=\"hero-slider-content slide-1\">\r\n                <h5 class=\"slide-subtitle\">");
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\Lab-P126\Views\Shared\Components\Slider\Default.cshtml"
                                      Write(item.HeadText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h2 class=\"slide-title\">");
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\Lab-P126\Views\Shared\Components\Slider\Default.cshtml"
                                   Write(item.InnerText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p class=\"slide-desc\">");
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\Lab-P126\Views\Shared\Components\Slider\Default.cshtml"
                                 Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a href=\"shop.html\" class=\"btn btn-hero\">SHOP NOW</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\Lab-P126\Views\Shared\Components\Slider\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
