#pragma checksum "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94c51295aeacacec533a1bcbd3a998094cbf5d35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Specialties_Create), @"mvc.1.0.view", @"/Views/Specialties/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Specialties/Create.cshtml", typeof(AspNetCore.Views_Specialties_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94c51295aeacacec533a1bcbd3a998094cbf5d35", @"/Views/Specialties/Create.cshtml")]
    public class Views_Specialties_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Doctor_Office.Models.Specialty>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(72, 28, true);
            WriteLiteral("\r\n<h4>Add a Specialty</h4>\r\n");
            EndContext();
#line 8 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(133, 34, false);
#line 10 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(172, 36, false);
#line 11 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(210, 134, true);
            WriteLiteral("  <br><span class=\"glyphicon glyphicon-plus\" aria-hidden=\"true\"></span><br><input class=\"btn\" type=\"submit\" value=\"Add a Specialty\">\r\n");
            EndContext();
#line 13 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Doctor_Office.Models.Specialty> Html { get; private set; }
    }
}
#pragma warning restore 1591
