#pragma checksum "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0794eccc7abd69800dbc2bead9e7e3270018324f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerSupport), @"mvc.1.0.view", @"/Views/Customer/CustomerSupport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/CustomerSupport.cshtml", typeof(AspNetCore.Views_Customer_CustomerSupport))]
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
#line 1 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
using RX108_Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0794eccc7abd69800dbc2bead9e7e3270018324f", @"/Views/Customer/CustomerSupport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75537a6cbb4a1954f4c2625ee84a199d5c190584", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomerSupport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactUs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
  
    ViewData["Title"] = "CustomerSupport";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 43, true);
            WriteLiteral("\r\n<h1>Send Inquiry to Us</h1>\r\n<hr />\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 178, "\"", 200, 1);
#line 10 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
WriteAttributeValue("", 186, ViewBag.Class, 186, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(201, 7, true);
            WriteLiteral(">\r\n    ");
            EndContext();
            BeginContext(209, 11, false);
#line 11 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
Write(ViewBag.Msg);

#line default
#line hidden
            EndContext();
            BeginContext(220, 73, true);
            WriteLiteral("\r\n</div>\r\n<style>\r\n\r\n    .error {\r\n        color: red;\r\n    }\r\n</style>\r\n");
            EndContext();
#line 19 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
 using (Html.BeginForm("CustomerSupport", "Customer", FormMethod.Post, htmlAttributes: new { @enctype = "multipart/form-data" }))
{

#line default
#line hidden
            BeginContext(427, 79, true);
            WriteLiteral("    <div class=\"container\">\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(507, 27, false);
#line 25 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
       Write(Html.HiddenFor(m => m.SrNo));

#line default
#line hidden
            EndContext();
            BeginContext(534, 127, true);
            WriteLiteral("\r\n            <label class=\"control-label col-sm-3 \">Enter Name  </label>\r\n            <div class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(662, 61, false);
#line 28 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
           Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(723, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(742, 68, false);
#line 29 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
           Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(810, 209, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n\r\n            <label class=\"control-label col-sm-3 \">Enter Contact No  </label>\r\n            <div class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1020, 66, false);
#line 38 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
           Write(Html.TextBoxFor(m => m.ContactNo, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1105, 73, false);
#line 39 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
           Write(Html.ValidationMessageFor(m => m.ContactNo, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 207, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n\r\n            <label class=\"control-label col-sm-3 \">Enter Your Email  </label>\r\n            <div class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1386, 62, false);
#line 47 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
           Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1467, 69, false);
#line 48 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
           Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(1536, 198, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n\r\n            <label class=\"control-label col-sm-3 \">Subject  </label>\r\n            <div class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1735, 64, false);
#line 56 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
           Write(Html.TextBoxFor(m => m.Subject, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1818, 71, false);
#line 57 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
           Write(Html.ValidationMessageFor(m => m.Subject, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 198, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n\r\n            <label class=\"control-label col-sm-3 \">Remarks  </label>\r\n            <div class=\"col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(2088, 64, false);
#line 65 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
           Write(Html.TextBoxFor(m => m.Remarks, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2171, 71, false);
#line 66 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
           Write(Html.ValidationMessageFor(m => m.Remarks, "", new { @class = "error" }));

#line default
#line hidden
            EndContext();
            BeginContext(2242, 209, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"form-group col-sm-2\">\r\n            <input type=\"submit\" name=\"submit\" value=\"Send\" id=\"Save\" class=\"btn btn-success\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 74 "E:\VIPL\MCA-final-Project\VIPL_CRM\VIPL_CRM\Views\Customer\CustomerSupport.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactUs> Html { get; private set; }
    }
}
#pragma warning restore 1591
