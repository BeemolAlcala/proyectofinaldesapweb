#pragma checksum "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f65a28e3517b945b1646e43aaeea40e0fd43b396"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlayerFixtures_Index), @"mvc.1.0.view", @"/Views/PlayerFixtures/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PlayerFixtures/Index.cshtml", typeof(AspNetCore.Views_PlayerFixtures_Index))]
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
#line 1 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\_ViewImports.cshtml"
using EquiposDeFutbol;

#line default
#line hidden
#line 2 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\_ViewImports.cshtml"
using EquiposDeFutbol.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65a28e3517b945b1646e43aaeea40e0fd43b396", @"/Views/PlayerFixtures/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f146941538127007831d49a9334475adf949b558", @"/Views/_ViewImports.cshtml")]
    public class Views_PlayerFixtures_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EquiposDeFutbol.Models.PlayerFixtures>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(131, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f65a28e3517b945b1646e43aaeea40e0fd43b3963908", async() => {
                BeginContext(154, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(168, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(261, 49, false);
#line 16 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GoalsScoredID));

#line default
#line hidden
            EndContext();
            BeginContext(310, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(366, 42, false);
#line 19 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Player));

#line default
#line hidden
            EndContext();
            BeginContext(408, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(464, 43, false);
#line 22 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fixture));

#line default
#line hidden
            EndContext();
            BeginContext(507, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(625, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(674, 48, false);
#line 31 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GoalsScoredID));

#line default
#line hidden
            EndContext();
            BeginContext(722, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(778, 50, false);
#line 34 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Player.PlayerID));

#line default
#line hidden
            EndContext();
            BeginContext(828, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(884, 52, false);
#line 37 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fixture.FixtureID));

#line default
#line hidden
            EndContext();
            BeginContext(936, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(992, 65, false);
#line 40 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1078, 71, false);
#line 41 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1170, 69, false);
#line 42 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "c:\Users\hatzsen\Documents\proyectofinal\EquiposDeFutbol\Views\PlayerFixtures\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1278, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EquiposDeFutbol.Models.PlayerFixtures>> Html { get; private set; }
    }
}
#pragma warning restore 1591