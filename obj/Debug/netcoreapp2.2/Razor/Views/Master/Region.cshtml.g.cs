#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "923d9ce504db7f98dff3dced3d15bf7750265ce5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_Region), @"mvc.1.0.view", @"/Views/Master/Region.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Master/Region.cshtml", typeof(AspNetCore.Views_Master_Region))]
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
#line 2 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
using System.Data;

#line default
#line hidden
#line 3 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"923d9ce504db7f98dff3dced3d15bf7750265ce5", @"/Views/Master/Region.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_Master_Region : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<region>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0 float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
  
    ViewData["Title"] = "Region";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 141, "\"", 163, 1);
#line 9 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
WriteAttributeValue("", 149, ViewBag.Class, 149, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(164, 6, true);
            WriteLiteral(">\n    ");
            EndContext();
            BeginContext(171, 11, false);
#line 10 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(182, 268, true);
            WriteLiteral(@"
</div>
<style>
    .error {
        color: red;
    }
</style>

<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
    <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo01"">
        <a class=""navbar-brand"" href=""#"">Add New Region</a>
    </div>
    ");
            EndContext();
            BeginContext(450, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "923d9ce504db7f98dff3dced3d15bf7750265ce56528", async() => {
                BeginContext(501, 150, true);
                WriteLiteral("\n        <a href=\"../Master/RegionList\" class=\"btn btn-outline-info pull-right\">\n            <i class=\"fa fa-list\"></i> Back To List\n        </a>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(658, 15, true);
            WriteLiteral("\n</nav>\n<br />\n");
            EndContext();
#line 29 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
 using (Html.BeginForm("Region", "Master", FormMethod.Post, new { @class = "form-horizontal" }))
{

#line default
#line hidden
            BeginContext(772, 73, true);
            WriteLiteral("    <div class=\"container\">\n        <div class=\"form-group\">\n            ");
            EndContext();
            BeginContext(846, 27, false);
#line 33 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
       Write(Html.HiddenFor(m => m.SrNo));

#line default
#line hidden
            EndContext();
            BeginContext(873, 144, true);
            WriteLiteral("\n\n            <label class=\"control-label col-sm-3 \">Enter Region Name  </label>\n\n            <div class=\"form-group col-sm-3\">\n                ");
            EndContext();
            BeginContext(1018, 67, false);
#line 38 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
           Write(Html.TextBoxFor(m => m.RegionName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1103, 74, false);
#line 39 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
           Write(Html.ValidationMessageFor(m => m.RegionName, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 206, true);
            WriteLiteral("\n            </div>\n\n        </div>\n        <div class=\"form-group\">\n            <label class=\"control-label col-sm-3 \">Enter Remark  </label>\n\n            <div class=\"form-group col-sm-3\">\n                ");
            EndContext();
            BeginContext(1384, 63, false);
#line 47 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
           Write(Html.TextBoxFor(m => m.Remark, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1465, 70, false);
#line 48 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
           Write(Html.ValidationMessageFor(m => m.Remark, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 212, true);
            WriteLiteral("\n            </div>\n        </div>\n\n        <div class=\"form-group col-sm-2\">\n            <input type=\"submit\" name=\"submit\" value=\"Save\" id=\"Save\" class=\"btn btn-success\" />\n        </div>\n    </div>\n    <br />\n");
            EndContext();
#line 57 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Master\Region.cshtml"
}

#line default
#line hidden
            BeginContext(1749, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "923d9ce504db7f98dff3dced3d15bf7750265ce511213", async() => {
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
            BeginContext(1800, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1801, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "923d9ce504db7f98dff3dced3d15bf7750265ce512391", async() => {
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
            BeginContext(1872, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1873, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "923d9ce504db7f98dff3dced3d15bf7750265ce513569", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<region> Html { get; private set; }
    }
}
#pragma warning restore 1591