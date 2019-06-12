#pragma checksum "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\Movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5555c233ff758571b485ceb96b2c84b6b87affb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Movies), @"mvc.1.0.view", @"/Views/Movie/Movies.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Movies.cshtml", typeof(AspNetCore.Views_Movie_Movies))]
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
#line 1 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\_ViewImports.cshtml"
using Homewokr;

#line default
#line hidden
#line 2 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\_ViewImports.cshtml"
using Homewokr.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5555c233ff758571b485ceb96b2c84b6b87affb9", @"/Views/Movie/Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"919cf83ceec8bb718869db33fb5cc2afd67f3f0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/MoviesPDF.pdf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\Movies.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
            BeginContext(67, 32, true);
            WriteLiteral("\r\n<h1>Movies</h1>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(100, 35, false);
#line 9 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\Movies.cshtml"
Write(Html.ActionLink("Add movie", "Add"));

#line default
#line hidden
            EndContext();
            BeginContext(135, 12, true);
            WriteLiteral("\r\n    <ul>\r\n");
            EndContext();
#line 11 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\Movies.cshtml"
         foreach(var movie in Model)
        {

#line default
#line hidden
            BeginContext(196, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(209, 10, false);
#line 13 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\Movies.cshtml"
       Write(movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(219, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(221, 65, false);
#line 13 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\Movies.cshtml"
                   Write(Html.ActionLink("Details", "MovieDetails", new { id = movie.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(286, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(288, 54, false);
#line 13 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\Movies.cshtml"
                                                                                      Write(Html.ActionLink("Edit", "Edit", new { id = movie.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(342, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(344, 58, false);
#line 13 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\Movies.cshtml"
                                                                                                                                              Write(Html.ActionLink("Remove", "Remove", new { id = movie.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(402, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\Movies.cshtml"

        }

#line default
#line hidden
            BeginContext(422, 18, true);
            WriteLiteral("    </ul>\r\n    <p>");
            EndContext();
            BeginContext(440, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5555c233ff758571b485ceb96b2c84b6b87affb96841", async() => {
                BeginContext(482, 17, true);
                WriteLiteral("All movies in pdf");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(503, 12, true);
            WriteLiteral("</p>\r\n\r\n    ");
            EndContext();
            BeginContext(516, 48, false);
#line 19 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\Movies.cshtml"
Write(Html.ActionLink("Back to home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(564, 14, true);
            WriteLiteral("\r\n    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
