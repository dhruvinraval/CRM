#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "377ae5fb8f63ee72d4075e9329b823fdc05dc723"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ComplainList), @"mvc.1.0.view", @"/Views/Customer/ComplainList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/ComplainList.cshtml", typeof(AspNetCore.Views_Customer_ComplainList))]
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
#line 6 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"377ae5fb8f63ee72d4075e9329b823fdc05dc723", @"/Views/Customer/ComplainList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ComplainList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagingList<complain>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0 float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ComplainList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
  
    ViewData["Title"] = "ComplainList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 8 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
  
    ViewData["Title"] = "Complain List";
    int? currentSort = ViewBag.CurrentSort == null ? 11 : ViewBag.CurrentSort;
    if (currentSort == null)
    {
        currentSort = 11;
    }


#line default
#line hidden
            BeginContext(347, 226, true);
            WriteLiteral("\r\n<nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\r\n    <div class=\"collapse navbar-collapse\" id=\"navbarTogglerDemo01\">\r\n        <a class=\"navbar-brand\" href=\"#\">Complain List</a>\r\n    </div>\r\n    \r\n</nav>\r\n<br />\r\n");
            EndContext();
            BeginContext(573, 1082, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377ae5fb8f63ee72d4075e9329b823fdc05dc7235215", async() => {
                BeginContext(624, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 47 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
     using (Html.BeginForm("ComplainList", "Customer", FormMethod.Get))
    {
        

#line default
#line hidden
                BeginContext(1431, 139, false);
#line 49 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
   Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string, new { @class = "form-control search-text", @placeholder = "Search by Name" }));

#line default
#line hidden
                EndContext();
                BeginContext(1572, 69, true);
                WriteLiteral("        <input class=\"btn btn-info\" type=\"submit\" value=\"Search\" />\r\n");
                EndContext();
#line 51 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
    }

#line default
#line hidden
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
            BeginContext(1655, 503, true);
            WriteLiteral(@"
<br /><p></p>
<div class=""table-responsive"">
    <table class=""table table-bordered "" id=""headtable"">
        <tr>
            <th>#</th>

            <th>
                Name
            </th>
            <th>
                Place
            </th>
            <th>
                Contact
            </th>
            <th>
                Software Name
            </th>
            <th>
                Problem With Software
            </th>
            
        </tr>

");
            EndContext();
#line 77 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2207, 40, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>");
            EndContext();
            BeginContext(2248, 40, false);
#line 81 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.DisID));

#line default
#line hidden
            EndContext();
            BeginContext(2288, 29, true);
            WriteLiteral("</td>\r\n\r\n                <td>");
            EndContext();
            BeginContext(2318, 39, false);
#line 83 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2357, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2385, 40, false);
#line 84 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Place));

#line default
#line hidden
            EndContext();
            BeginContext(2425, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2453, 44, false);
#line 85 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ContactNo));

#line default
#line hidden
            EndContext();
            BeginContext(2497, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2525, 47, false);
#line 86 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoftwareName));

#line default
#line hidden
            EndContext();
            BeginContext(2572, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2600, 42, false);
#line 87 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Problem));

#line default
#line hidden
            EndContext();
            BeginContext(2642, 66, true);
            WriteLiteral("</td>\r\n                \r\n\r\n\r\n                \r\n            </tr>\r\n");
            EndContext();
#line 93 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"

        }

#line default
#line hidden
            BeginContext(2721, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 97 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
      
        var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
        var nextDisabled = !Model.HasNextPage ? "disabled" : "";
        var totalPageNo = Model.TotalPageNo;
        var currentPageNo = Model.PageIndex;
    

#line default
#line hidden
            BeginContext(2980, 134, true);
            WriteLiteral("    <div class=\"navbar navbar-expand-lg navbar-light bg-light\">\r\n        <div class=\"navbar-collapse\">\r\n            Total Records: <b>");
            EndContext();
            BeginContext(3115, 18, false);
#line 105 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
                         Write(Model.TotalRecords);

#line default
#line hidden
            EndContext();
            BeginContext(3133, 56, true);
            WriteLiteral("</b> |\r\n            <span>\r\n                Page No :<b>");
            EndContext();
            BeginContext(3190, 13, false);
#line 107 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
                       Write(currentPageNo);

#line default
#line hidden
            EndContext();
            BeginContext(3203, 11, true);
            WriteLiteral("</b> of <b>");
            EndContext();
            BeginContext(3215, 11, false);
#line 107 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
                                                Write(totalPageNo);

#line default
#line hidden
            EndContext();
            BeginContext(3226, 72, true);
            WriteLiteral("</b>\r\n            </span>\r\n\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(3298, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377ae5fb8f63ee72d4075e9329b823fdc05dc72312922", async() => {
                BeginContext(3571, 40, true);
                WriteLiteral("\r\n                Previous\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 114 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
                      WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 115 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3540, "btn", 3540, 3, true);
            AddHtmlAttributeValue(" ", 3543, "btn-default", 3544, 12, true);
#line 116 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
AddHtmlAttributeValue(" ", 3555, prevDisabled, 3556, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3615, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3629, 313, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377ae5fb8f63ee72d4075e9329b823fdc05dc72317269", async() => {
                BeginContext(3902, 36, true);
                WriteLiteral("\r\n                Next\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 121 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
                      WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 122 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3871, "btn", 3871, 3, true);
            AddHtmlAttributeValue(" ", 3874, "btn-default", 3875, 12, true);
#line 123 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\ComplainList.cshtml"
AddHtmlAttributeValue(" ", 3886, nextDisabled, 3887, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3942, 50, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingList<complain>> Html { get; private set; }
    }
}
#pragma warning restore 1591
