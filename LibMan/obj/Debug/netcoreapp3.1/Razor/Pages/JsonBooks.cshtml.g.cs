#pragma checksum "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "905d81d9f942277221b10f85ae63306ee3907a93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LibMan.Pages.Pages_JsonBooks), @"mvc.1.0.razor-page", @"/Pages/JsonBooks.cshtml")]
namespace LibMan.Pages
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
#line 1 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\_ViewImports.cshtml"
using LibMan;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905d81d9f942277221b10f85ae63306ee3907a93", @"/Pages/JsonBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"556363eee37c7022f4ee8212d5634b573aa7dc0b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_JsonBooks : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
  
    ViewData["Title"] = "Facilities";
    Layout = "~/Pages/Shared/_LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    body {
        font-family: Arial, Helvetica, sans-serif;
    }

    .flip-card {
        background-color: transparent;
        width: 300px;
        height: 400px;
        perspective: 1000px;
        display: inline-block;
    }

    .flip-card-inner {
        position: relative;
        width: 100%;
        height: 100%;
        text-align: center;
        transition: transform 0.6s;
        transform-style: preserve-3d;
        box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
    }

    .flip-card:hover .flip-card-inner {
        transform: rotateY(180deg);
    }

    .flip-card-front, .flip-card-back {
        position: absolute;
        width: 100%;
        height: 100%;
        -webkit-backface-visibility: hidden;
        backface-visibility: hidden;
    }

    .flip-card-front {
        background-color: #bbb;
        color: black;
    }

    .flip-card-back {
        background-color: #ffe6b3;
        color: white;
        transform: rotateY(180deg);
 ");
            WriteLiteral("   }\r\n</style>\r\n<br />\r\n<h2><center>Welcome To Your JSON Library!</center></h2>\r\n<br /><br /><br /><br />\r\n\r\n");
#nullable restore
#line 57 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
 foreach (var product in Model.Products)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"flip-card\">\r\n\r\n        <div class=\"flip-card-inner\">\r\n            <div class=\"flip-card-front\"");
            BeginWriteAttribute("style", " style=\"", 1428, "\"", 1537, 8);
            WriteAttributeValue("        ", 1436, "background-image:", 1444, 25, true);
            WriteAttributeValue(" ", 1461, "url(\'", 1462, 6, true);
#nullable restore
#line 62 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
WriteAttributeValue("", 1467, product.Image, 1467, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1481, "\');", 1481, 3, true);
            WriteAttributeValue(" ", 1484, "background-size:", 1485, 17, true);
            WriteAttributeValue(" ", 1501, "100%;", 1502, 6, true);
            WriteAttributeValue(" ", 1507, "background-repeat:", 1508, 19, true);
            WriteAttributeValue(" ", 1526, "no-repeat;", 1527, 11, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"flip-card-back\" style=\"overflow:scroll;\">\r\n                <br></br>\r\n                <h5 class=\"card-title\" style=\"color: #000000;\"><b>Title:</b> ");
#nullable restore
#line 66 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
                                                                        Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"card-title\" style=\"color: #000000;\"><b>Author:</b> ");
#nullable restore
#line 67 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
                                                                         Write(product.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"card-title\" style=\"color: #000000;\"><b>Translator:</b> ");
#nullable restore
#line 68 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
                                                                             Write(product.Translator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"card-title\" style=\"color: #000000;\"><b>Publisher:</b> ");
#nullable restore
#line 69 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
                                                                            Write(product.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"card-title\" style=\"color: #000000;\"><b>Catagories:</b> ");
#nullable restore
#line 70 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
                                                                             Write(product.Catagories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"card-title\" style=\"color: #000000;\"><b>Status:</b> ");
#nullable restore
#line 71 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
                                                                         Write(product.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"card-title\" style=\"color: #000000;\"><b>Description:</b> ");
#nullable restore
#line 72 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
                                                                              Write(product.Descripton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h5 class=\"card-title\" style=\"color: #000000;\"><b>Rate:</b> ");
#nullable restore
#line 73 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
                                                                       Write(product.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 78 "D:\Windows.old\Users\Mert\source\repos\LibMan\LibMan\Pages\JsonBooks.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LibMan.Pages.JsonBooksModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LibMan.Pages.JsonBooksModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LibMan.Pages.JsonBooksModel>)PageContext?.ViewData;
        public LibMan.Pages.JsonBooksModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
