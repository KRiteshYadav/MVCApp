#pragma checksum "C:\Users\KY185041\source\repos\FriendApp\FriendApp\Views\Friend\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d1e9bf0493e9f9a178ad1e153766c8195d510ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_Index), @"mvc.1.0.view", @"/Views/Friend/Index.cshtml")]
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
#line 1 "C:\Users\KY185041\source\repos\FriendApp\FriendApp\Views\_ViewImports.cshtml"
using FriendApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KY185041\source\repos\FriendApp\FriendApp\Views\_ViewImports.cshtml"
using FriendApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d1e9bf0493e9f9a178ad1e153766c8195d510ce", @"/Views/Friend/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"496beabeb93bbc35976ad0afecef4d9276dc2d7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FriendApp.Models.Friend>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: left; width: 280px; background-color:lightblue;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <style type=""text/css"">
        table {
            border: ridge 5px red;
            background-color: papayawhip;
            color: red;
        }

            table td {
                border: inset 1px #000;
            }
            h1 {
                color: black;
            }
    </style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d1e9bf0493e9f9a178ad1e153766c8195d510ce3811", async() => {
                WriteLiteral("\r\n\r\n<h1>F.R.I.E.N.D.S</h1>\r\n\r\n<div class=\"Friend\">\r\n    <table border=\"1\">\r\n        <tr>\r\n            <th>FriendId</th>\r\n            <th>FriendName</th>\r\n            <th>Place</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\KY185041\source\repos\FriendApp\FriendApp\Views\Friend\Index.cshtml"
         foreach (var friend in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\KY185041\source\repos\FriendApp\FriendApp\Views\Friend\Index.cshtml"
               Write(friend.FriendId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 35 "C:\Users\KY185041\source\repos\FriendApp\FriendApp\Views\Friend\Index.cshtml"
               Write(friend.FriendName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 37 "C:\Users\KY185041\source\repos\FriendApp\FriendApp\Views\Friend\Index.cshtml"
               Write(friend.Place);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\KY185041\source\repos\FriendApp\FriendApp\Views\Friend\Index.cshtml"


        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </table>\r\n   \r\n\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FriendApp.Models.Friend>> Html { get; private set; }
    }
}
#pragma warning restore 1591
