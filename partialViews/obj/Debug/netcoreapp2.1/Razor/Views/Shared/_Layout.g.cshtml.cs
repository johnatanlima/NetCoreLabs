#pragma checksum "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6902cd82733624b1e63f74dfa9caa5b775a38af7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\_ViewImports.cshtml"
using partialViews;

#line default
#line hidden
#line 2 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\_ViewImports.cshtml"
using partialViews.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6902cd82733624b1e63f74dfa9caa5b775a38af7", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28dc941d4a51ca2fd4886cb29326651cc97e8c21", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 12, true);
            WriteLiteral("<html>\r\n    ");
            EndContext();
            BeginContext(12, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "710e451a8a4c4112a9652ab99eaaff77", async() => {
                BeginContext(18, 41, true);
                WriteLiteral("\r\n        <title>My Web App</title>\r\n    ");
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
            BeginContext(66, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(72, 252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e661d2f339747a39d9c38149c5e912b", async() => {
                BeginContext(78, 11, true);
                WriteLiteral("\r\n        |");
                EndContext();
                BeginContext(90, 31, false);
#line 6 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Shared\_Layout.cshtml"
    Write(Html.ActionLink("Home", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(121, 11, true);
                WriteLiteral("\r\n        |");
                EndContext();
                BeginContext(133, 33, false);
#line 7 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Shared\_Layout.cshtml"
    Write(Html.ActionLink("Page1", "Page1"));

#line default
#line hidden
                EndContext();
                BeginContext(166, 11, true);
                WriteLiteral("\r\n        |");
                EndContext();
                BeginContext(178, 33, false);
#line 8 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Shared\_Layout.cshtml"
    Write(Html.ActionLink("Page2", "Page2"));

#line default
#line hidden
                EndContext();
                BeginContext(211, 26, true);
                WriteLiteral("|\r\n        <hr/>\r\n        ");
                EndContext();
                BeginContext(238, 12, false);
#line 10 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(250, 37, true);
                WriteLiteral("\r\n        <hr/>\r\n        Copyright | ");
                EndContext();
                BeginContext(288, 23, false);
#line 12 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Shared\_Layout.cshtml"
               Write(DateTime.Now.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(311, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(324, 11, true);
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