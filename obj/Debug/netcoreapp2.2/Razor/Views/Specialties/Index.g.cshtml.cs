#pragma checksum "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98146330262a103ff20faa0ae8258351e5eff8b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Specialties_Index), @"mvc.1.0.view", @"/Views/Specialties/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Specialties/Index.cshtml", typeof(AspNetCore.Views_Specialties_Index))]
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
#line 5 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Index.cshtml"
using Doctor_Office.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98146330262a103ff20faa0ae8258351e5eff8b5", @"/Views/Specialties/Index.cshtml")]
    public class Views_Specialties_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Doctor_Office.Models.Specialty>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(138, 33, true);
            WriteLiteral("  <h3>No Specialties Here!</h3>\r\n");
            EndContext();
#line 11 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Index.cshtml"
}

#line default
#line hidden
            BeginContext(174, 228, true);
            WriteLiteral("\r\n\r\n<nav class=\"navbar navbar\">\r\n  <div class=\"container-fluid\">\r\n    <ul class=\"nav navbar-nav\">\r\n    <button type=\"button\" class=\"btn\" id=\"newBtn\">\r\n        <span class=\"glyphicon glyphicon-plus\" aria-hidden=\"true\"></span><li>");
            EndContext();
            BeginContext(403, 42, false);
#line 18 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Index.cshtml"
                                                                        Write(Html.ActionLink("Add Specialty", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(445, 316, true);
            WriteLiteral(@"</li>
      </button>

      <button type=""button"" class=""btn"">
        <span class=""glyphicon glyphicon-book"" aria-hidden=""true""></span>
        <li class=""dropdown"">
          <a class=""dropdown-toggle"" data-toggle=""dropdown"">Specialties<span class=""caret""></span></a>
          <ul class=""dropdown-menu"">
");
            EndContext();
#line 26 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Index.cshtml"
             foreach (Specialty specialty in Model)
            {

#line default
#line hidden
            BeginContext(829, 135, true);
            WriteLiteral("              <button type=\"button\" class=\"btn\">\r\n                <span class=\"glyphicon glyphicon-user\" aria-hidden=\"true\"></span><li>");
            EndContext();
            BeginContext(965, 83, false);
#line 29 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Index.cshtml"
                                                                                Write(Html.ActionLink($"{specialty.Name}", "Details", new { id = specialty.SpecialtyId }));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 32, true);
            WriteLiteral("</li>\r\n              </button>\r\n");
            EndContext();
#line 31 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Specialties\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1095, 76, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Doctor_Office.Models.Specialty>> Html { get; private set; }
    }
}
#pragma warning restore 1591
