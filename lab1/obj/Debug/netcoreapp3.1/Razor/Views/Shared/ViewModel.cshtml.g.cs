#pragma checksum "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a676868fd0faae2aed30e4c2bd3aaca019ff300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ViewModel), @"mvc.1.0.view", @"/Views/Shared/ViewModel.cshtml")]
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
#line 1 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\_ViewImports.cshtml"
using lab1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\_ViewImports.cshtml"
using lab1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a676868fd0faae2aed30e4c2bd3aaca019ff300", @"/Views/Shared/ViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b856ffc28bb915aac4f86c443e1a63cacffcc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lab1.Models.MyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
  
    ViewData["Title"] = "ViewModel";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h1 class=\"display-4\">PassUsingModel</h1>\r\n        <b>Rand Value First : </b> ");
#nullable restore
#line 8 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
                              Write(Model.num1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>Rand Value Second : </b> ");
#nullable restore
#line 10 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
                               Write(Model.num2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>Add : </b>\r\n        <br />\r\n        ");
#nullable restore
#line 14 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
   Write(Model.num1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 14 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
                 Write(Model.num2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 14 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
                               Write(Model.Add());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>Sub : </b>\r\n        <br />\r\n        ");
#nullable restore
#line 18 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
   Write(Model.num1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
                 Write(Model.num2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 18 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
                               Write(Model.Sub());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>Mult : </b>\r\n        <br />\r\n        ");
#nullable restore
#line 22 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
   Write(Model.num1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" * ");
#nullable restore
#line 22 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
                 Write(Model.num2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 22 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
                               Write(Model.Mult());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        <b>Div : </b>\r\n        <br />\r\n        ");
#nullable restore
#line 26 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
   Write(Model.num1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 26 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
                 Write(Model.num2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 26 "C:\Users\anyap\OneDrive\Рабочий стол\Новая папка\web\lab1\lab1\Views\Shared\ViewModel.cshtml"
                               Write(Model.Div());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lab1.Models.MyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
