#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1dbc37f02aedfda8acd0beb61edab282d393608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductSubCategoryAdd), @"mvc.1.0.view", @"/Views/Product/ProductSubCategoryAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductSubCategoryAdd.cshtml", typeof(AspNetCore.Views_Product_ProductSubCategoryAdd))]
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
#line 1 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1dbc37f02aedfda8acd0beb61edab282d393608", @"/Views/Product/ProductSubCategoryAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductSubCategoryAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mst_productsubcategory>
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
#line 3 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
  
    ViewData["Title"] = "Product Sub Category";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b1dbc37f02aedfda8acd0beb61edab282d3936086100", async() => {
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
            BeginContext(199, 5, true);
            WriteLiteral("\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 204, "\"", 226, 1);
#line 8 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
WriteAttributeValue("", 212, ViewBag.Class, 212, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(227, 6, true);
            WriteLiteral(">\n    ");
            EndContext();
            BeginContext(234, 11, false);
#line 9 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(245, 224, true);
            WriteLiteral("\n</div>\n<nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\n    <div class=\"collapse navbar-collapse\" id=\"navbarTogglerDemo01\">\n        <a class=\"navbar-brand\" href=\"#\">Create Product Sub Category</a>\n    </div>\n    ");
            EndContext();
            BeginContext(469, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1dbc37f02aedfda8acd0beb61edab282d3936088322", async() => {
                BeginContext(520, 187, true);
                WriteLiteral("\n        <a href=\"../Product/ProductSubCategoryIndex\" class=\"btn btn-outline-info pull-right\">\n            <i class=\"fa fa-list-alt\"></i> &nbsp;\n            Back To List\n        </a>\n    ");
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
            BeginContext(714, 15, true);
            WriteLiteral("\n</nav>\n<br />\n");
            EndContext();
#line 23 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
 using (Html.BeginForm("ProductSubCategoryAdd", "Product", FormMethod.Post, new { @class = "form-horizontal" }))
{

#line default
#line hidden
            BeginContext(844, 150, true);
            WriteLiteral("    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(995, 27, false);
#line 29 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
               Write(Html.HiddenFor(m => m.SrNo));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 50, true);
            WriteLiteral("\n                    <label>Status*</label>&nbsp;\n");
            EndContext();
#line 31 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                     if (Model != null)
                    {

                        

#line default
#line hidden
#line 34 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                         if (Model.Status == 'T')
                        {

#line default
#line hidden
            BeginContext(1211, 223, true);
            WriteLiteral("                            <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"T\" checked /><label>Active</label>\n                            <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"F\" /><label>Block</label>\n");
            EndContext();
            BeginContext(1463, 76, false);
#line 38 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 38 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                                                                                                         
                        }
                        else if (Model.Status == 'F')
                        {

#line default
#line hidden
            BeginContext(1646, 223, true);
            WriteLiteral("                            <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"I\" /><label>Active</label>\n                            <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"F\" checked /><label>Block</label>\n");
            EndContext();
            BeginContext(1898, 76, false);
#line 44 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 44 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                                                                                                         
                        }

#line default
#line hidden
#line 45 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2070, 215, true);
            WriteLiteral("                        <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"T\" checked /><label>Active</label>\n                        <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"F\" /><label>Block</label>\n");
            EndContext();
            BeginContext(2310, 76, false);
#line 51 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 51 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                                                                                                     
                    }

#line default
#line hidden
            BeginContext(2409, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2430, 76, false);
#line 53 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
               Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2506, 138, true);
            WriteLiteral("\n\n                </div>\n\n                <div class=\"form-group\">\n                    <label class=\"control-label\">Product Name*</label>\n");
            EndContext();
#line 59 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                      
                        List<mst_productcategory> lst = new List<mst_productcategory>();
                        int total = 0, i = 1;
                        lst = mst_productcategory.GetAll(i, 1000, 11, ref total, "");
                        if (total > 1000)
                        {
                            float pg = (float)total / 1000;
                            int x = Convert.ToInt32(pg.ToString().Substring(pg.ToString().IndexOf('.') + 1));
                            if (x > 0)
                            {
                                x = x + 1;
                            }
                            if (x > 1)
                            {
                                while (x > 1)
                                {
                                    i++;
                                    lst.AddRange(mst_productcategory.GetAll(i, 1000, 11, ref total, ""));
                                    x--;
                                }
                            }
                        }
                        

#line default
#line hidden
            BeginContext(3720, 138, false);
#line 81 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                   Write(Html.DropDownListFor(m => m.Mst_ProductCategory_SrNo, new SelectList(lst, "SrNo", "ProductCategory", ""), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3881, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(3902, 94, false);
#line 83 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
               Write(Html.ValidationMessageFor(m => m.Mst_ProductCategory_SrNo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3996, 169, true);
            WriteLiteral("\n                </div>\n\n                <div class=\"form-group\">\n                    <label class=\"control-label\">ProductSubCategory Name*</label>\n\n                    ");
            EndContext();
            BeginContext(4166, 79, false);
#line 89 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
               Write(Html.TextBoxFor(m => m.ProductSubCategoryName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4245, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(4267, 92, false);
#line 90 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
               Write(Html.ValidationMessageFor(m => m.ProductSubCategoryName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4359, 135, true);
            WriteLiteral("\n                </div>\n                <div class=\"form-group\">\n                    <label class=\"control-label\">Image/Video*</label>\n");
            EndContext();
#line 94 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                      
                        List<iv_LinkName> iv_list = new List<iv_LinkName>();
                        total = 0;
                        i = 1;
                        iv_list = iv_LinkName.GetAll(i, 1000, 11, ref total, "");
                        if (total > 1000)
                        {
                            float pg = (float)total / 1000;
                            int x = Convert.ToInt32(pg.ToString().Substring(pg.ToString().IndexOf('.') + 1));
                            if (x > 0)
                            {
                                x = x + 1;
                            }
                            if (x > 1)
                            {
                                while (x > 1)
                                {
                                    i++;
                                    iv_list.AddRange(iv_LinkName.GetAll(i, 1000, 11, ref total, ""));
                                    x--;
                                }
                            }
                        }
                        

#line default
#line hidden
            BeginContext(5570, 124, false);
#line 117 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
                   Write(Html.DropDownListFor(m => m.IV_LinkName_SrNo, new SelectList(iv_list, "SrNo", "BriefName"), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(5717, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(5738, 86, false);
#line 119 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
               Write(Html.ValidationMessageFor(m => m.IV_LinkName_SrNo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5824, 150, true);
            WriteLiteral("\n                </div>\n                <div class=\"form-group\">\n                    <label class=\"control-label\">Remark:</label>\n                    ");
            EndContext();
            BeginContext(5975, 63, false);
#line 123 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"
               Write(Html.TextBoxFor(m => m.Remark, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(6038, 280, true);
            WriteLiteral(@"
                </div>
                <div class=""form-group"">
                    <input type=""submit"" name=""submit"" value=""Save"" class=""btn btn-success btn-block"" />
                </div>
            </div>
            <div class=""col-md-6""></div>

        </div>
    </div>
");
            EndContext();
#line 133 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductSubCategoryAdd.cshtml"

}

#line default
#line hidden
            BeginContext(6321, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(6322, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1dbc37f02aedfda8acd0beb61edab282d39360821571", async() => {
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
            BeginContext(6376, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(6377, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1dbc37f02aedfda8acd0beb61edab282d39360822749", async() => {
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
            BeginContext(6448, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(6449, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1dbc37f02aedfda8acd0beb61edab282d39360823927", async() => {
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
            BeginContext(6539, 3, true);
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mst_productsubcategory> Html { get; private set; }
    }
}
#pragma warning restore 1591