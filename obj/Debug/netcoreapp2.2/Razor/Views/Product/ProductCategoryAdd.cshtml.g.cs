#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d808ad1e29aeab2188112ae9966aaa60879bc596"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductCategoryAdd), @"mvc.1.0.view", @"/Views/Product/ProductCategoryAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductCategoryAdd.cshtml", typeof(AspNetCore.Views_Product_ProductCategoryAdd))]
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
#line 1 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d808ad1e29aeab2188112ae9966aaa60879bc596", @"/Views/Product/ProductCategoryAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductCategoryAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mst_productcategory>
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
#line 3 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
  
    ViewData["Title"] = "Product Category";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d808ad1e29aeab2188112ae9966aaa60879bc5966066", async() => {
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
            BeginContext(192, 5, true);
            WriteLiteral("\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 197, "\"", 219, 1);
#line 8 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
WriteAttributeValue("", 205, ViewBag.Class, 205, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(220, 6, true);
            WriteLiteral(">\n    ");
            EndContext();
            BeginContext(227, 11, false);
#line 9 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(238, 220, true);
            WriteLiteral("\n</div>\n<nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\n    <div class=\"collapse navbar-collapse\" id=\"navbarTogglerDemo01\">\n        <a class=\"navbar-brand\" href=\"#\">Create Product Category</a>\n    </div>\n    ");
            EndContext();
            BeginContext(458, 242, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d808ad1e29aeab2188112ae9966aaa60879bc5968278", async() => {
                BeginContext(509, 184, true);
                WriteLiteral("\n        <a href=\"../Product/ProductCategoryIndex\" class=\"btn btn-outline-info pull-right\">\n            <i class=\"fa fa-list-alt\"></i> &nbsp;\n            Back To List\n        </a>\n    ");
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
            BeginContext(700, 15, true);
            WriteLiteral("\n</nav>\n<br />\n");
            EndContext();
#line 23 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
 using (Html.BeginForm("ProductCategoryAdd", "Product", FormMethod.Post, new { @class = "form-horizontal" }))
{

#line default
#line hidden
            BeginContext(827, 150, true);
            WriteLiteral("    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(978, 27, false);
#line 29 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
               Write(Html.HiddenFor(m => m.SrNo));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 50, true);
            WriteLiteral("\n                    <label>Status*</label>&nbsp;\n");
            EndContext();
#line 31 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                     if (Model != null)
                    {

                        

#line default
#line hidden
#line 34 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                         if (Model.Status == 'T')
                        {

#line default
#line hidden
            BeginContext(1194, 223, true);
            WriteLiteral("                            <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"T\" checked /><label>Active</label>\n                            <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"F\" /><label>Block</label>\n");
            EndContext();
            BeginContext(1446, 76, false);
#line 38 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 38 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                                                                                                         
                        }
                        else if( Model.Status == 'F')
                        {

#line default
#line hidden
            BeginContext(1629, 223, true);
            WriteLiteral("                            <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"I\" /><label>Active</label>\n                            <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"F\" checked /><label>Block</label>\n");
            EndContext();
            BeginContext(1881, 76, false);
#line 44 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 44 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                                                                                                         
                        }

#line default
#line hidden
#line 45 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2053, 215, true);
            WriteLiteral("                        <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"T\" checked /><label>Active</label>\n                        <input type=\"radio\" id=\"Status\" name=\"Status\" value=\"F\" /><label>Block</label>\n");
            EndContext();
            BeginContext(2293, 76, false);
#line 51 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
#line 51 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                                                                                                     
                    }

#line default
#line hidden
            BeginContext(2392, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2413, 76, false);
#line 53 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
               Write(Html.ValidationMessageFor(m => m.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2489, 161, true);
            WriteLiteral("\n\n                </div>\n                <div class=\"form-group\">\n                    <label class=\"control-label\">ProductCategory*</label>\n\n                    ");
            EndContext();
            BeginContext(2651, 72, false);
#line 59 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
               Write(Html.TextBoxFor(m => m.ProductCategory, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2723, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2745, 85, false);
#line 60 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
               Write(Html.ValidationMessageFor(m => m.ProductCategory, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2830, 135, true);
            WriteLiteral("\n                </div>\n                <div class=\"form-group\">\n                    <label class=\"control-label\">Image/Video*</label>\n");
            EndContext();
#line 64 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                      
                        List<iv_LinkName> lst =  new List<iv_LinkName>();
                        int total = 0,i=1;
                        lst = iv_LinkName.GetAll(i,1000,11,ref total,"");
                        if(total > 1000)
                        {
                            float pg = (float)total / 1000;
                            int x = Convert.ToInt32(pg.ToString().Substring(pg.ToString().IndexOf('.')+1));
                            if(x > 0)
                            {
                                x = x + 1;
                            }
                            if(x > 1)
                            {
                                while(x > 1)
                                {
                                    i++;
                                    lst.AddRange(iv_LinkName.GetAll(i,1000,11,ref total,""));
                                    x--;
                                }
                            }
                        }
                        

#line default
#line hidden
            BeginContext(3993, 117, false);
#line 86 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
                   Write(Html.DropDownListFor(m=>m.IV_LinkName_SrNo,new SelectList(lst,"SrNo","BriefName",""),new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4133, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(4154, 86, false);
#line 88 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
               Write(Html.ValidationMessageFor(m => m.IV_LinkName_SrNo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4240, 150, true);
            WriteLiteral("\n                </div>\n                <div class=\"form-group\">\n                    <label class=\"control-label\">Remark:</label>\n                    ");
            EndContext();
            BeginContext(4391, 63, false);
#line 92 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"
               Write(Html.TextBoxFor(m => m.Remark, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4454, 280, true);
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
#line 102 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Product\ProductCategoryAdd.cshtml"

}

#line default
#line hidden
            BeginContext(4737, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(4738, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d808ad1e29aeab2188112ae9966aaa60879bc59619117", async() => {
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
            BeginContext(4792, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(4793, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d808ad1e29aeab2188112ae9966aaa60879bc59620295", async() => {
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
            BeginContext(4864, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(4865, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d808ad1e29aeab2188112ae9966aaa60879bc59621473", async() => {
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
            BeginContext(4955, 3, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mst_productcategory> Html { get; private set; }
    }
}
#pragma warning restore 1591
