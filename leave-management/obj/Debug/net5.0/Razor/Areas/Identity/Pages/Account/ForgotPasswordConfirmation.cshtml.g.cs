#pragma checksum "D:\CSharp_Projects\ASPNETCore\LeaveManagementSystem\leave-management\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5a9e30f47932bba756d7c5fe8f089c13196f92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
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
#nullable restore
#line 1 "D:\CSharp_Projects\ASPNETCore\LeaveManagementSystem\leave-management\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CSharp_Projects\ASPNETCore\LeaveManagementSystem\leave-management\Areas\Identity\Pages\_ViewImports.cshtml"
using leave_management.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CSharp_Projects\ASPNETCore\LeaveManagementSystem\leave-management\Areas\Identity\Pages\_ViewImports.cshtml"
using leave_management.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\CSharp_Projects\ASPNETCore\LeaveManagementSystem\leave-management\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using leave_management.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5a9e30f47932bba756d7c5fe8f089c13196f92", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd94f7318e29077cd58101a96170cea342b29379", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ebdc69bbc97be280493bae2827dfc047fc6d76e", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\CSharp_Projects\ASPNETCore\LeaveManagementSystem\leave-management\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>");
#nullable restore
#line 7 "D:\CSharp_Projects\ASPNETCore\LeaveManagementSystem\leave-management\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<p>\n    Please check your email to reset your password.\n</p>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmation> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation>)PageContext?.ViewData;
        public ForgotPasswordConfirmation Model => ViewData.Model;
    }
}
#pragma warning restore 1591
