#pragma checksum "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\Home\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0cd24bf11400650d6837a392ab48e207704408e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0cd24bf11400650d6837a392ab48e207704408e", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d38a82b5ee01cd779631880960e1432f15a7bf8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\berek\Desktop\C#\Entity\CheifsnDishes\Views\Home\Dishes.cshtml"
  
    ViewData["Title"] = "Dish Page";

#line default
#line hidden
            BeginContext(45, 658, true);
            WriteLiteral(@"
    <h1><a href=""/"">Chefs</a> | <a href=""/Dishes"">Dishes</a></h1>
    <h1>Dishes</h1>
    <a href=""/AddDish"">Add a Dish</a>
    <h2>Yum, take a look at our tasty dishes!</h2>
    <p>____________________________________________________________________________________________________________________________________________________</p>
    <table class=""table col-sm-8 mx-auto"">
        <thead>
            <tr>
                <th scope=""col"">Name</th>
                <th scope=""col"">Chef</th>
                <th scope=""col"">Tastiness</th>
                <th scope=""col"">Calories</th>
            </tr>
        </thead>
    <tbody>
    
");
            EndContext();
            BeginContext(1012, 132, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\"></th>\r\n            <td></td>\r\n            <td></td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
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
