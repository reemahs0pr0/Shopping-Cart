#pragma checksum "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efbe6e2a1f391b834e421964b296f56219e2a402"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wish_DisplayWish), @"mvc.1.0.view", @"/Views/Wish/DisplayWish.cshtml")]
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
#line 1 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\_ViewImports.cshtml"
using ShoppingCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efbe6e2a1f391b834e421964b296f56219e2a402", @"/Views/Wish/DisplayWish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Wish_DisplayWish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/wish/displaywish.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Cart/DisplayCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
  
    ViewData["Title"] = "Wishlist";
    List<Wish> wishList = (List<Wish>)ViewData["wishlist"];
    int count = (int)ViewData["count"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efbe6e2a1f391b834e421964b296f56219e2a4024544", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<style>
    *#empty {
        text-align: center;
        font-weight: bold;
        font-size: 36px;
    }

    .button3 {
        background-color: #4CAF50;
        border: none;
        color: white;
        padding: 15px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 16px;
        margin: 4px 2px;
        cursor: pointer;
    }

    .wish-table {
        width: 90%;
        margin-left: 5%;
        margin-right: 5%;
        border-collapse: separate;
        border-spacing: 0 1em;
    }

    .wish-table button {
        width: 100%;
    }

    .wish-table td {
        padding: 10px;
    }

    .wish-table tr {
        background-color: #f7f7f7;
    }

    .wish-table img {
        width: 80%;
    }

    h2 {
        font-size: 16px;
    }

    .image {
        height: 300px;
        width: 100px;
    }

    .buttonforcart {
        display: inline-block;
        padding: 10px;
    ");
            WriteLiteral(@"    font-size: 20px;
        font-weight: bold;
        cursor: pointer;
        text-align: center;
        text-decoration: none;
        outline: none;
        color: black;
        background-color: lavender;
        border: none;
        border-radius: 15px;
        box-shadow: 0 9px #999;
        position: fixed;
        top: 100px;
        right: 50px;
    }

    .buttonforcart:hover {
        background-color: #57509f
    }

    .buttonforcart:active {
        background-color: #57509f;
        box-shadow: 0 5px #666;
        transform: translateY(4px);
    }
</style>

<div id=""header"">
    <header>
        <h1>My Wishlist</h1>
    </header>
    <a href=""/Product/DisplayProduct""><u>Home</u></a> | <a href=""/Logout/Index"" id=""logout""><u>Logout</u></a>
</div>
<div id=""cart"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efbe6e2a1f391b834e421964b296f56219e2a4027593", async() => {
                WriteLiteral("\r\n        <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 2142, "\"", 2162, 2);
                WriteAttributeValue("", 2150, "Cart:", 2150, 5, true);
#nullable restore
#line 103 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
WriteAttributeValue(" ", 2155, count, 2156, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"buttonforcart\" id=\"clickme\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div id=\"body\">\r\n");
#nullable restore
#line 107 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
     if (wishList.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span id=\"empty\" style=\"display:block\">\r\n            <br /><br /><br />\r\n            Your Wishlist Is Empty\r\n        </span>\r\n");
#nullable restore
#line 113 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span id=\"empty\" style=\"display:none\">\r\n            <br /><br /><br />\r\n            Your Wishlist Is Empty\r\n        </span>\r\n        <br />\r\n        <table class=\"wish-table\">\r\n");
#nullable restore
#line 122 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
              
                foreach (Wish wish in wishList) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
                                                                               
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr");
            BeginWriteAttribute("id", " id=\"", 2763, "\"", 2776, 1);
#nullable restore
#line 125 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
WriteAttributeValue("", 2768, wish.Id, 2768, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td width=\"50%\">\r\n                            <h2><b>");
#nullable restore
#line 127 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
                              Write(wish.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                            <br />\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2947, "\"", 2969, 2);
            WriteAttributeValue("", 2953, "/img/", 2953, 5, true);
#nullable restore
#line 129 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
WriteAttributeValue("", 2958, wish.Image, 2958, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\" />\r\n                            <br />\r\n                            <p>");
#nullable restore
#line 131 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
                          Write(wish.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </td>\r\n                        <td>\r\n                            <button");
            BeginWriteAttribute("cart_id", " cart_id=\"", 3175, "\"", 3193, 1);
#nullable restore
#line 134 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
WriteAttributeValue("", 3185, wish.Id, 3185, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"button3 add-to-cart\">Add to Cart</button>\r\n                            <button");
            BeginWriteAttribute("remove_id", " remove_id=\"", 3294, "\"", 3314, 1);
#nullable restore
#line 135 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
WriteAttributeValue("", 3306, wish.Id, 3306, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"button3 remove-from-wish\">Remove from Wishlist</button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 138 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 141 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Wish\DisplayWish.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> ");
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
