#pragma checksum "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a43db58b89ef17853a307826d2884f30d7512698"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterSuccess), @"mvc.1.0.view", @"/Views/Home/RegisterSuccess.cshtml")]
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
#line 1 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\_ViewImports.cshtml"
using Lab16._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\_ViewImports.cshtml"
using Lab16._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a43db58b89ef17853a307826d2884f30d7512698", @"/Views/Home/RegisterSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e983c1ce0662f6f65780cab4b7e1738ade89c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RegisterSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab16._1.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
  
    ViewData["Title"] = "RegisterSuccess";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>RegisterSuccess</h1>\r\n\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
       Write(Html.DisplayNameFor(model => model.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\oomishope\source\repos\Lab16.1\Lab16.1\Views\Home\RegisterSuccess.cshtml"
       Write(Html.DisplayFor(model => model.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab16._1.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
