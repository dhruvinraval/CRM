#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cce95994162bbee5d27046e9b6d023bb8bee69e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_PVChangesAdd), @"mvc.1.0.view", @"/Views/Product/PVChangesAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/PVChangesAdd.cshtml", typeof(AspNetCore.Views_Product_PVChangesAdd))]
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
#line 1 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cce95994162bbee5d27046e9b6d023bb8bee69e", @"/Views/Product/PVChangesAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_PVChangesAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mst_pvchanges>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0 float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
  
    ViewData["Title"] = "PVChanges";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(128, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7cce95994162bbee5d27046e9b6d023bb8bee69e6100", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(180, 5, true);
            WriteLiteral("\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 185, "\"", 207, 1);
#line 9 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
WriteAttributeValue("", 193, ViewBag.Class, 193, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(208, 6, true);
            WriteLiteral(">\n    ");
            EndContext();
            BeginContext(215, 11, false);
#line 10 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(226, 226, true);
            WriteLiteral("\n</div>\n<nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\n    <div class=\"collapse navbar-collapse\" id=\"navbarTogglerDemo01\">\n        <a class=\"navbar-brand\" href=\"#\">Create Product Version Change</a>\n    </div>\n    ");
            EndContext();
            BeginContext(452, 236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cce95994162bbee5d27046e9b6d023bb8bee69e8307", async() => {
                BeginContext(503, 178, true);
                WriteLiteral("\n        <a href=\"../Product/PVChangesIndex\" class=\"btn btn-outline-info pull-right\">\n            <i class=\"fa fa-list-alt\"></i> &nbsp;\n            Back To List\n        </a>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(688, 15, true);
            WriteLiteral("\n</nav>\n<br />\n");
            EndContext();
#line 24 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
  
    List<iv_LinkName> iv_list = new List<iv_LinkName>();
    int total = 0;
    iv_list = iv_LinkName.GetAll(1, 1000, 11, ref total, "");

    

#line default
#line hidden
#line 29 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
     using (Html.BeginForm("PVChangesAdd", "Product", FormMethod.Post, new { @class = "form-horizontal" }))
    {

#line default
#line hidden
            BeginContext(959, 248, true);
            WriteLiteral("        <div class=\"container\">\n            <div class=\"row\">\n                <div class=\"col-md-6\">\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Product Version*</label>\n                        ");
            EndContext();
            BeginContext(1208, 27, false);
#line 36 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                   Write(Html.HiddenFor(m => m.SrNo));

#line default
#line hidden
            EndContext();
            BeginContext(1235, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 37 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                          
                            List<mst_productversion> lst = new List<mst_productversion>();
                            lst = mst_productversion.GetAll(1, 1000, 11, ref total, "");
                            

#line default
#line hidden
            BeginContext(1472, 128, false);
#line 40 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                       Write(Html.DropDownListFor(m => m.Mst_ProductVerSrNo, new SelectList(lst, "SrNo", "VersionName", ""), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1627, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1652, 88, false);
#line 42 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Mst_ProductVerSrNo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 150, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Product Module*</label>\n");
            EndContext();
#line 46 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                          
                            List<mst_product_module> lst1 = new List<mst_product_module>();
                            lst1 = mst_product_module.GetAll(1, 1000, 11, ref total, "");
                            

#line default
#line hidden
            BeginContext(2128, 133, false);
#line 49 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                       Write(Html.DropDownListFor(m => m.Mst_Product_Module_SrNo, new SelectList(lst1, "SrNo", "ModuleName", ""), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2288, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2313, 93, false);
#line 51 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Mst_Product_Module_SrNo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2406, 168, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Changes*</label>\n\n                        ");
            EndContext();
            BeginContext(2575, 68, false);
#line 56 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                   Write(Html.TextBoxFor(m => m.WhatChanges, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2643, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2669, 81, false);
#line 57 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.WhatChanges, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2750, 164, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Video</label>\n                        ");
            EndContext();
            BeginContext(2915, 117, false);
#line 61 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                   Write(Html.DropDownListFor(m => m.VideoLink, new SelectList(iv_list, "SrNo", "BriefName"), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3032, 166, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Remark:</label>\n                        ");
            EndContext();
            BeginContext(3199, 63, false);
#line 65 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"
                   Write(Html.TextBoxFor(m => m.Remark, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3262, 350, true);
            WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" name=""submit"" value=""Save"" class=""btn btn-success btn-block"" />
                    </div>
                </div>
                <div class=""col-md-6"">
                    
                </div>

            </div>
        </div>
");
            EndContext();
#line 77 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\PVChangesAdd.cshtml"

    }

#line default
#line hidden
            BeginContext(3621, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(3622, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cce95994162bbee5d27046e9b6d023bb8bee69e16686", async() => {
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
            BeginContext(3676, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(3677, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cce95994162bbee5d27046e9b6d023bb8bee69e17864", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3748, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(3749, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cce95994162bbee5d27046e9b6d023bb8bee69e19042", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3839, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mst_pvchanges> Html { get; private set; }
    }
}
#pragma warning restore 1591
