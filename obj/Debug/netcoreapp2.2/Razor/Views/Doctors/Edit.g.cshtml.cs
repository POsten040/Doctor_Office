#pragma checksum "C:\Users\lamapost0001\desktop\Doctor_office.solution\Doctor_office\Views\Doctors\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f93eb93a0d4f5c8fb62ce64ac8679d1a6b0c55ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Edit), @"mvc.1.0.view", @"/Views/Doctors/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Edit.cshtml", typeof(AspNetCore.Views_Doctors_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f93eb93a0d4f5c8fb62ce64ac8679d1a6b0c55ef", @"/Views/Doctors/Edit.cshtml")]
    public class Views_Doctors_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Doctor_Office.Models.Doctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lamapost0001\desktop\Doctor_office.solution\Doctor_office\Views\Doctors\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 6, true);
            WriteLiteral("\r\n<li>");
            EndContext();
            BeginContext(76, 43, false);
#line 7 "C:\Users\lamapost0001\desktop\Doctor_office.solution\Doctor_office\Views\Doctors\Edit.cshtml"
Write(Html.ActionLink("Back to doctors", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(119, 5, true);
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Doctor_Office.Models.Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591
