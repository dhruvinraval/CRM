#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f29247c67b549d84413bcbb7a28336e29e124283"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Complain), @"mvc.1.0.view", @"/Views/Customer/Complain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Complain.cshtml", typeof(AspNetCore.Views_Customer_Complain))]
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
#line 1 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\_ViewImports.cshtml"
using VIPL_CRM;

#line default
#line hidden
#line 2 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\_ViewImports.cshtml"
using VIPL_CRM.Models;

#line default
#line hidden
#line 1 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
using System.Data;

#line default
#line hidden
#line 2 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f29247c67b549d84413bcbb7a28336e29e124283", @"/Views/Customer/Complain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Complain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<complain>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
  
    ViewData["Title"] = "Complain";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 151, "\"", 173, 1);
#line 8 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
WriteAttributeValue("", 159, ViewBag.Class, 159, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(174, 7, true);
            WriteLiteral(">\r\n    ");
            EndContext();
            BeginContext(182, 11, false);
#line 9 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(193, 121, true);
            WriteLiteral("\r\n</div>\r\n\r\n<style>\r\n\r\n    .error {\r\n        color: red;\r\n    }\r\n</style>\r\n<h1>Register Your Complain here</h1>\r\n<hr />\r\n");
            EndContext();
#line 20 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
 using (Html.BeginForm("Complain", "Customer", FormMethod.Post, htmlAttributes: new { @enctype = "multipart/form-data" }))
{

#line default
#line hidden
            BeginContext(441, 79, true);
            WriteLiteral("    <div class=\"container\">\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(521, 27, false);
#line 26 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
       Write(Html.HiddenFor(m => m.SrNo));

#line default
#line hidden
            EndContext();
            BeginContext(548, 127, true);
            WriteLiteral("\r\n            <label class=\"control-label col-sm-3 \">Enter Name  </label>\r\n            <div class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(676, 61, false);
#line 29 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
           Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(737, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(756, 68, false);
#line 30 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
           Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(824, 201, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n\r\n            <label class=\"control-label col-sm-3 \">Enter Place </label>\r\n            <div class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1026, 62, false);
#line 38 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
           Write(Html.TextBoxFor(m => m.Place, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1107, 69, false);
#line 39 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
           Write(Html.ValidationMessageFor(m => m.Place, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 207, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n\r\n            <label class=\"control-label col-sm-3 \">Enter Contact No  </label>\r\n            <div class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1384, 66, false);
#line 47 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
           Write(Html.TextBoxFor(m => m.ContactNo, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1469, 73, false);
#line 48 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
           Write(Html.ValidationMessageFor(m => m.ContactNo, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(1542, 204, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n\r\n            <label class=\"control-label col-sm-3 \">Software Name  </label>\r\n            <div class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1747, 69, false);
#line 56 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
           Write(Html.TextBoxFor(m => m.SoftwareName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1816, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1835, 76, false);
#line 57 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
           Write(Html.ValidationMessageFor(m => m.SoftwareName, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 560, true);
            WriteLiteral(@"
            </div>

        </div>
        <div class=""form-group"">

            <label class=""control-label col-sm-3 "">Problem With Software  </label>
            <div class=""col-sm-3"">
                
                <textarea cols=""15"" rows=""7"" class=""form-control"" id=""Problem"" name=""Problem"" style=""resize:none;"" required></textarea>

            </div>

        </div>
        <div class=""form-group col-sm-2"">
            <input type=""submit"" name=""submit"" value=""Send"" id=""Save"" class=""btn btn-success"" />
        </div>
    </div>
");
            EndContext();
#line 75 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\Complain.cshtml"
}

#line default
#line hidden
            BeginContext(2474, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f29247c67b549d84413bcbb7a28336e29e12428311099", async() => {
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
            EndContext();
            BeginContext(2525, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2527, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f29247c67b549d84413bcbb7a28336e29e12428312279", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2598, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2600, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f29247c67b549d84413bcbb7a28336e29e12428313459", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2690, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<complain> Html { get; private set; }
    }
}
#pragma warning restore 1591
