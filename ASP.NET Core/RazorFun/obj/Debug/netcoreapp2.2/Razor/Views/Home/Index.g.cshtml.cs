#pragma checksum "C:\Users\berek\Desktop\C#\ASP.NET Core\RazorFun\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b3065472508f3593b71d85576dcb032a68bb530"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b3065472508f3593b71d85576dcb032a68bb530", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 29, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(29, 1014, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b3065472508f3593b71d85576dcb032a68bb5302886", async() => {
                BeginContext(35, 806, true);
                WriteLiteral(@"
        <meta charset='utf-8'>
        <title>Hello!</title>
    <style>
    * {box-sizing: border-box;}
    body { 
    margin: 0;
    font-family: Arial, Helvetica, sans-serif;
    }

    .header {
    overflow: hidden;
    background-color: #f1f1f1;
    padding: 20px 10px;
    }

    .header a {
    float: left;
    color: black;
    text-align: center;
    padding: 12px;
    text-decoration: none;
    font-size: 18px; 
    line-height: 25px;
    border-radius: 4px;
    }

    .header a.logo {
    font-size: 25px;
    font-weight: bold;
    }

    .header a:hover {
    background-color: #ddd;
    color: black;
    }

    .header a.active {
    background-color: dodgerblue;
    color: white;
    }

    .header-right {
    float: right;
    }

    ");
                EndContext();
                BeginContext(842, 5, false);
#line 49 "C:\Users\berek\Desktop\C#\ASP.NET Core\RazorFun\Views\Home\Index.cshtml"
Write(media);

#line default
#line hidden
                EndContext();
                BeginContext(847, 189, true);
                WriteLiteral(" screen and (max-width: 500px) {\r\n    .header a {\r\n    float: none;\r\n    display: block;\r\n    text-align: left;\r\n    }\r\n\r\n    .header-right {\r\n        float: none;\r\n    }\r\n}\r\n</style>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1043, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1049, 1076, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b3065472508f3593b71d85576dcb032a68bb5305411", async() => {
                BeginContext(1055, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 63 "C:\Users\berek\Desktop\C#\ASP.NET Core\RazorFun\Views\Home\Index.cshtml"
          
            List<string> names = new List<string>
            {
                "Pizza",
                "BLT Sandwich",
                "Lasagna",
                "Carb Cakes",
                "Chicken Alfrado"
            };
        

#line default
#line hidden
                BeginContext(1315, 38, true);
                WriteLiteral("        <h1>About Me</h1>\r\n        <p>");
                EndContext();
                BeginContext(1354, 15, false);
#line 74 "C:\Users\berek\Desktop\C#\ASP.NET Core\RazorFun\Views\Home\Index.cshtml"
      Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(1369, 16, true);
                WriteLiteral("</p>\r\n        \r\n");
                EndContext();
#line 76 "C:\Users\berek\Desktop\C#\ASP.NET Core\RazorFun\Views\Home\Index.cshtml"
         foreach(string n in names)
        {
            if (n [0] == 'P')
            {

#line default
#line hidden
                BeginContext(1479, 39, true);
                WriteLiteral("                <p style=\"color: red;\">");
                EndContext();
                BeginContext(1519, 1, false);
#line 80 "C:\Users\berek\Desktop\C#\ASP.NET Core\RazorFun\Views\Home\Index.cshtml"
                                  Write(n);

#line default
#line hidden
                EndContext();
                BeginContext(1520, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 81 "C:\Users\berek\Desktop\C#\ASP.NET Core\RazorFun\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(1574, 15, true);
                WriteLiteral("            <p>");
                EndContext();
                BeginContext(1590, 1, false);
#line 84 "C:\Users\berek\Desktop\C#\ASP.NET Core\RazorFun\Views\Home\Index.cshtml"
          Write(n);

#line default
#line hidden
                EndContext();
                BeginContext(1591, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 85 "C:\Users\berek\Desktop\C#\ASP.NET Core\RazorFun\Views\Home\Index.cshtml"
            }
        }

#line default
#line hidden
                BeginContext(1623, 495, true);
                WriteLiteral(@"    <div class=""header"">
        <a href=""#default"" class=""logo"">CompanyLogo</a>
            <div class=""header-right"">
                <a class=""active"" href=""#home"">Home</a>
                <a href=""#contact"">Contact</a>
                <a href=""#about"">About</a>
            </div>
    </div>

    <div style=""padding-left:20px"">
        <h1>Responsive Header</h1>
            <p>Resize the browser window to see the effect.</p>
            <p>Some content..</p>
    </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2125, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
