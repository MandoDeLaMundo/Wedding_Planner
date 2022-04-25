#pragma checksum "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "525e99a824bf57dde5aa30de339cb7ef522dd1f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Weddings_Details), @"mvc.1.0.view", @"/Views/Weddings/Details.cshtml")]
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
#line 1 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\_ViewImports.cshtml"
using Wedding_Planner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\_ViewImports.cshtml"
using Wedding_Planner.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"525e99a824bf57dde5aa30de339cb7ef522dd1f5", @"/Views/Weddings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cf5d1ea9f62c62fab4bb370e89f61a4f9b80021", @"/Views/_ViewImports.cshtml")]
    public class Views_Weddings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Weddings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
  
    bool alreadyRSVPd = Model.WeddingGuestRSVPd.Any(r => r.UserId == Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-center\">Wedding Details</h2>\r\n\r\n    <div class=\"card shadow rounded w-100 mb-3 mx-auto\">\r\n        <h4 class=\"card-title text-center bg-dark text-light py-2 rounded-top\">\r\n            ");
#nullable restore
#line 11 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
       Write(Model.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and ");
#nullable restore
#line 11 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                            Write(Model.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Wedding\r\n        </h4>\r\n\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text\">");
#nullable restore
#line 15 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                            Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <small class=\"text-muted\">Planned by ");
#nullable restore
#line 16 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                                            Write(Model.Planner.FullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            <h3>Guests:</h3>\r\n            <ul>\r\n");
#nullable restore
#line 19 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                 foreach (WeddingGuestRSVP RSVPer in Model.WeddingGuestRSVPd)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 21 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                   Write(RSVPer.User.FullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 22 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
         if (Model.ImgUrl != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img");
            BeginWriteAttribute("src", " src=\"", 885, "\"", 904, 1);
#nullable restore
#line 28 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
WriteAttributeValue("", 891, Model.ImgUrl, 891, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 905, "\"", 932, 1);
#nullable restore
#line 28 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
WriteAttributeValue("", 911, Model.WeddingAddress, 911, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 29 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"container\">\r\n            <div class=\"card-footer row justify-content-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "525e99a824bf57dde5aa30de339cb7ef522dd1f58692", async() => {
                WriteLiteral("\r\n                    <button class=\"btn btn-link\">\r\n");
#nullable restore
#line 35 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                         if (alreadyRSVPd)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span class=\"text-warning\">UnRSVP</span>\r\n");
#nullable restore
#line 38 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span>RSVP</span>\r\n");
#nullable restore
#line 42 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-weddingId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                                                                           WriteLiteral(Model.WeddingId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["weddingId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-weddingId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["weddingId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 46 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                 if (Model.UserId == Context.Session.GetInt32("UserId"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "525e99a824bf57dde5aa30de339cb7ef522dd1f512961", async() => {
                WriteLiteral("\r\n                        <button class=\"btn btn-link text-danger\">Delete</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-weddingId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                                                                                 WriteLiteral(Model.WeddingId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["weddingId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-weddingId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["weddingId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\armti\Desktop\coding_dojo\c#\belt_prep\Wedding_Planner\Views\Weddings\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
