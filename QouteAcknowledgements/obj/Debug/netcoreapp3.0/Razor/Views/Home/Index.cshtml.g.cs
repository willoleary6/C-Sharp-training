#pragma checksum "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f51a09e173390d761b8883c52928dfb949480d7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f51a09e173390d761b8883c52928dfb949480d7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae5cdf4d1d67edb39f87ef91369796ae9fad8a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QouteAcknowledgements.Controllers.ExampleViewModel>
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
            BeginWriteAttribute("onclick", "\r\n               onclick=\"", 411, "\"", 490, 3);
            WriteAttributeValue("", 437, "location.href=\'", 437, 15, true);
#nullable restore
#line 12 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
WriteAttributeValue("", 452, Url.Action("Index", new { id = -1 }), 452, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 489, "\'", 489, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        \r\n        <div>\r\n            <ul style=\"width:45%; float:left;\">\r\n\r\n");
#nullable restore
#line 17 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
                 if (Model.CollectionA != null)
                {

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
                     foreach (var item in Model.CollectionA.ToList())
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            ");
#nullable restore
#line 24 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.QouteID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            -\r\n                            ");
#nullable restore
#line 26 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.QouteText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"button\"\r\n                                   value=\"Acknowledge\"");
            BeginWriteAttribute("onclick", "\r\n                                   onclick=\"", 1049, "\"", 1158, 3);
            WriteAttributeValue("", 1095, "location.href=\'", 1095, 15, true);
#nullable restore
#line 29 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
WriteAttributeValue("", 1110, Url.Action("Index", new { id = item.QouteID }), 1110, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1157, "\'", 1157, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                        </li>\r\n");
#nullable restore
#line 33 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n\r\n            <ul style=\"width:45%; float:right;\">\r\n");
#nullable restore
#line 39 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
                 if (Model.CollectionB!= null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
                     foreach (var item in Model.CollectionB.ToList())
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            ");
#nullable restore
#line 45 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.QouteID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            -\r\n                            ");
#nullable restore
#line 47 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.QouteText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <input type=\"button\"\r\n                                   value=\"Acknowledge\"");
            BeginWriteAttribute("onclick", "\r\n                                   onclick=\"", 1788, "\"", 1897, 3);
            WriteAttributeValue("", 1834, "location.href=\'", 1834, 15, true);
#nullable restore
#line 50 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
WriteAttributeValue("", 1849, Url.Action("Index", new { id = item.QouteID }), 1849, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1896, "\'", 1896, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </li>\r\n");
#nullable restore
#line 52 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\SourceCode\C-Sharp-training\QouteAcknowledgements\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QouteAcknowledgements.Controllers.ExampleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
