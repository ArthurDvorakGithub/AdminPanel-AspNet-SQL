#pragma checksum "C:\Users\Администратор\source\repos\WebGameNetCore\WebGameNetCore\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bb5681f37ceb24fce2a852dd194345adb1cc107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Index), @"mvc.1.0.view", @"/Views/Game/Index.cshtml")]
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
#line 1 "C:\Users\Администратор\source\repos\WebGameNetCore\WebGameNetCore\Views\_ViewImports.cshtml"
using WebGameNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Администратор\source\repos\WebGameNetCore\WebGameNetCore\Views\_ViewImports.cshtml"
using WebGameNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb5681f37ceb24fce2a852dd194345adb1cc107", @"/Views/Game/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1b9e70563c14a7535e663e960f39ce88121459d", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Администратор\source\repos\WebGameNetCore\WebGameNetCore\Views\Game\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Unit[] units = (Unit[])ViewData["Units"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Список игроков</h1>\r\n<div class=\"card-group\">\r\n    <div class=\"row\">\r\n       \r\n");
#nullable restore
#line 10 "C:\Users\Администратор\source\repos\WebGameNetCore\WebGameNetCore\Views\Game\Index.cshtml"
         for (int i = 0; i < units.Length; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"card col-sm-3\"");
            BeginWriteAttribute("href", " href=\"", 265, "\"", 302, 2);
            WriteAttributeValue("", 272, "/Game/UnitInfo?id=", 272, 18, true);
#nullable restore
#line 12 "C:\Users\Администратор\source\repos\WebGameNetCore\WebGameNetCore\Views\Game\Index.cshtml"
WriteAttributeValue("", 290, units[i].Id, 290, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 20%;\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=", 365, "", 389, 1);
#nullable restore
#line 14 "C:\Users\Администратор\source\repos\WebGameNetCore\WebGameNetCore\Views\Game\Index.cshtml"
WriteAttributeValue("", 370, units[i].AvatarURL, 370, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\Администратор\source\repos\WebGameNetCore\WebGameNetCore\Views\Game\Index.cshtml"
                                      Write(units[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\Администратор\source\repos\WebGameNetCore\WebGameNetCore\Views\Game\Index.cshtml"
                                    Write(units[i].Health);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 21 "C:\Users\Администратор\source\repos\WebGameNetCore\WebGameNetCore\Views\Game\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    </div>\r\n");
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
