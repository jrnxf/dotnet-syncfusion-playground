#pragma checksum "/Users/colbythomas/ParDev/Ethos/dotnet-syncfusion-playground/dotnet-syncfusion-playground/dotnet-syncfusion-playground/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f851ffa275b775f7a9dc80e98327f88c4957240b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/colbythomas/ParDev/Ethos/dotnet-syncfusion-playground/dotnet-syncfusion-playground/dotnet-syncfusion-playground/Views/_ViewImports.cshtml"
using dotnet_syncfusion_playground;

#line default
#line hidden
#line 2 "/Users/colbythomas/ParDev/Ethos/dotnet-syncfusion-playground/dotnet-syncfusion-playground/dotnet-syncfusion-playground/Views/_ViewImports.cshtml"
using dotnet_syncfusion_playground.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f851ffa275b775f7a9dc80e98327f88c4957240b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f9531dfc344eed8cda3ff2dbb0d1ff11e5c40e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/colbythomas/ParDev/Ethos/dotnet-syncfusion-playground/dotnet-syncfusion-playground/dotnet-syncfusion-playground/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 95, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Dotnet SyncFusion Playground</h1>\n</div>\n\n");
            EndContext();
#line 9 "/Users/colbythomas/ParDev/Ethos/dotnet-syncfusion-playground/dotnet-syncfusion-playground/dotnet-syncfusion-playground/Views/Home/Index.cshtml"
  Html.BeginForm("CreateDocument", "Home", FormMethod.Get);
    {

#line default
#line hidden
            BeginContext(203, 66, true);
            WriteLiteral("        <button class=\"btn btn-success m-2\">Generate PDF</button>\n");
            EndContext();
#line 12 "/Users/colbythomas/ParDev/Ethos/dotnet-syncfusion-playground/dotnet-syncfusion-playground/dotnet-syncfusion-playground/Views/Home/Index.cshtml"
    }
    Html.EndForm();

#line default
#line hidden
            BeginContext(297, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 16 "/Users/colbythomas/ParDev/Ethos/dotnet-syncfusion-playground/dotnet-syncfusion-playground/dotnet-syncfusion-playground/Views/Home/Index.cshtml"
  Html.BeginForm("TransposeData", "Home", FormMethod.Get);
    {

#line default
#line hidden
            BeginContext(363, 73, true);
            WriteLiteral("        <button class=\"btn btn-success m-2\">Write data onto PDF</button>\n");
            EndContext();
#line 19 "/Users/colbythomas/ParDev/Ethos/dotnet-syncfusion-playground/dotnet-syncfusion-playground/dotnet-syncfusion-playground/Views/Home/Index.cshtml"
    }
    Html.EndForm();

#line default
#line hidden
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
