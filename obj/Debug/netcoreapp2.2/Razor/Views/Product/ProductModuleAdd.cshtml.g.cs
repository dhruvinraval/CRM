#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa6010d86c754c3bf365ab6221542eb26c907d09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductModuleAdd), @"mvc.1.0.view", @"/Views/Product/ProductModuleAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductModuleAdd.cshtml", typeof(AspNetCore.Views_Product_ProductModuleAdd))]
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
#line 1 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa6010d86c754c3bf365ab6221542eb26c907d09", @"/Views/Product/ProductModuleAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductModuleAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mst_product_module>
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
#line 3 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
  
    ViewData["Title"] = "Product Module";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(139, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aa6010d86c754c3bf365ab6221542eb26c907d096148", async() => {
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
            BeginContext(191, 5, true);
            WriteLiteral("\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 196, "\"", 218, 1);
#line 10 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
WriteAttributeValue("", 204, ViewBag.Class, 204, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(219, 6, true);
            WriteLiteral(">\n    ");
            EndContext();
            BeginContext(226, 11, false);
#line 11 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(237, 218, true);
            WriteLiteral("\n</div>\n<nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\n    <div class=\"collapse navbar-collapse\" id=\"navbarTogglerDemo01\">\n        <a class=\"navbar-brand\" href=\"#\">Create Product Module</a>\n    </div>\n    ");
            EndContext();
            BeginContext(455, 240, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6010d86c754c3bf365ab6221542eb26c907d098356", async() => {
                BeginContext(506, 182, true);
                WriteLiteral("\n        <a href=\"../Product/ProductModuleIndex\" class=\"btn btn-outline-info pull-right\">\n            <i class=\"fa fa-list-alt\"></i> &nbsp;\n            Back To List\n        </a>\n    ");
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
            BeginContext(695, 15, true);
            WriteLiteral("\n</nav>\n<br />\n");
            EndContext();
#line 25 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
  
    List<iv_LinkName> iv_list = new List<iv_LinkName>();
    int total = 0;
    iv_list = iv_LinkName.GetAll(1, 1000, 11, ref total, "");

    

#line default
#line hidden
#line 30 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
     using (Html.BeginForm("ProductModuleAdd", "Product", FormMethod.Post, new { @class = "form-horizontal" }))
    {

#line default
#line hidden
            BeginContext(970, 216, true);
            WriteLiteral("        <div class=\"container\">\n            <div class=\"row\">\n                <div class=\"col-md-6\">\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Product*</label>\n");
            EndContext();
#line 37 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                          
                            List<mst_product> lst = new List<mst_product>();
                            lst = mst_product.GetAll(1, 1000, 11, ref total, "");
                            

#line default
#line hidden
            BeginContext(1401, 126, false);
#line 40 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                       Write(Html.DropDownListFor(m => m.Mst_Product_SrNo, new SelectList(lst, "SrNo", "ProductName", ""), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1579, 86, false);
#line 42 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Mst_Product_SrNo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 97, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
            EndContext();
            BeginContext(1763, 27, false);
#line 45 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.HiddenFor(m => m.SrNo));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 48, true);
            WriteLiteral("\n                        <label>Status*</label>\n");
            EndContext();
#line 47 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                         if (Model != null)
                        {

                            

#line default
#line hidden
#line 50 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                             if (Model.Status == 'T')
                            {

#line default
#line hidden
            BeginContext(1993, 231, true);
            WriteLiteral("                                <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"T\" checked /><label>Active</label>\n                                <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"F\" /><label>Block</label>\n");
            EndContext();
            BeginContext(2257, 76, false);
#line 54 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 54 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                                                                                                             
                            }
                            else if (Model.Status == 'F')
                            {

#line default
#line hidden
            BeginContext(2452, 231, true);
            WriteLiteral("                                <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"I\" /><label>Active</label>\n                                <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"F\" checked /><label>Block</label>\n");
            EndContext();
            BeginContext(2716, 76, false);
#line 60 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 60 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                                                                                                             
                            }

#line default
#line hidden
#line 61 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2904, 223, true);
            WriteLiteral("                            <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"T\" checked /><label>Active</label>\n                            <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"F\" /><label>Block</label>\n");
            EndContext();
            BeginContext(3156, 76, false);
#line 67 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 67 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                                                                                                         
                        }

#line default
#line hidden
            BeginContext(3259, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3284, 76, false);
#line 69 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3360, 173, true);
            WriteLiteral("\n\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Module Name*</label>\n\n                        ");
            EndContext();
            BeginContext(3534, 67, false);
#line 75 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.TextBoxFor(m => m.ModuleName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3601, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(3627, 80, false);
#line 76 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.ModuleName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3707, 149, true);
            WriteLiteral("\n                    </div>\n\n                    <div class=\"form-group\">\n                        <label>Start Date*</label>\n                        ");
            EndContext();
            BeginContext(3857, 66, false);
#line 81 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.TextBoxFor(m => m.StartDate, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3923, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(3949, 79, false);
#line 82 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.StartDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4028, 147, true);
            WriteLiteral("\n                    </div>\n\n                    <div class=\"form-group\">\n                        <label>End Date*</label>\n                        ");
            EndContext();
            BeginContext(4176, 64, false);
#line 87 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.TextBoxFor(m => m.EndDate, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4240, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(4266, 77, false);
#line 88 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.EndDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4343, 233, true);
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-6\">\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">VideoLinkMkt</label>\n                        ");
            EndContext();
            BeginContext(4577, 120, false);
#line 94 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.DropDownListFor(m => m.VideoLinkMkt, new SelectList(iv_list, "SrNo", "BriefName"), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4697, 175, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">VideoLinkSupport</label>\n                        ");
            EndContext();
            BeginContext(4873, 124, false);
#line 98 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.DropDownListFor(m => m.VideoLinkSupport, new SelectList(iv_list, "SrNo", "BriefName"), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4997, 176, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">VideoLinkCustomer</label>\n                        ");
            EndContext();
            BeginContext(5174, 125, false);
#line 102 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.DropDownListFor(m => m.VideoLinkCustomer, new SelectList(iv_list, "SrNo", "BriefName"), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5299, 166, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Remark:</label>\n                        ");
            EndContext();
            BeginContext(5466, 63, false);
#line 106 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"
                   Write(Html.TextBoxFor(m => m.Remark, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5529, 267, true);
            WriteLiteral(@"
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" name=""submit"" value=""Save"" class=""btn btn-success btn-block"" />
                    </div>
                </div>

            </div>
        </div>
");
            EndContext();
#line 115 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductModuleAdd.cshtml"

    }

#line default
#line hidden
            BeginContext(5805, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(5806, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6010d86c754c3bf365ab6221542eb26c907d0922729", async() => {
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
            BeginContext(5860, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(5861, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6010d86c754c3bf365ab6221542eb26c907d0923907", async() => {
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
            BeginContext(5932, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(5933, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6010d86c754c3bf365ab6221542eb26c907d0925085", async() => {
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
            BeginContext(6023, 1203, true);
            WriteLiteral(@"
<script>
    $(function () {
        $(""#StartDate"").datepicker({
            dateFormat: ""dd/mm/yy""
        });

        var x = $(""#StartDate"").val();
        if (x != """") {
            var inputval = x.split("" "");
            var dateval = new Date(inputval[0]);
            var month = (""0"" + (dateval.getMonth() + 1)).slice(-2);
            var day = (""0"" + dateval.getDate()).slice(-2)
            var year = dateval.getUTCFullYear();

            var dt = day + ""/"" + month + ""/"" + year;
            $(""#StartDate"").val(dt);
        } else {
            $(""#StartDate"").val("""");
        }

    });
    $(function () {
        $(""#EndDate"").datepicker({
            dateFormat: ""dd/mm/yy""
        });

        var x = $(""#EndDate"").val();
        if (x != """") {
            var inputval = x.split("" "");
            var dateval = new Date(inputval[0]);
            var month = (""0"" + (dateval.getMonth() + 1)).slice(-2);
            var day = (""0"" + dateval.getDate()).slice(-2)
            var year = dateval.getUTCFu");
            WriteLiteral("llYear();\n\n            var dt = day + \"/\" + month + \"/\" + year;\n            $(\"#EndDate\").val(dt);\n        } else {\n            $(\"#EndDate\").val(\"\");\n        }\n\n    });\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mst_product_module> Html { get; private set; }
    }
}
#pragma warning restore 1591
