#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07f9c6fc194df6bdacdac39df0276af1b5a13c73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_FeedbackList), @"mvc.1.0.view", @"/Views/Customer/FeedbackList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/FeedbackList.cshtml", typeof(AspNetCore.Views_Customer_FeedbackList))]
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
#line 6 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f9c6fc194df6bdacdac39df0276af1b5a13c73", @"/Views/Customer/FeedbackList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_FeedbackList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagingList<Feedback>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0 float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FeedbackList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
  
    ViewData["Title"] = "FeedbackList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 8 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
  
    ViewData["Title"] = "Feedback List";
    int? currentSort = ViewBag.CurrentSort == null ? 11 : ViewBag.CurrentSort;
    if (currentSort == null)
    {
        currentSort = 11;
    }


#line default
#line hidden
            BeginContext(347, 222, true);
            WriteLiteral("\r\n<nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\r\n    <div class=\"collapse navbar-collapse\" id=\"navbarTogglerDemo01\">\r\n        <a class=\"navbar-brand\" href=\"#\">Complain List</a>\r\n    </div>\r\n\r\n</nav>\r\n<br />\r\n");
            EndContext();
            BeginContext(569, 368, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07f9c6fc194df6bdacdac39df0276af1b5a13c735210", async() => {
                BeginContext(620, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 27 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
     using (Html.BeginForm("FeedbackList", "Customer", FormMethod.Get))
    {
        

#line default
#line hidden
                BeginContext(713, 139, false);
#line 29 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
   Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string, new { @class = "form-control search-text", @placeholder = "Search by Name" }));

#line default
#line hidden
                EndContext();
                BeginContext(854, 69, true);
                WriteLiteral("        <input class=\"btn btn-info\" type=\"submit\" value=\"Search\" />\r\n");
                EndContext();
#line 31 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
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
            BeginContext(937, 352, true);
            WriteLiteral(@"
<br /><p></p>
<div class=""table-responsive"">
    <table class=""table table-bordered "" id=""headtable"">
        <tr>
            <th>#</th>

            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Suggestion</th>
            <th>Subject</th>
            <th>Message</th>

        </tr>

");
            EndContext();
#line 48 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1338, 24, true);
            WriteLiteral("    <tr>\r\n\r\n        <td>");
            EndContext();
            BeginContext(1363, 40, false);
#line 52 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
       Write(Html.DisplayFor(modelItem => item.DisID));

#line default
#line hidden
            EndContext();
            BeginContext(1403, 21, true);
            WriteLiteral("</td>\r\n\r\n        <td>");
            EndContext();
            BeginContext(1425, 44, false);
#line 54 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1489, 43, false);
#line 55 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1552, 40, false);
#line 56 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1612, 45, false);
#line 57 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Suggestion));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1677, 42, false);
#line 58 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Subject));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1739, 42, false);
#line 59 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
       Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 24, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n    </tr>\r\n");
            EndContext();
#line 64 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"

        }

#line default
#line hidden
            BeginContext(1818, 16, true);
            WriteLiteral("\r\n    </table>\r\n");
            EndContext();
#line 68 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
      
        var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
        var nextDisabled = !Model.HasNextPage ? "disabled" : "";
        var totalPageNo = Model.TotalPageNo;
        var currentPageNo = Model.PageIndex;
    

#line default
#line hidden
            BeginContext(2077, 134, true);
            WriteLiteral("    <div class=\"navbar navbar-expand-lg navbar-light bg-light\">\r\n        <div class=\"navbar-collapse\">\r\n            Total Records: <b>");
            EndContext();
            BeginContext(2212, 18, false);
#line 76 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
                         Write(Model.TotalRecords);

#line default
#line hidden
            EndContext();
            BeginContext(2230, 56, true);
            WriteLiteral("</b> |\r\n            <span>\r\n                Page No :<b>");
            EndContext();
            BeginContext(2287, 13, false);
#line 78 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
                       Write(currentPageNo);

#line default
#line hidden
            EndContext();
            BeginContext(2300, 11, true);
            WriteLiteral("</b> of <b>");
            EndContext();
            BeginContext(2312, 11, false);
#line 78 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
                                                Write(totalPageNo);

#line default
#line hidden
            EndContext();
            BeginContext(2323, 72, true);
            WriteLiteral("</b>\r\n            </span>\r\n\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(2395, 317, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07f9c6fc194df6bdacdac39df0276af1b5a13c7312988", async() => {
                BeginContext(2668, 40, true);
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
#line 84 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 85 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
                      WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 86 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2637, "btn", 2637, 3, true);
            AddHtmlAttributeValue(" ", 2640, "btn-default", 2641, 12, true);
#line 87 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
AddHtmlAttributeValue(" ", 2652, prevDisabled, 2653, 13, false);

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
            BeginContext(2712, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2726, 313, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07f9c6fc194df6bdacdac39df0276af1b5a13c7317331", async() => {
                BeginContext(2999, 36, true);
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
#line 91 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 92 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
                      WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 93 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2968, "btn", 2968, 3, true);
            AddHtmlAttributeValue(" ", 2971, "btn-default", 2972, 12, true);
#line 94 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\FeedbackList.cshtml"
AddHtmlAttributeValue(" ", 2983, nextDisabled, 2984, 13, false);

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
            BeginContext(3039, 50, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingList<Feedback>> Html { get; private set; }
    }
}
#pragma warning restore 1591