#pragma checksum "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dd49a0b1fb38b1eed89b97348f611944949ba97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductList), @"mvc.1.0.view", @"/Views/Product/ProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductList.cshtml", typeof(AspNetCore.Views_Product_ProductList))]
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
#line 1 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
using partialViews.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dd49a0b1fb38b1eed89b97348f611944949ba97", @"/Views/Product/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28dc941d4a51ca2fd4886cb29326651cc97e8c21", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListVM>
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
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
  
    var start = this.Model.Discount.Start.ToString("d");
    var end = this.Model.Discount.End.ToString("d");
    var rate = this.Model.Discount.Rate;
    var off = (1 - rate) * 100;

#line default
#line hidden
            BeginContext(248, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(258, 466, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "395cd34a6fe442abb66902a609e4852f", async() => {
                BeginContext(264, 53, true);
                WriteLiteral("\r\n<h1>Product List</h1>\r\n<h4 style=\"color: blue\">The ");
                EndContext();
                BeginContext(318, 3, false);
#line 15 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
                       Write(off);

#line default
#line hidden
                EndContext();
                BeginContext(321, 34, true);
                WriteLiteral("% off discount will be valid from ");
                EndContext();
                BeginContext(356, 5, false);
#line 15 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
                                                             Write(start);

#line default
#line hidden
                EndContext();
                BeginContext(361, 4, true);
                WriteLiteral(" to ");
                EndContext();
                BeginContext(366, 3, false);
#line 15 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
                                                                       Write(end);

#line default
#line hidden
                EndContext();
                BeginContext(369, 120, true);
                WriteLiteral("!</h4>\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>ID</th><th>Name</th><th>Price</th><th>Discount Price</th>\r\n    </tr>\r\n");
                EndContext();
#line 20 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
     foreach (var p in this.Model.Products){

#line default
#line hidden
                BeginContext(535, 30, true);
                WriteLiteral("        <tr>\r\n            <td>");
                EndContext();
                BeginContext(566, 4, false);
#line 22 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
           Write(p.ID);

#line default
#line hidden
                EndContext();
                BeginContext(570, 25, true);
                WriteLiteral(" </td> \r\n            <td>");
                EndContext();
                BeginContext(596, 6, false);
#line 23 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
           Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(602, 24, true);
                WriteLiteral(" </td>\r\n            <td>");
                EndContext();
                BeginContext(627, 7, false);
#line 24 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
           Write(p.Price);

#line default
#line hidden
                EndContext();
                BeginContext(634, 24, true);
                WriteLiteral(" </td>\r\n            <td>");
                EndContext();
                BeginContext(660, 14, false);
#line 25 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
            Write(p.Price * rate);

#line default
#line hidden
                EndContext();
                BeginContext(675, 23, true);
                WriteLiteral(" </td>\r\n        </tr>\r\n");
                EndContext();
#line 27 "C:\Users\pcosta\Contacts\Code\Files\WorkspaceGithub\NetCoreLabs\partialViews\Views\Product\ProductList.cshtml"
    }

#line default
#line hidden
                BeginContext(705, 12, true);
                WriteLiteral("\r\n</table>\r\n");
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
            BeginContext(724, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
