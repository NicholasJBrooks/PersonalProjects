#pragma checksum "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8173e2670adb6ca2a40b2aee0454da7b094645e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Import_ImportList), @"mvc.1.0.view", @"/Views/Import/ImportList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Import/ImportList.cshtml", typeof(AspNetCore.Views_Import_ImportList))]
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
#line 1 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\_ViewImports.cshtml"
using BlankFinance.Models;

#line default
#line hidden
#line 2 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\_ViewImports.cshtml"
using BlankFinance.Models.ViewModels;

#line default
#line hidden
#line 1 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml"
using System.Collections.ObjectModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8173e2670adb6ca2a40b2aee0454da7b094645e", @"/Views/Import/ImportList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee999ccef3e9dedbcaeac9dd2ad0428030bc127b", @"/Views/_ViewImports.cshtml")]
    public class Views_Import_ImportList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ImportAFIle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(108, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d767f4930fa4b88afb300429f7b4c8f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(151, 498, true);
            WriteLiteral(@"

<div class=""col-12"">
    <button class=""btn btn-block"" onclick=""ChooseFile()"">Import File</button>
    <button class=""btn btn-block"" onclick=""InputTransaction()"">Input Transaction</button>
</div>
<div id=""popup"" class=""col-12 popup""></div>
<table class=""table table-striped table-bordered col-12"">
    <thead>
        <tr>
            <td>Date</td>
            <td>Category</td>
            <td>Description</td>
            <td>Amount</td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 25 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#line 27 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml"
             foreach (Transaction trans in Model)
            {

#line default
#line hidden
            BeginContext(755, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(802, 10, false);
#line 30 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml"
                   Write(trans.Date);

#line default
#line hidden
            EndContext();
            BeginContext(812, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(844, 14, false);
#line 31 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml"
                   Write(trans.Category);

#line default
#line hidden
            EndContext();
            BeginContext(858, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(890, 17, false);
#line 32 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml"
                   Write(trans.Description);

#line default
#line hidden
            EndContext();
            BeginContext(907, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(939, 12, false);
#line 33 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml"
                   Write(trans.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(951, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml"
            }

#line default
#line hidden
#line 35 "C:\Users\NIck Brooks\Documents\GitHub\PersonalProjects\BlankFinance\BlankFinance\Views\Import\ImportList.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1007, 120, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<button onclick=\"SaveTransactions()\" class=\"btn col-12\">\r\n    Save Transactions\r\n</button>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
