#pragma checksum "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f74b15b3f4241ef110eb3e1e9a64af30940dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\_ViewImports.cshtml"
using Kafee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\_ViewImports.cshtml"
using Kafee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f74b15b3f4241ef110eb3e1e9a64af30940dd7", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"644a1005874019f4c1c62351ef34fa1de32bb02d", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kafee.Models.Menu>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn1 flex-c-m size1 txt3 trans-0-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_ALayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Slide1 -->
	<section class=""section-slide"">
		<div class=""wrap-slick1"">
			<div class=""slick1"">
				<div class=""item-slick1 item1-slick1"" style=""background-image: url(/Site/images/slide1-01.jpg);"">
					<div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
						<span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""fadeInDown"">
							Coşkunca Cafeye
						</span>

						<h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""fadeInUp"">
							Hoş Geldiniz
						</h2>

						<div class=""wrap-btn-slide1 animated visible-false"" data-appear=""zoomIn"">
							<!-- Button1 -->
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f74b15b3f4241ef110eb3e1e9a64af30940dd75443", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\tMenüler\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
						</div>
					</div>
				</div>

				<div class=""item-slick1 item2-slick1"" style=""background-image: url(/Site/images/master-slides-02.jpg);"">
					<div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
						<span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""rollIn"">
							Coşkunca Cafeye
						</span>

						<h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""lightSpeedIn"">
							Hoş Geldiniz
						</h2>

						<div class=""wrap-btn-slide1 animated visible-false"" data-appear=""slideInUp"">
							<!-- Button1 -->
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f74b15b3f4241ef110eb3e1e9a64af30940dd77789", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\tMenüler\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
						</div>
					</div>
				</div>

				<div class=""item-slick1 item3-slick1"" style=""background-image: url(/Site/images/master-slides-01.jpg);"">
					<div class=""wrap-content-slide1 sizefull flex-col-c-m p-l-15 p-r-15 p-t-150 p-b-170"">
						<span class=""caption1-slide1 txt1 t-center animated visible-false m-b-15"" data-appear=""rotateInDownLeft"">
							Coşkunca Cafeye
						</span>

						<h2 class=""caption2-slide1 tit1 t-center animated visible-false m-b-37"" data-appear=""rotateInUpRight"">
							Hoş Geldiniz
						</h2>

						<div class=""wrap-btn-slide1 animated visible-false"" data-appear=""rotateIn"">
							<!-- Button1 -->
							");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f74b15b3f4241ef110eb3e1e9a64af30940dd710147", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\tMenüler\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\r\n\t\t\t<div class=\"wrap-slick1-dots\"></div>\r\n\t\t</div>\r\n\t</section>\r\n\r\n\t<div class=\"section-gallery p-t-20\">\r\n\t    ");
#nullable restore
#line 75 "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t</div>\r\n\t<section class=\"section-lunch bgwhite\">\r\n\t\t\r\n\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row p-t-10\">\r\n");
#nullable restore
#line 83 "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\Home\Index.cshtml"
                 foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-md-12 col-lg-6\">\r\n\t\t\t\t\t<!-- Block3 -->\r\n\t\t\t\t\t<div class=\"blo3 flex-w flex-col-l-sm m-b-30\">\r\n\t\t\t\t\t\t<div class=\"pic-blo3 size20 bo-rad-10 hov-img-zoom m-r-28\">\r\n\t\t\t\t\t\t\t<a ><img");
            BeginWriteAttribute("src", " src=\"", 3106, "\"", 3123, 1);
#nullable restore
#line 89 "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 3112, item.Image, 3112, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-MENU\"></a>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"text-blo3 size21 flex-col-l-m\">\r\n\t\t\t\t\t\t\t<a  class=\"txt21 m-b-3\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 94 "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</a>\r\n\r\n\t\t\t\t\t\t\t<span class=\"txt23\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 98 "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t<span class=\"txt22 m-t-20\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 102 "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\Home\Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (₺)\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\r\n\t\t\t\t</div>\n");
#nullable restore
#line 109 "C:\Users\furka\source\repos\Kafee\Kafee\Areas\Customer\Views\Home\Index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\r\n\t\t\t\t\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kafee.Models.Menu>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
