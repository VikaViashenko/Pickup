#pragma checksum "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f79932c9ea8b1aaa87a97062a6f15d8b13b5f707"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Phone_GetPhones), @"mvc.1.0.view", @"/Views/Phone/GetPhones.cshtml")]
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
#line 1 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\_ViewImports.cshtml"
using Pickup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\_ViewImports.cshtml"
using Pickup.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79932c9ea8b1aaa87a97062a6f15d8b13b5f707", @"/Views/Phone/GetPhones.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e00d5babf31427f6a067e2dc52ce10b33cc648", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Phone_GetPhones : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pickup.Domain.Entity.Phone>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
  
    ViewBag.Title = "Title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
 foreach(var phone in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 10 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
  Write(phone.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 11 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
  Write(phone.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 12 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
  Write(phone.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 13 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
  Write(phone.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 14 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
  Write(phone.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 15 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
  Write(phone.Features);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 16 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
  Write(phone.BatteryCapacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 17 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
  Write(phone.Series);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 18 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
  Write(phone.Release);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 19 "C:\Users\Fujitsu\source\repos\Pickup\Pickup\Views\Phone\GetPhones.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pickup.Domain.Entity.Phone>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
