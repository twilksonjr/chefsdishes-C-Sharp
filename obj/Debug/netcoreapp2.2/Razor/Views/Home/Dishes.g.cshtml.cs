#pragma checksum "/Users/macbook/Desktop/CSharp_stack/Entity_framework/chefsdishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0f8c9a3fe9c3608466fc2641e69832883b9317d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/chefsdishes/Views/_ViewImports.cshtml"
using chefsdishes;

#line default
#line hidden
#line 2 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/chefsdishes/Views/_ViewImports.cshtml"
using chefsdishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0f8c9a3fe9c3608466fc2641e69832883b9317d", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a705c8d3c4321c0ccdd662448eb7e5a4a7d81b32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 716, true);
            WriteLiteral(@"<!-- Insert Model Here -->
<div class=""row justify-content-center"">
    <div>
        <div>
            <a href=""newDish"">Add a Dish</a>
            <a href=""/"">Chefs</a>
            <h1>Yum, take a look at our tasty dishes!</h1>
        </div>
        <div>
            <table class=""table table-striped h-25 scroll"">
            <thead class=""thead-light"">
                <tr>
                    <th scope=""col"" style=""width: 30%;"">Name</th>
                    <th scope=""col"" style=""width: 30%;"">Chef</th>
                    <th scope=""col"" style=""width: 20%;"">Tastiness</th>
                    <th scope=""col"" style=""width: 20%;"">Calories</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 21 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/chefsdishes/Views/Home/Dishes.cshtml"
                 foreach(var dish in Model)
                {

#line default
#line hidden
            BeginContext(796, 53, true);
            WriteLiteral("                    <tr>\n                        <td>");
            EndContext();
            BeginContext(850, 9, false);
#line 24 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/chefsdishes/Views/Home/Dishes.cshtml"
                       Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(859, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(894, 22, false);
#line 25 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/chefsdishes/Views/Home/Dishes.cshtml"
                       Write(dish.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(916, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(918, 21, false);
#line 25 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/chefsdishes/Views/Home/Dishes.cshtml"
                                               Write(dish.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(939, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(974, 14, false);
#line 26 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/chefsdishes/Views/Home/Dishes.cshtml"
                       Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(988, 34, true);
            WriteLiteral("</td>\n                        <td>");
            EndContext();
            BeginContext(1023, 13, false);
#line 27 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/chefsdishes/Views/Home/Dishes.cshtml"
                       Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 32, true);
            WriteLiteral("</td>\n                    </tr>\n");
            EndContext();
#line 29 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/chefsdishes/Views/Home/Dishes.cshtml"
                }

#line default
#line hidden
            BeginContext(1086, 82, true);
            WriteLiteral("            </table>\n        </div>\n        <div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
