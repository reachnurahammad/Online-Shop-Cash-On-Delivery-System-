#pragma checksum "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Lux.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ba0b87f373ed5191d4f35a18b8c3ba979a15245"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lux), @"mvc.1.0.view", @"/Views/Home/Lux.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Lux.cshtml", typeof(AspNetCore.Views_Home_Lux))]
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
#line 1 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#line 2 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ba0b87f373ed5191d4f35a18b8c3ba979a15245", @"/Views/Home/Lux.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lux : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Models.Lux>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LuxAddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Lux.cshtml"
  
    ViewData["Title"] = "Lux";

#line default
#line hidden
            BeginContext(78, 52, true);
            WriteLiteral("<div class=\"offset-5\">\r\n    <h1>Lux</h1>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2492, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2522, 19, true);
            WriteLiteral("<div class=\"row\">\r\n");
            EndContext();
#line 80 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Lux.cshtml"
     foreach (var item in Model)
    {

        

#line default
#line hidden
            BeginContext(2655, 217, true);
            WriteLiteral("        <div class=\"col-md-2\" style=\"margin-top:10px; margin-bottom:95px; margin-left:2%;\">\r\n            <div style=\"height: 180px; width: 150px; background-color:#ffffff ; margin-top: 30px; \">\r\n\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2872, "\"", 2893, 1);
#line 88 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Lux.cshtml"
WriteAttributeValue("", 2878, item.ImageFile, 2878, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2894, 298, true);
            WriteLiteral(@" alt=""Product Image"" style=""height: 180px; width: 270px; border: 1px solid #64696d; border-bottom:none;"" />

                <div style=""background-color: white; width:270px; border: 1px solid #64696d; border-top:none;"">
                    <div class=""offset-1 "">
                        <h6> ");
            EndContext();
            BeginContext(3193, 12, false);
#line 92 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Lux.cshtml"
                        Write(item.Details);

#line default
#line hidden
            EndContext();
            BeginContext(3205, 42, true);
            WriteLiteral("</h6>\r\n                        <p1>Price: ");
            EndContext();
            BeginContext(3248, 10, false);
#line 93 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Lux.cshtml"
                              Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3258, 7, true);
            WriteLiteral("</p1>\r\n");
            EndContext();
            BeginContext(3308, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3332, 403, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ba0b87f373ed5191d4f35a18b8c3ba979a152456832", async() => {
                BeginContext(3398, 61, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"pid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3459, "\"", 3475, 1);
#line 96 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Lux.cshtml"
WriteAttributeValue("", 3467, item.Id, 3467, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3476, 252, true);
                WriteLiteral(" />\r\n                            <input type=\"number\" name=\"qty\" value=\"1\" class=\"form-control\" style=\"width:60px;\" />\r\n                            <button class=\"btn btn-primary btn-sm ml-1\" type=\"submit\">Add To Cart</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3735, 96, true);
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 104 "C:\Users\88017\OneDrive\Desktop\Test1\Test1\Test\Views\Home\Lux.cshtml"
    }

#line default
#line hidden
            BeginContext(3838, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.Models.Lux>> Html { get; private set; }
    }
}
#pragma warning restore 1591