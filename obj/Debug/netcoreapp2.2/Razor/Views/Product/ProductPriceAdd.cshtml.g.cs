#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e053df4639e254ddced064e0557ebca568186110"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductPriceAdd), @"mvc.1.0.view", @"/Views/Product/ProductPriceAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductPriceAdd.cshtml", typeof(AspNetCore.Views_Product_ProductPriceAdd))]
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
#line 1 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e053df4639e254ddced064e0557ebca568186110", @"/Views/Product/ProductPriceAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductPriceAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mst_productprice>
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
#line 3 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
  
    ViewData["Title"] = "Product Price";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e053df4639e254ddced064e0557ebca5681861106033", async() => {
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
            BeginContext(186, 5, true);
            WriteLiteral("\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 191, "\"", 213, 1);
#line 8 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
WriteAttributeValue("", 199, ViewBag.Class, 199, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(214, 6, true);
            WriteLiteral(">\n    ");
            EndContext();
            BeginContext(221, 11, false);
#line 9 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(232, 217, true);
            WriteLiteral("\n</div>\n<nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\n    <div class=\"collapse navbar-collapse\" id=\"navbarTogglerDemo01\">\n        <a class=\"navbar-brand\" href=\"#\">Create Product Price</a>\n    </div>\n    ");
            EndContext();
            BeginContext(449, 239, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e053df4639e254ddced064e0557ebca5681861108236", async() => {
                BeginContext(500, 181, true);
                WriteLiteral("\n        <a href=\"../Product/ProductPriceIndex\" class=\"btn btn-outline-info pull-right\">\n            <i class=\"fa fa-list-alt\"></i> &nbsp;\n            Back To List\n        </a>\n    ");
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
#line 23 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
  
    List<iv_LinkName> iv_list = new List<iv_LinkName>();
    int total = 0;
    iv_list = iv_LinkName.GetAll(1, 1000, 11, ref total, "");

    

#line default
#line hidden
#line 28 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
     using (Html.BeginForm("ProductPriceAdd", "Product", FormMethod.Post, new { @class = "form-horizontal" }))
    {

#line default
#line hidden
            BeginContext(962, 240, true);
            WriteLiteral("        <div class=\"container\">\n            <div class=\"row\">\n                <div class=\"col-md-6\">\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Product*</label>\n                        ");
            EndContext();
            BeginContext(1203, 27, false);
#line 35 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                   Write(Html.HiddenFor(m => m.SrNo));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 36 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                          
                            List<mst_product> lst = new List<mst_product>();
                            lst = mst_product.GetAll(1, 1000, 11, ref total, "");
                            

#line default
#line hidden
            BeginContext(1446, 126, false);
#line 39 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                       Write(Html.DropDownListFor(m => m.Mst_Product_SrNo, new SelectList(lst, "SrNo", "ProductName", ""), new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1624, 86, false);
#line 41 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Mst_Product_SrNo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 150, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Revised Date*</label>\n                        ");
            EndContext();
            BeginContext(1861, 68, false);
#line 45 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                   Write(Html.TextBoxFor(m => m.RevisedDate, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1929, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(1955, 81, false);
#line 46 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.RevisedDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 173, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Product Price*</label>\n                        ");
            EndContext();
            BeginContext(2210, 69, false);
#line 50 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                   Write(Html.TextBoxFor(m => m.ProductPrice, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2279, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2305, 82, false);
#line 51 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.ProductPrice, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2387, 169, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">AMC Price*</label>\n                        ");
            EndContext();
            BeginContext(2557, 65, false);
#line 55 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                   Write(Html.TextBoxFor(m => m.AMCPrice, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2622, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2648, 78, false);
#line 56 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.AMCPrice, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2726, 166, true);
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label class=\"control-label\">Remark:</label>\n                        ");
            EndContext();
            BeginContext(2893, 63, false);
#line 60 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"
                   Write(Html.TextBoxFor(m => m.Remark, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2956, 330, true);
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
#line 72 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductPriceAdd.cshtml"

    }

#line default
#line hidden
            BeginContext(3295, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(3296, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e053df4639e254ddced064e0557ebca56818611016552", async() => {
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
            BeginContext(3350, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(3351, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e053df4639e254ddced064e0557ebca56818611017730", async() => {
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
            BeginContext(3422, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(3423, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e053df4639e254ddced064e0557ebca56818611018908", async() => {
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
            BeginContext(3513, 630, true);
            WriteLiteral(@"
<script>
        $(function () {
        $(""#RevisedDate"").datepicker({
            dateFormat: ""dd/mm/yy""
        });

        var x = $(""#RevisedDate"").val();
        if (x != """") {
            var inputval = x.split("" "");
            var dateval = new Date(inputval[0]);
            var month = (""0"" + (dateval.getMonth() + 1)).slice(-2);
            var day = (""0"" + dateval.getDate()).slice(-2)
            var year = dateval.getUTCFullYear();

            var dt = day + ""/"" + month + ""/"" + year;
            $(""#RevisedDate"").val(dt);
        } else {
            $(""#RevisedDate"").val("""");
        }

    });
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mst_productprice> Html { get; private set; }
    }
}
#pragma warning restore 1591
