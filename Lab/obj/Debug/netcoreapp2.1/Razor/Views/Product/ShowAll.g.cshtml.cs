#pragma checksum "/home/UserDexter/Documentos/CursoEDx/Lab/Views/Product/ShowAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acab892cce0a99c6fa78d8368efe5b7c262e3ed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowAll), @"mvc.1.0.view", @"/Views/Product/ShowAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ShowAll.cshtml", typeof(AspNetCore.Views_Product_ShowAll))]
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
#line 1 "/home/UserDexter/Documentos/CursoEDx/Lab/Views/_ViewImports.cshtml"
using Lab;

#line default
#line hidden
#line 2 "/home/UserDexter/Documentos/CursoEDx/Lab/Views/_ViewImports.cshtml"
using Lab.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acab892cce0a99c6fa78d8368efe5b7c262e3ed6", @"/Views/Product/ShowAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a9544d4366a552ada71cb570d53e03b4524876c", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Lab.Models.Product>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 12, true);
            WriteLiteral("\n<html>\n    ");
            EndContext();
            BeginContext(44, 445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f112639560c44ba18d82c33160e14540", async() => {
                BeginContext(50, 14, true);
                WriteLiteral("\n        <h1> ");
                EndContext();
                BeginContext(65, 19, false);
#line 5 "/home/UserDexter/Documentos/CursoEDx/Lab/Views/Product/ShowAll.cshtml"
        Write(ViewData["Heading"]);

#line default
#line hidden
                EndContext();
                BeginContext(84, 165, true);
                WriteLiteral(" </h1>\n        <table border=\"1\">\n            <tr>\n                <td> ID </td>\n                <td> Name </td>\n                <td> Price </td>\n            </tr>\n\n");
                EndContext();
#line 13 "/home/UserDexter/Documentos/CursoEDx/Lab/Views/Product/ShowAll.cshtml"
             foreach(var p in Model){

#line default
#line hidden
                BeginContext(287, 46, true);
                WriteLiteral("                <tr>\n                    <td> ");
                EndContext();
                BeginContext(334, 4, false);
#line 15 "/home/UserDexter/Documentos/CursoEDx/Lab/Views/Product/ShowAll.cshtml"
                    Write(p.Id);

#line default
#line hidden
                EndContext();
                BeginContext(338, 32, true);
                WriteLiteral(" </td>\n                    <td> ");
                EndContext();
                BeginContext(371, 6, false);
#line 16 "/home/UserDexter/Documentos/CursoEDx/Lab/Views/Product/ShowAll.cshtml"
                    Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(377, 32, true);
                WriteLiteral(" </td>\n                    <td> ");
                EndContext();
                BeginContext(410, 7, false);
#line 17 "/home/UserDexter/Documentos/CursoEDx/Lab/Views/Product/ShowAll.cshtml"
                    Write(p.Price);

#line default
#line hidden
                EndContext();
                BeginContext(417, 29, true);
                WriteLiteral(" </td>\n                </tr>\n");
                EndContext();
#line 19 "/home/UserDexter/Documentos/CursoEDx/Lab/Views/Product/ShowAll.cshtml"
            }

#line default
#line hidden
                BeginContext(460, 22, true);
                WriteLiteral("\n        </table>\n    ");
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
            BeginContext(489, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Lab.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591