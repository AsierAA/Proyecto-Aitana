#pragma checksum "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c9f56297478c9dea12d9dc7a9e5766bac4f74b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\_ViewImports.cshtml"
using Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\_ViewImports.cshtml"
using Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c9f56297478c9dea12d9dc7a9e5766bac4f74b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca7828e27a152be4cd8b1f2c1fa15ad084747ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Presentation.Models.UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/users.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/users.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "MyVehicles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91c9f56297478c9dea12d9dc7a9e5766bac4f74b4540", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91c9f56297478c9dea12d9dc7a9e5766bac4f74b4802", async() => {
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
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Users</h1>\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 15 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
 foreach (var user in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card mb-3\">\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\"");
            BeginWriteAttribute("onclick", " onclick=\"", 381, "\"", 420, 3);
            WriteAttributeValue("", 391, "toggleUserDetails(\'", 391, 19, true);
#nullable restore
#line 19 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 410, user.Id, 410, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 418, "\')", 418, 2, true);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 19 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                                                                       Write(user.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                                                                                  Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 471, "\"", 496, 2);
            WriteAttributeValue("", 476, "UserDetails_", 476, 12, true);
#nullable restore
#line 20 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 488, user.Id, 488, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"table-responsive hidden\" >\r\n                <table class=\"table table-bordered\">\r\n                    <tr>\r\n                        <td>DNI</td>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                       Write(user.DNI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>License</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                       Write(user.License);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Phone</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                       Write(user.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td colspan=\"2\">\r\n                            <button class=\"btn btn-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1128, "\"", 1170, 3);
            WriteAttributeValue("", 1138, "toggleVehicleDetails(\'", 1138, 22, true);
#nullable restore
#line 36 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 1160, user.Id, 1160, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1168, "\')", 1168, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                                                                                               Write(user.Vehicles.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Vehicles</button>\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n                <div");
            BeginWriteAttribute("id", " id=\"", 1316, "\"", 1344, 2);
            WriteAttributeValue("", 1321, "VehicleDetails_", 1321, 15, true);
#nullable restore
#line 40 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 1336, user.Id, 1336, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"table-responsive\" >\r\n                    <table class=\"table table-striped\">\r\n");
#nullable restore
#line 42 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                         if (user.Vehicles != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <thead>
                                <tr>
                                    <th>Brand</th>
                                    <th>Model</th>
                                    <th>Engine</th>
                                    <th>Category</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 53 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                                 foreach (var vehicle in user.Vehicles)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                                       Write(vehicle.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                                       Write(vehicle.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                                       Write(vehicle.Engine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 59 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                                       Write(vehicle.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n");
#nullable restore
#line 63 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 69 "C:\Users\Lenovo\Desktop\Prueba AITANA\Presentation\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91c9f56297478c9dea12d9dc7a9e5766bac4f74b14575", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Presentation.Models.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
