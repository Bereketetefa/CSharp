#pragma checksum "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57bab9aa05a9b86ccc6bc8683daa4a718470bf11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\_ViewImports.cshtml"
using CheifsnDishes;

#line default
#line hidden
#line 2 "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\_ViewImports.cshtml"
using CheifsnDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57bab9aa05a9b86ccc6bc8683daa4a718470bf11", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d38a82b5ee01cd779631880960e1432f15a7bf8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 632, true);
            WriteLiteral(@"
    <h1><a href=""/"">Chefs</a> | <a href=""/Dishes"">Dishes</a></h1>
    <a href=""/AddChef"">Add a Chef</a>
    <h2>Check our roster of Chefs!</h2>
    <p>____________________________________________________________________________________________________________________________________________________</p>
    <table class=""table col-sm-8 mx-auto"">
        <thead>
            <tr>
                <th scope=""col"">First Name</th>
                <th scope=""col"">Last Name</th>
                <th scope=""col"">Age</th>
                <th scope=""col""># of Dishes</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\Home\Index.cshtml"
              
                foreach(var chef in  @ViewBag.allchefs)
                {

#line default
#line hidden
            BeginContext(769, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(816, 14, false);
#line 23 "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\Home\Index.cshtml"
                   Write(chef.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(830, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(862, 13, false);
#line 24 "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\Home\Index.cshtml"
                   Write(chef.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(875, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(907, 8, false);
#line 25 "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\Home\Index.cshtml"
                   Write(chef.Age);

#line default
#line hidden
            EndContext();
            BeginContext(915, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(947, 16, false);
#line 26 "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\Home\Index.cshtml"
                   Write(chef.dishs.Count);

#line default
#line hidden
            EndContext();
            BeginContext(963, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1027, 252, true);
            WriteLiteral("            <tr>\r\n        <th scope=\"row\"></th>\r\n            <td></td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"row\"></th>\r\n            <td></td>\r\n            <td></td>\r\n        </tr>\r\n        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
