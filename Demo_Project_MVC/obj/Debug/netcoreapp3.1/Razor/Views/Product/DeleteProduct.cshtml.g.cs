#pragma checksum "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\Product\DeleteProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ef3f499224d6b9b005fc64304b9048753a842b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DeleteProduct), @"mvc.1.0.view", @"/Views/Product/DeleteProduct.cshtml")]
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
#line 1 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\_ViewImports.cshtml"
using Demo_Project_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\_ViewImports.cshtml"
using Demo_Project_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ef3f499224d6b9b005fc64304b9048753a842b0", @"/Views/Product/DeleteProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4021f13b61d069e7a026ba81a07073521603596e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_DeleteProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo_Project_MVC.Models.Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\Product\DeleteProduct.cshtml"
  
    ViewBag.Title = "DeleteProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>DeleteProduct</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\Product\DeleteProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.PName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\Product\DeleteProduct.cshtml"
       Write(Html.DisplayFor(model => model.PName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 23 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\Product\DeleteProduct.cshtml"
       Write(Html.DisplayNameFor(model => model.PQunt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 27 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\Product\DeleteProduct.cshtml"
       Write(Html.DisplayFor(model => model.PQunt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 32 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\Product\DeleteProduct.cshtml"
     using (Html.BeginForm()) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\Product\DeleteProduct.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-actions no-color\">\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n    ");
#nullable restore
#line 37 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\Product\DeleteProduct.cshtml"
Write(Html.ActionLink("Cancel", "DisplayProduct", "Product", new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
#nullable restore
#line 40 "D:\wad\DotNetCoreMVCProject_CE023\Demo_Project_MVC\Views\Product\DeleteProduct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo_Project_MVC.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
