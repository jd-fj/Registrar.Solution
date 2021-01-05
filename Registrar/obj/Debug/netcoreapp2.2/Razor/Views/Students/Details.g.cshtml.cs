#pragma checksum "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac8af0e5702352457e4dc5561aa40e28cdcda4a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac8af0e5702352457e4dc5561aa40e28cdcda4a9", @"/Views/Students/Details.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 29, true);
            WriteLiteral("<h2>Student Details</h2>\n<h2>");
            EndContext();
            BeginContext(90, 47, false);
#line 7 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(137, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(140, 43, false);
#line 7 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(183, 7, true);
            WriteLiteral("</h2>\n\n");
            EndContext();
#line 9 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
 if(@Model.Courses.Count == 0)
{

#line default
#line hidden
            BeginContext(223, 64, true);
            WriteLiteral("  <p>This student is not currently enrolled in any courses.</p>\n");
            EndContext();
#line 12 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(296, 69, true);
            WriteLiteral("  <h2>This student is enrolled in the following courses:</h2>\n  <ul>\n");
            EndContext();
#line 17 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
   foreach(var join in Model.Courses)
  {

#line default
#line hidden
            BeginContext(407, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(416, 22, false);
#line 19 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
   Write(join.Course.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(438, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 20 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(448, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 22 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
}

#line default
#line hidden
            BeginContext(458, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(463, 40, false);
#line 24 "/Users/taylordelph/Desktop/Epicodus/Registrar.Solution/Registrar/Views/Students/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(503, 5, true);
            WriteLiteral("</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
