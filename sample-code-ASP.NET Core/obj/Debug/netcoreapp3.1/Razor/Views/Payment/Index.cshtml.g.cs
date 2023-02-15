#pragma checksum "C:\Users\NW0093\source\repos\sample-code-ASP.NET-CORE\sample-code-ASP.NET Core\Views\Payment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79ba9ff5312fb58cd4c571021f219b010976f1ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Index), @"mvc.1.0.view", @"/Views/Payment/Index.cshtml")]
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
#line 1 "C:\Users\NW0093\source\repos\sample-code-ASP.NET-CORE\sample-code-ASP.NET Core\Views\_ViewImports.cshtml"
using sample_code_ASP.NET_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NW0093\source\repos\sample-code-ASP.NET-CORE\sample-code-ASP.NET Core\Views\_ViewImports.cshtml"
using sample_code_ASP.NET_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79ba9ff5312fb58cd4c571021f219b010976f1ad", @"/Views/Payment/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9bd30812dd0c0728cb3faaf1002c88d5ef36f08", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Payment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/nasswallet-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h-7 sm:h-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\NW0093\source\repos\sample-code-ASP.NET-CORE\sample-code-ASP.NET Core\Views\Payment\Index.cshtml"
  
    ViewData["Title"] = "Test Payment Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""min-h-screen  py-6 flex flex-col justify-center sm:py-12"">
    <div class=""relative py-3 sm:max-w-xl sm:mx-auto"">
        <div class=""absolute inset-0 bg-gradient-to-r from-teal-400 to-blue-400 shadow-lg transform -skew-y-6 sm:skew-y-0 sm:-rotate-6 sm:rounded-3xl""></div>
        <div class=""relative px-4 py-10 bg-white shadow-lg sm:rounded-3xl sm:p-20"">
            <div class=""max-w-md mx-auto"">
                <div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79ba9ff5312fb58cd4c571021f219b010976f1ad4665", async() => {
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
            WriteLiteral(@"
                </div>
                <div class=""divide-y divide-gray-200"">
                    <div class=""py-4 text-base leading-6
                        space-y-4 text-gray-600
                        sm:text-lg sm:leading-7"">
                        <p>
                            DIGITAL BANKING
                            MADE FOR A NEW ERA
                        </p>
                    </div>
                    <div class=""h-64 flex justify-center items-center"">

                        <!-- payment button -->

                        <button onclick=""makePayment()"" name=""makepayment""
                                class=""bg-blue-500 rounded-lg px-4
                                    py-2 font-semibold text-white
                                    flex items-center outline-none
                                    hover:bg-blue-600 focus:outline-none"">

                            <svg class=""w-5 h-5 mr-2"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/20");
            WriteLiteral(@"00/svg""><path d=""M4 4a2 2 0 00-2 2v1h16V6a2 2 0 00-2-2H4z""></path><path fill-rule=""evenodd"" d=""M18 9H2v5a2 2 0 002 2h12a2 2 0 002-2V9zM4 13a1 1 0 011-1h1a1 1 0 110 2H5a1 1 0 01-1-1zm5-1a1 1 0 100 2h1a1 1 0 100-2H9z"" clip-rule=""evenodd""></path></svg>
                            Make Test Payment
                        </button>

                        <!-- End of payment button -->
                    </div>
                    <div class=""pt-6 text-xs leading-6  sm:text-sm sm:leading-7"">
                        <div class=""flex items-center text-gray-600 space-x-2"">
                            <svg class=""w-4 h-4 mr-2"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M5.05 4.05a7 7 0 119.9 9.9L10 18.9l-4.95-4.95a7 7 0 010-9.9zM10 11a2 2 0 100-4 2 2 0 000 4z"" clip-rule=""evenodd""></path></svg>
                            <p class=""text-gray-700"">
                                11th Floor, World Trade Center Gulan Park Tower, Erbil, Iraq
      ");
            WriteLiteral(@"                      </p>
                        </div>

                        <div class=""flex items-center text-gray-600 space-x-2"">
                            <svg class=""w-4 h-4"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path d=""M2 3a1 1 0 011-1h2.153a1 1 0 01.986.836l.74 4.435a1 1 0 01-.54 1.06l-1.548.773a11.037 11.037 0 006.105 6.105l.774-1.548a1 1 0 011.059-.54l4.435.74a1 1 0 01.836.986V17a1 1 0 01-1 1h-2C7.82 18 2 12.18 2 5V3z""></path></svg>
                            <p class=""text-gray-600"">
                                +964 750 900 0900
                            </p>
                        </div>
                        <div class=""flex items-center text-gray-600 space-x-2"">
                            <svg class=""w-4 h-4"" fill=""currentColor"" viewBox=""0 0 20 20"" xmlns=""http://www.w3.org/2000/svg""><path fill-rule=""evenodd"" d=""M4.083 9h1.946c.089-1.546.383-2.97.837-4.118A6.004 6.004 0 004.083 9zM10 2a8 8 0 100 16 8 8 0 000-16zm0 2c-.076 0-.232.0");
            WriteLiteral(@"32-.465.262-.238.234-.497.623-.737 1.182-.389.907-.673 2.142-.766 3.556h3.936c-.093-1.414-.377-2.649-.766-3.556-.24-.56-.5-.948-.737-1.182C10.232 4.032 10.076 4 10 4zm3.971 5c-.089-1.546-.383-2.97-.837-4.118A6.004 6.004 0 0115.917 9h-1.946zm-2.003 2H8.032c.093 1.414.377 2.649.766 3.556.24.56.5.948.737 1.182.233.23.389.262.465.262.076 0 .232-.032.465-.262.238-.234.498-.623.737-1.182.389-.907.673-2.142.766-3.556zm1.166 4.118c.454-1.147.748-2.572.837-4.118h1.946a6.004 6.004 0 01-2.783 4.118zm-6.268 0C6.412 13.97 6.118 12.546 6.03 11H4.083a6.004 6.004 0 002.783 4.118z"" clip-rule=""evenodd""></path></svg>
                            <a class=""text-gray-600"" href=""https://nw.iq"" target=""_blank"">www.nw.iq</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>

    function makePayment() {
        $.ajax({
            type: ""POST"",
            url: '/Payment/callAPI',
            async: true,
            success");
            WriteLiteral(": function (response) {\r\n                window.open(response, \'_self\');\r\n            },\r\n            error: function (error) {\r\n                console.log(error);\r\n            }\r\n        });\r\n\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
