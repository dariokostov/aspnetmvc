#pragma checksum "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\MovieDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9fd4af1cde15951b262c06665c98e5479d916b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MovieDetails), @"mvc.1.0.view", @"/Views/Movie/MovieDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/MovieDetails.cshtml", typeof(AspNetCore.Views_Movie_MovieDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9fd4af1cde15951b262c06665c98e5479d916b0", @"/Views/Movie/MovieDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"919cf83ceec8bb718869db33fb5cc2afd67f3f0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MovieDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\MovieDetails.cshtml"
  
    ViewData["Title"] = "MovieDetails";

#line default
#line hidden
            BeginContext(67, 38, true);
            WriteLiteral("\r\n<h1>MovieDetails</h1>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(106, 25, false);
#line 9 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\MovieDetails.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(131, 16, true);
            WriteLiteral("\r\n    <h3>Name: ");
            EndContext();
            BeginContext(148, 10, false);
#line 10 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\MovieDetails.cshtml"
         Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(158, 21, true);
            WriteLiteral("</h3>\r\n    <p>Genre: ");
            EndContext();
            BeginContext(180, 11, false);
#line 11 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\MovieDetails.cshtml"
         Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(191, 21, true);
            WriteLiteral("</p>\r\n    <p>Rating: ");
            EndContext();
            BeginContext(213, 12, false);
#line 12 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\MovieDetails.cshtml"
          Write(Model.Rating);

#line default
#line hidden
            EndContext();
            BeginContext(225, 21, true);
            WriteLiteral("</p>\r\n    <p>Length: ");
            EndContext();
            BeginContext(247, 12, false);
#line 13 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\MovieDetails.cshtml"
          Write(Model.Length);

#line default
#line hidden
            EndContext();
            BeginContext(259, 10, true);
            WriteLiteral("</p>\r\n    ");
            EndContext();
            BeginContext(270, 43, false);
#line 14 "C:\Users\Dario Kostov\Documents\GitHub\aspnetmvc\Homework-01\Homewokr\Views\Movie\MovieDetails.cshtml"
Write(Html.ActionLink("Back to movies", "Movies"));

#line default
#line hidden
            EndContext();
            BeginContext(313, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
