#pragma checksum "C:\Users\HomeWork\Desktop\NetCore Iniciante\WorkShop\src\FilmesCRUDRazor\Pages\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1417bc3c12bcc434104e129c803004ef01f21576"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FilmesCRUDRazor.Pages.Pages_Contact), @"mvc.1.0.razor-page", @"/Pages/Contact.cshtml")]
namespace FilmesCRUDRazor.Pages
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
#line 1 "C:\Users\HomeWork\Desktop\NetCore Iniciante\WorkShop\src\FilmesCRUDRazor\Pages\_ViewImports.cshtml"
using FilmesCRUDRazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1417bc3c12bcc434104e129c803004ef01f21576", @"/Pages/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f03f637ad4cf2d0e4c8cf6ffbde05383ab748a3f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contact : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HomeWork\Desktop\NetCore Iniciante\WorkShop\src\FilmesCRUDRazor\Pages\Contact.cshtml"
  
    ViewData["Title"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 6 "C:\Users\HomeWork\Desktop\NetCore Iniciante\WorkShop\src\FilmesCRUDRazor\Pages\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>");
#nullable restore
#line 7 "C:\Users\HomeWork\Desktop\NetCore Iniciante\WorkShop\src\FilmesCRUDRazor\Pages\Contact.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>\r\n    <p class=\"lead\">Entre em contato comigo através dos  canais abaixo</p>\r\n</h3>\r\n\r\n<br>\r\n<p");
            BeginWriteAttribute("class", " class=\"", 217, "\"", 225, 0);
            EndWriteAttribute();
            WriteLiteral(@" margin-right=""15px"">
   &#x260E;&#xFE0F;+55 011 2222-4433  &#x1F4F1;  +55 011 9999-8080
</p>
    <div class=""container"">
        <div class=""row"">
                <div class=""btn-space"" margin-right=""15px"">
                    <a class=""btn btn-outline-info btn-space""href=""santosem4@hotmail.com""> &#x1F4E7;E-mail</a>
                    <a class=""btn btn-outline-info btn-space""href=""https://www.linkedin.com/in/edmar-santos-m""> &#x1F44D;&#x1F3FF;Linkedin</a>
                    <a class=""btn btn-outline-info""href=""https://github.com/EdmarSantosM""> &#x1F517;Git Hub</a>
                </div>
        </div>

    </div>
     
</p>





");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ContactModel>)PageContext?.ViewData;
        public ContactModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
