#pragma checksum "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a33ad3e9f9159eae237ee19780f293d700ba7490"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchases_DisplayPurchases), @"mvc.1.0.view", @"/Views/Purchases/DisplayPurchases.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33ad3e9f9159eae237ee19780f293d700ba7490", @"/Views/Purchases/DisplayPurchases.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65a8198b297c3ea7f3bc4f7f8cdac67c148a265", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchases_DisplayPurchases : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
  
    ViewData["Title"] = "My Purchases";
    List<Purchases> purchases = (List<Purchases>)ViewData["purchases"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #empty {
        text-align: center;
        font-weight: bold;
        font-size: 36px;
    }

    .dl-button {
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

    .purchases-table {
        width: 90%;
        margin-left: 5%;
        margin-right: 5%;
        border-collapse: separate;
        border-spacing: 0 1em;
    }

    .purchases-table button {
        width: 100%;
    }

    .purchases-table td {
        padding: 10px;
    }

    .purchases-table tr {
        background-color: #f7f7f7;
    }

    .purchases-table img {
        width: 80%;
    }

    .in-table {
        border: none;
    }

    .purchases-table .in-table {
        width: 100%;
        position: relative;
        top: 0px;
        border-col");
            WriteLiteral(@"lapse: separate;
        border-spacing: 0px;
        text-align: left;
    }

    h2 {
        font-size: 16px;
    }

    .purchases-table .in-table td {
        padding: 3px;
        vertical-align: top;
    }

    .cell {
        vertical-align: top;
    }

    .image {
        height: 300px;
        width: 100px;
    }
</style>

<div id=""header"">
    <header>
        <h1>My Purchases</h1>
    </header>
    <a href=""/Product/DisplayProduct""><u>Home</u></a> | <a href=""/Logout/Index""><u>Logout</u></a>
</div>
<div id=""body"">
");
#nullable restore
#line 89 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
     if (purchases.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span id=\"empty\" style=\"display:block\">\r\n            <br /><br /><br />\r\n            You Have No Purchases\r\n        </span>\r\n");
#nullable restore
#line 95 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"purchases-table\">\r\n");
#nullable restore
#line 99 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
              
                foreach (Purchases purchase in purchases) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                                                                         
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td width=\"50%\">\r\n                            <h2><b>");
#nullable restore
#line 104 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                              Write(purchase.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                            <br />\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2270, "\"", 2296, 2);
            WriteAttributeValue("", 2276, "/img/", 2276, 5, true);
#nullable restore
#line 106 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
WriteAttributeValue("", 2281, purchase.Image, 2281, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image\" />\r\n                            <br />\r\n                            <p>");
#nullable restore
#line 108 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                          Write(purchase.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </td>\r\n                        <td>\r\n                            <table class=\"in-table\">\r\n                                <tr><td>Date Purchased:</td><td>");
#nullable restore
#line 112 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                                           Write(purchase.PurchaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                <tr><td>Quantity:</td><td>");
#nullable restore
#line 113 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                                     Write(purchase.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                <tr>\r\n                                    <td>Activation Code:</td>\r\n");
#nullable restore
#line 116 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                     if (purchase.Quantity == 1)

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                                                                                                                                   
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 118 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                       Write(purchase.ActivationCode[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 119 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            <select name=\"code\">\r\n");
#nullable restore
#line 124 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                                 foreach (string code in purchase.ActivationCode)

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                                                                                                                                           
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a33ad3e9f9159eae237ee19780f293d700ba749010756", async() => {
#nullable restore
#line 126 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                                                     Write(code);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                                       WriteLiteral(code);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 127 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </select>\r\n                                        </td>\r\n");
#nullable restore
#line 130 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tr>
                            </table>
                            <button onclick="" window.open('https://www.iss.nus.edu.sg/graduate-programmes/programme/detail/graduate-diploma-in-systems-analysis', '_target');"" type=""button"" class=""dl-button"">Download</button>
                        </td>
                    </tr>
");
#nullable restore
#line 136 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 139 "C:\Users\shame\Documents\GitHub\ShoppingCart\ShoppingCart\Views\Purchases\DisplayPurchases.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
