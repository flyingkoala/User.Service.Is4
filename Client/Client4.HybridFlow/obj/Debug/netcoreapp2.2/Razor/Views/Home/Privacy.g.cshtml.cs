#pragma checksum "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f4c4f26348f8834d79c434bf9cc599f15f316a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\_ViewImports.cshtml"
using Client4.HybridFlow;

#line default
#line hidden
#line 2 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\_ViewImports.cshtml"
using Client4.HybridFlow.Models;

#line default
#line hidden
#line 4 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4c4f26348f8834d79c434bf9cc599f15f316a7", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a92a14c24c493850f09268bb994717c1f0802c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(94, 27, true);
            WriteLiteral("\r\n<h2>Claims</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 9 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(169, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(182, 10, false);
#line 11 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(192, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(212, 11, false);
#line 12 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(223, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 13 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml"
    }

#line default
#line hidden
            BeginContext(237, 38, true);
            WriteLiteral("</dl>\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 19 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
            BeginContext(363, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(376, 8, false);
#line 21 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml"
       Write(prop.Key);

#line default
#line hidden
            EndContext();
            BeginContext(384, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(404, 10, false);
#line 22 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml"
       Write(prop.Value);

#line default
#line hidden
            EndContext();
            BeginContext(414, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 23 "F:\Code\Demo\User.Service.Is4\Client\Client4.HybridFlow\Views\Home\Privacy.cshtml"
    }

#line default
#line hidden
            BeginContext(428, 5, true);
            WriteLiteral("</dl>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
