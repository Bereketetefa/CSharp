#pragma checksum "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b82d34fa2b534228deadc99bb68e18679a49724d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_createdActivity), @"mvc.1.0.view", @"/Views/Home/createdActivity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/createdActivity.cshtml", typeof(AspNetCore.Views_Home_createdActivity))]
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
#line 1 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#line 2 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b82d34fa2b534228deadc99bb68e18679a49724d", @"/Views/Home/createdActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_createdActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Activities>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 128, true);
            WriteLiteral("    <style>\r\n    body{\r\n    background-image:radial-gradient(circle, rgba(238,174,202,1) 0%, rgba(148,187,233,1) 100%);\r\n    }\r\n");
            EndContext();
            BeginContext(271, 30, true);
            WriteLiteral("    </style>\r\n<h1>Event Title:");
            EndContext();
            BeginContext(302, 11, false);
#line 10 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(313, 31, true);
            WriteLiteral("</h1>\r\n<h2>Event Coordinator:\r\n");
            EndContext();
#line 12 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
     foreach(var name in @ViewBag.AllUsers)
    {
            

#line default
#line hidden
#line 14 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
             if(name.UserId == @Model.ActivityPlanner)
        {

#line default
#line hidden
            BeginContext(463, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(479, 14, false);
#line 16 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
          Write(name.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(493, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 17 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
        }

#line default
#line hidden
#line 17 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
         
    }

#line default
#line hidden
            BeginContext(517, 17, true);
            WriteLiteral("</h2>\r\n<h2>Date: ");
            EndContext();
            BeginContext(535, 18, false);
#line 20 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
     Write(Model.ActivityDate);

#line default
#line hidden
            EndContext();
            BeginContext(553, 24, true);
            WriteLiteral("</h2>\r\n<h2>Description: ");
            EndContext();
            BeginContext(578, 17, false);
#line 21 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
            Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(595, 26, true);
            WriteLiteral("</h2>\r\n<h2>Guests</h2>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                     foreach(var x in @Model.JoinList)
                    {

#line default
#line hidden
            BeginContext(700, 54, true);
            WriteLiteral("                    <ul>\r\n                        <li>");
            EndContext();
            BeginContext(755, 16, false);
#line 27 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                       Write(x.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(771, 34, true);
            WriteLiteral("</li>\r\n                    </ul>\r\n");
            EndContext();
#line 29 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                    }

#line default
#line hidden
            BeginContext(828, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 30 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                     if(@Model.ActivityPlanner == @ViewBag.User)
                    {

#line default
#line hidden
            BeginContext(917, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(937, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b82d34fa2b534228deadc99bb68e18679a49724d7498", async() => {
                BeginContext(995, 109, true);
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-success\">Delete</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 951, "../Delete/", 951, 10, true);
#line 32 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
AddHtmlAttributeValue("", 961, Model.ActivitiyId, 961, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1111, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                    }
                    else
                    {
                        bool going = false;
                    

#line default
#line hidden
#line 39 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                     foreach (var y in @Model.JoinList)
                    {
                        

#line default
#line hidden
#line 41 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                         if(@ViewBag.User == y.User.UserId)
                        {
                            going = true;
                        }

#line default
#line hidden
#line 44 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                         
                    }

#line default
#line hidden
#line 46 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                         if(going == true)
                        {

#line default
#line hidden
            BeginContext(1562, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1586, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b82d34fa2b534228deadc99bb68e18679a49724d11003", async() => {
                BeginContext(1643, 112, true);
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-success\">Leave</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1600, "../leave/", 1600, 9, true);
#line 48 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
AddHtmlAttributeValue("", 1609, Model.ActivitiyId, 1609, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1762, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1848, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1872, 195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b82d34fa2b534228deadc99bb68e18679a49724d13599", async() => {
                BeginContext(1949, 111, true);
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-success\">Join</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1886, "../join/", 1886, 8, true);
#line 54 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
AddHtmlAttributeValue("", 1894, Model.ActivitiyId, 1894, 18, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1912, "/", 1912, 1, true);
#line 54 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
AddHtmlAttributeValue("", 1913, ViewBag.name.UserId, 1913, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2067, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 57 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                        }

#line default
#line hidden
#line 57 "C:\Users\berek\Desktop\C#\Entity\BeltExam\Views\Home\createdActivity.cshtml"
                         
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Activities> Html { get; private set; }
    }
}
#pragma warning restore 1591