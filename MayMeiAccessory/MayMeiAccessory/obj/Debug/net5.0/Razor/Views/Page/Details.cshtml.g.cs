#pragma checksum "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\Page\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0bb78ae46ed0aaf4f50eb3d6ad92884aeddb6e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Details), @"mvc.1.0.view", @"/Views/Page/Details.cshtml")]
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
#line 1 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\_ViewImports.cshtml"
using MayMeiAccessory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\_ViewImports.cshtml"
using MayMeiAccessory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0bb78ae46ed0aaf4f50eb3d6ad92884aeddb6e6", @"/Views/Page/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807a6f29a8d8e266aa2b40344db00254b2f6ba5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Page_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MayMeiAccessory.Models.Page>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\Page\Details.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/page/{Model.Alias}";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""~/assets/images/about/banner/1-1-1920x598.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h1 class=""breadcrumb-heading"">");
#nullable restore
#line 14 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\Page\Details.cshtml"
                                                  Write(Model.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <ul>\r\n                            <li>\r\n                                <a href=\"/\">Trang chủ <i class=\"pe-7s-angle-right\"></i></a>\r\n                            </li>\r\n                            <li>");
#nullable restore
#line 19 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\Page\Details.cshtml"
                           Write(Model.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""blog-detail-item"">
                        <div class=""blog-img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0bb78ae46ed0aaf4f50eb3d6ad92884aeddb6e65401", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1252, "~/images/pages/", 1252, 15, true);
#nullable restore
#line 32 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\Page\Details.cshtml"
AddHtmlAttributeValue("", 1267, Model.Thumb, 1267, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\Page\Details.cshtml"
AddHtmlAttributeValue("", 1286, Model.Title, 1286, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""blog-content text-start pb-0"">
                            <div class=""blog-meta text-dim-gray pb-3"">
                                <ul>
                                    <li class=""date""><i class=""fa fa-calendar-o me-2""></i>");
#nullable restore
#line 37 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\Page\Details.cshtml"
                                                                                     Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    <li>
                                        <span class=""comments me-3"">
                                            <a href=""javascript:void(0)"">2 Comments</a>
                                        </span>
                                        <span class=""link-share"">
                                            <a href=""javascript:void(0)"">Share</a>
                                        </span>
                                    </li>
                                </ul>
                            </div>
                            <h5 class=""title mb-4"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 2282, "\"", 2293, 1);
#nullable restore
#line 49 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\Page\Details.cshtml"
WriteAttributeValue("", 2289, url, 2289, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 49 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\Page\Details.cshtml"
                                          Write(Model.PageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h5>\r\n                            ");
#nullable restore
#line 51 "D:\DoAnChuyenNganh\MayMeiAccessory\MayMeiAccessory\Views\Page\Details.cshtml"
                       Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MayMeiAccessory.Models.Page> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
