#pragma checksum "C:\Users\User\Desktop\Phantom\Phantom\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5abe64bb8b5574dbba9de938bddbbd0a5c2367a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Phantom\Phantom\Areas\Admin\Views\_ViewImports.cshtml"
using Phantom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Phantom\Phantom\Areas\Admin\Views\_ViewImports.cshtml"
using Phantom.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Phantom\Phantom\Areas\Admin\Views\_ViewImports.cshtml"
using Phantom.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5abe64bb8b5574dbba9de938bddbbd0a5c2367a8", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72eb53e1bca7990e4336be0606289747b2ba0c08", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Dashboardjchvjofff</h1>
</div>
<div class=""col-xl-3 col-md-6 mb-4"">
    <div class=""card border-left-primary shadow h-100 py-2"">
        <div class=""card-body"">
            <div class=""row no-gutters align-items-center"">
                <div class=""col mr-2"">
                    <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                        Blogs Count
                    </div>
                    <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
#nullable restore
#line 13 "C:\Users\User\Desktop\Phantom\Phantom\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                                   Write(Model.BlogsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                </div>\n                <div class=\"col-auto\">\n                    <i class=\"fas fa-image fa-2x text-gray-300\"></i>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591