#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53fa6bd96e139953683171b0dceea3d1c375249b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BankingEmployeeMaster_DocTagList), @"mvc.1.0.view", @"/Views/BankingEmployeeMaster/DocTagList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BankingEmployeeMaster/DocTagList.cshtml", typeof(AspNetCore.Views_BankingEmployeeMaster_DocTagList))]
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
#line 1 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53fa6bd96e139953683171b0dceea3d1c375249b", @"/Views/BankingEmployeeMaster/DocTagList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_BankingEmployeeMaster_DocTagList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagingList<DocTag>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/Fontawesome/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DocTagList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
  
    ViewData["Title"] = "DocTag List";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int? currentSort = ViewBag.CurrentSort == null ? 11 : ViewBag.CurrentSort;
    if (currentSort == null)
    {
        currentSort = 11;
    }


#line default
#line hidden
            BeginContext(282, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(283, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "53fa6bd96e139953683171b0dceea3d1c375249b5459", async() => {
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
            BeginContext(345, 6, true);
            WriteLiteral("\n\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 351, "\"", 377, 1);
#line 17 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
WriteAttributeValue("", 359, TempData["Class"], 359, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(378, 6, true);
            WriteLiteral(">\n    ");
            EndContext();
            BeginContext(385, 15, false);
#line 18 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
Write(TempData["Msg"]);

#line default
#line hidden
            EndContext();
            BeginContext(400, 455, true);
            WriteLiteral(@"
</div>

<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
    <div class=""collapse navbar-collapse"" id=""navbarTogglerDemo01"">
        <a class=""navbar-brand"" href=""#"">Doc Tag List</a>
    </div>
    <div class=""form-inline my-2 my-lg-0 float-right"">
        <a href=""../BankingEmployeeMaster/DocTagIndex"" class=""btn btn-outline-info pull-right"">
            <i class=""fa fa-plus""></i>
            Add New
        </a>
    </div>
</nav>
<br />

");
            EndContext();
            BeginContext(855, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fa6bd96e139953683171b0dceea3d1c375249b7932", async() => {
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
            BeginContext(906, 54, true);
            WriteLiteral("\n\n<div class=\"form-inline my-2 my-lg-0 float-right\">\n\n");
            EndContext();
#line 38 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
     if (TempData["MSG"] != null)
    {

#line default
#line hidden
            BeginContext(1000, 12, true);
            WriteLiteral("        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1012, "\"", 1046, 3);
#line 40 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
WriteAttributeValue("", 1020, TempData["Class"], 1020, 18, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1038, "fade", 1039, 5, true);
            WriteAttributeValue(" ", 1043, "in", 1044, 3, true);
            EndWriteAttribute();
            BeginContext(1047, 98, true);
            WriteLiteral(">\n            <button class=\"close\" data-dismiss=\"alert\">\n                ×\n            </button>\n");
            EndContext();
#line 44 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
               if (@TempData["Class"].ToString() == "alert alert-success")
                {

#line default
#line hidden
            BeginContext(1238, 99, true);
            WriteLiteral("                    <i class=\"fa-fw fa fa-check\"></i>\n                    <strong>Success</strong>\n");
            EndContext();
#line 48 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1394, 98, true);
            WriteLiteral("                    <i class=\"fa-fw fa fa-times\"></i>\n                    <strong>Error!</strong>\n");
            EndContext();
#line 53 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1524, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1537, 15, false);
#line 55 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
       Write(TempData["MSG"]);

#line default
#line hidden
            EndContext();
            BeginContext(1552, 16, true);
            WriteLiteral("\n        </div>\n");
            EndContext();
#line 57 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
    }

#line default
#line hidden
            BeginContext(1574, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 59 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
     using (Html.BeginForm("DocTagList", "BankingEmployeeMaster", FormMethod.Get))
    {
        

#line default
#line hidden
            BeginContext(1673, 133, false);
#line 61 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
   Write(Html.TextBox("SearchString", ViewBag.CurrentFilter as string, new { @class = "form-control search-text", @placeholder = "Search.." }));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 68, true);
            WriteLiteral("        <input class=\"btn btn-info\" type=\"submit\" value=\"Search\" />\n");
            EndContext();
#line 63 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
    }

#line default
#line hidden
            BeginContext(1881, 139, true);
            WriteLiteral("</div>\n\n<br />\n<br /><p></p>\n\n<div class=\"table-responsive\">\n\n    <table class=\"table table-bordered\">\n        <tr>\n            <th>#</th>\n");
            EndContext();
            BeginContext(2050, 17, true);
            WriteLiteral("            <th>\n");
            EndContext();
#line 76 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                  
                    if (currentSort == 21)
                    {
                        

#line default
#line hidden
            BeginContext(2176, 346, false);
#line 79 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                   Write(Html.ActionLink("Doc Tag Name", "DocTagList", new
                        {
                            sortField = "22",
                            currentSortField = ViewBag.SortField,
                            currentSortOrder = ViewBag.SortOrder,
                            currentFilter = ViewBag.CurrentFilter
                        }));

#line default
#line hidden
            EndContext();
#line 85 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                          
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(2617, 347, false);
#line 89 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                   Write(Html.ActionLink("Doc Tag Name", "DocTagList", new
                        {
                            sortField = "21",
                            currentSortField = ViewBag.SortField,
                            currentSortOrder = ViewBag.SortOrder,
                             currentFilter = ViewBag.CurrentFilter
                        }));

#line default
#line hidden
            EndContext();
#line 95 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                          
                    }
                    if (currentSort == 21)
                    {

#line default
#line hidden
            BeginContext(3052, 55, true);
            WriteLiteral("                        <i class=\"fa fa-sort-down\"></i>");
            EndContext();
#line 99 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                                                       }
                    else if (currentSort == 22)
                    {

#line default
#line hidden
            BeginContext(3179, 53, true);
            WriteLiteral("                        <i class=\"fa fa-sort-up\"></i>");
            EndContext();
#line 102 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                                                     }
                    else
                    {

#line default
#line hidden
            BeginContext(3281, 51, true);
            WriteLiteral("                        <i class=\"fa fa-sort\"></i>\n");
            EndContext();
#line 106 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(3372, 70, true);
            WriteLiteral("            </th>\n            <th>Actions</th>\n        </tr>\n        \n");
            EndContext();
#line 112 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(3489, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(3548, 40, false);
#line 116 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
               Write(Html.DisplayFor(modelItem => item.DisID));

#line default
#line hidden
            EndContext();
            BeginContext(3588, 24, true);
            WriteLiteral("\n\n                </td>\n");
            EndContext();
            BeginContext(3682, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(3703, 45, false);
#line 120 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
               Write(Html.DisplayFor(modelItem => item.DocTagName));

#line default
#line hidden
            EndContext();
            BeginContext(3748, 73, true);
            WriteLiteral("</td>\n                <td>\n                    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3821, "\"", 3880, 2);
            WriteAttributeValue("", 3828, "../BankingEmployeeMaster/DocTagIndex?SrNo=", 3828, 42, true);
#line 122 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
WriteAttributeValue("", 3870, item.SrNo, 3870, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3881, 204, true);
            WriteLiteral(">\n                        <i class=\"fa fa-pencil-square-o\"></i>\n                    </a>\n                    <a onclick=\"return confirm(\'Are you sure want to delete this record?\');\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4085, "\"", 4145, 2);
            WriteAttributeValue("", 4092, "../BankingEmployeeMaster/DocTagDelete?SrNo=", 4092, 43, true);
#line 125 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
WriteAttributeValue("", 4135, item.SrNo, 4135, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4146, 123, true);
            WriteLiteral(">\n\n                        <i class=\"fa fa-trash-o\"></i>\n                    </a>\n                </td>\n\n            </tr>\n");
            EndContext();
#line 132 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
        }

#line default
#line hidden
            BeginContext(4279, 14, true);
            WriteLiteral("    </table>\n\n");
            EndContext();
#line 135 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
      
        var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
        var nextDisabled = !Model.HasNextPage ? "disabled" : "";
        var totalPageNo = Model.TotalPageNo;
        var currentPageNo = Model.PageIndex;
    

#line default
#line hidden
            BeginContext(4530, 158, true);
            WriteLiteral("    <div class=\"navbar navbar-expand-lg navbar-light bg-light\">\n        <div class=\"navbar-collapse\" id=\"navbarTogglerDemo01\">\r\n            Total Records: <b>");
            EndContext();
            BeginContext(4689, 18, false);
#line 143 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                         Write(Model.TotalRecords);

#line default
#line hidden
            EndContext();
            BeginContext(4707, 56, true);
            WriteLiteral("</b> |\r\n            <span>\r\n                Page No :<b>");
            EndContext();
            BeginContext(4764, 13, false);
#line 145 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                       Write(currentPageNo);

#line default
#line hidden
            EndContext();
            BeginContext(4777, 11, true);
            WriteLiteral("</b> of <b>");
            EndContext();
            BeginContext(4789, 11, false);
#line 145 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                                                Write(totalPageNo);

#line default
#line hidden
            EndContext();
            BeginContext(4800, 68, true);
            WriteLiteral("</b>\r\n            </span>\r\n        </div>\n        <div>\n            ");
            EndContext();
            BeginContext(4868, 309, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fa6bd96e139953683171b0dceea3d1c375249b21112", async() => {
                BeginContext(5135, 38, true);
                WriteLiteral("\n                Previous\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 150 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 151 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                      WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 152 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5104, "btn", 5104, 3, true);
            AddHtmlAttributeValue(" ", 5107, "btn-default", 5108, 12, true);
#line 153 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
AddHtmlAttributeValue(" ", 5119, prevDisabled, 5120, 13, false);

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
            BeginContext(5177, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(5190, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fa6bd96e139953683171b0dceea3d1c375249b25497", async() => {
                BeginContext(5457, 34, true);
                WriteLiteral("\n                Next\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 157 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                        WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 158 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                      WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 159 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
                            WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5426, "btn", 5426, 3, true);
            AddHtmlAttributeValue(" ", 5429, "btn-default", 5430, 12, true);
#line 160 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\BankingEmployeeMaster\DocTagList.cshtml"
AddHtmlAttributeValue(" ", 5441, nextDisabled, 5442, 13, false);

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
            BeginContext(5495, 93, true);
            WriteLiteral("\n        </div>\n    </div>\n    <div style=\"text-align:right;padding:0;\">\n\n    </div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingList<DocTag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
