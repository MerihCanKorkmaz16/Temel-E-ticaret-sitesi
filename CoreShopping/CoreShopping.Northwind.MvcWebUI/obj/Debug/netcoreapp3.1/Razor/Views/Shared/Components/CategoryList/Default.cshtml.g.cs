#pragma checksum "C:\Users\ass\source\repos\CoreShopping\CoreShopping.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d7cff90ce7b03f0aa3ecf0c1021ab969154e1be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d7cff90ce7b03f0aa3ecf0c1021ab969154e1be", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44ae01019361e377f0244715cd5b6d7561d01a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreShopping.Northwind.MvcWebUI.Model.CategoryListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 4 "C:\Users\ass\source\repos\CoreShopping\CoreShopping.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
     foreach (var category in Model.Categories)
    {
        var css = "list-group-item";
        if (category.CategoryId == Model.CurrentCategory)
        {
            css += " active";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t <a");
            BeginWriteAttribute("href", " href=\"", 307, "\"", 358, 2);
            WriteAttributeValue("", 314, "/Product/Index?category=", 314, 24, true);
#nullable restore
#line 11 "C:\Users\ass\source\repos\CoreShopping\CoreShopping.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 338, category.CategoryId, 338, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 359, "\"", 371, 1);
#nullable restore
#line 11 "C:\Users\ass\source\repos\CoreShopping\CoreShopping.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 367, css, 367, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\ass\source\repos\CoreShopping\CoreShopping.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
                                                                        Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 12 "C:\Users\ass\source\repos\CoreShopping\CoreShopping.Northwind.MvcWebUI\Views\Shared\Components\CategoryList\Default.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreShopping.Northwind.MvcWebUI.Model.CategoryListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
