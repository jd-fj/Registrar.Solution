#pragma checksum "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50afcf509a33414b013e6844a7fe2fbc08b2dfb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Create), @"mvc.1.0.view", @"/Views/Courses/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Create.cshtml", typeof(AspNetCore.Views_Courses_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50afcf509a33414b013e6844a7fe2fbc08b2dfb9", @"/Views/Courses/Create.cshtml")]
    public class Views_Courses_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 27, true);
            WriteLiteral("\n<h2>Add a new course</h2>\n");
            EndContext();
#line 8 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(117, 40, false);
#line 10 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
Write(Html.LabelFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(161, 42, false);
#line 11 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
Write(Html.TextBoxFor(model => model.CourseName));

#line default
#line hidden
            EndContext();
            BeginContext(208, 42, false);
#line 13 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
Write(Html.LabelFor(model => model.CourseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(254, 44, false);
#line 14 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
Write(Html.TextBoxFor(model => model.CourseNumber));

#line default
#line hidden
            EndContext();
            BeginContext(299, 48, true);
            WriteLiteral("  <input type=\"submit\" value=\"Add new course\"/>\n");
            EndContext();
#line 16 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Courses/Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
