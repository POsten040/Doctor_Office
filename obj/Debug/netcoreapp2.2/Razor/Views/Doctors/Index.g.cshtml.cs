#pragma checksum "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6a1b65744d22a6c99790de174028618f1a9915a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Index), @"mvc.1.0.view", @"/Views/Doctors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Index.cshtml", typeof(AspNetCore.Views_Doctors_Index))]
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
#line 5 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Index.cshtml"
using Doctor_Office.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a1b65744d22a6c99790de174028618f1a9915a", @"/Views/Doctors/Index.cshtml")]
    public class Views_Doctors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Doctor_Office.Models.Doctor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(105, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(135, 29, true);
            WriteLiteral("  <h3>No Doctors Here!</h3>\r\n");
            EndContext();
#line 11 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(167, 228, true);
            WriteLiteral("\r\n\r\n<nav class=\"navbar navbar\">\r\n  <div class=\"container-fluid\">\r\n    <ul class=\"nav navbar-nav\">\r\n    <button type=\"button\" class=\"btn\" id=\"newBtn\">\r\n        <span class=\"glyphicon glyphicon-plus\" aria-hidden=\"true\"></span><li>");
            EndContext();
            BeginContext(396, 39, false);
#line 18 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Index.cshtml"
                                                                        Write(Html.ActionLink("Add Doctor", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(435, 312, true);
            WriteLiteral(@"</li>
      </button>

      <button type=""button"" class=""btn"">
        <span class=""glyphicon glyphicon-book"" aria-hidden=""true""></span>
        <li class=""dropdown"">
          <a class=""dropdown-toggle"" data-toggle=""dropdown"">Doctors<span class=""caret""></span></a>
          <ul class=""dropdown-menu"">
");
            EndContext();
#line 26 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Index.cshtml"
             foreach (Doctor doctor in Model)
            {

#line default
#line hidden
            BeginContext(809, 135, true);
            WriteLiteral("              <button type=\"button\" class=\"btn\">\r\n                <span class=\"glyphicon glyphicon-user\" aria-hidden=\"true\"></span><li>");
            EndContext();
            BeginContext(945, 74, false);
#line 29 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Index.cshtml"
                                                                                Write(Html.ActionLink($"{doctor.Name}", "Details", new { id = doctor.DoctorId }));

#line default
#line hidden
            EndContext();
            BeginContext(1019, 32, true);
            WriteLiteral("</li>\r\n              </button>\r\n");
            EndContext();
#line 31 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1066, 76, true);
            WriteLiteral("          </ul>\r\n        </li>\r\n      </button>\r\n    </ul>\r\n  </div>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Doctor_Office.Models.Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
