#pragma checksum "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5fb147e452796a11ef6138781d5385b205cc05e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\_ViewImports.cshtml"
using QouteAcknowledgements;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\_ViewImports.cshtml"
using QouteAcknowledgements.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5fb147e452796a11ef6138781d5385b205cc05e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae5cdf4d1d67edb39f87ef91369796ae9fad8a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QouteAcknowledgements.Models.Qoute>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
      
        ViewData["Title"] = "Home Page";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Welcome</h1>
        <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
        <h2> Whats the craic bois??</h2>
        <input type=""button""
               value=""Reset""");
            BeginWriteAttribute("onclick", "\r\n               onclick=\"", 408, "\"", 487, 3);
            WriteAttributeValue("", 434, "location.href=\'", 434, 15, true);
#nullable restore
#line 12 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
WriteAttributeValue("", 449, Url.Action("Index", new { id = -1 }), 449, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 486, "\'", 486, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <ul>\r\n");
#nullable restore
#line 14 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    ");
#nullable restore
#line 18 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QouteID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    -\r\n                    ");
#nullable restore
#line 20 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QouteText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <input type=\"button\"\r\n                           value=\"Acknowledge\"");
            BeginWriteAttribute("onclick", "\r\n                           onclick=\"", 829, "\"", 930, 3);
            WriteAttributeValue("", 867, "location.href=\'", 867, 15, true);
#nullable restore
#line 23 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
WriteAttributeValue("", 882, Url.Action("Index", new { id = item.QouteID }), 882, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 929, "\'", 929, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                </li>\r\n");
#nullable restore
#line 27 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QouteAcknowledgements.Models.Qoute>> Html { get; private set; }
    }
}
#pragma warning restore 1591
