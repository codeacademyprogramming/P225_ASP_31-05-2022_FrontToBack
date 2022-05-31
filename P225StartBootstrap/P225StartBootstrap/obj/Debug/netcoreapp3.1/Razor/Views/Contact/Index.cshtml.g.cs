#pragma checksum "C:\Users\hamid.mammadov\Desktop\P225StartBootstrap\P225StartBootstrap\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd288ecbc2c48ceffc8ce872070d81dd73f24120"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd288ecbc2c48ceffc8ce872070d81dd73f24120", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-sb-form-api-token", new global::Microsoft.AspNetCore.Html.HtmlString("API_TOKEN"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hamid.mammadov\Desktop\P225StartBootstrap\P225StartBootstrap\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Contact Section-->
<section class=""page-section"" id=""contact"">
    <div class=""container"">
        <!-- Contact Section Heading-->
        <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Contact Me</h2>
        <!-- Icon Divider-->
        <div class=""divider-custom"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
            <div class=""divider-custom-line""></div>
        </div>
        <!-- Contact Section Form-->
        <div class=""row justify-content-center"">
            <div class=""col-lg-8 col-xl-7"">
                <!-- * * * * * * * * * * * * * * *-->
                <!-- * * SB Forms Contact Form * *-->
                <!-- * * * * * * * * * * * * * * *-->
                <!-- This form is pre-integrated with SB Forms.-->
                <!-- To make this form functional, sign up at-->
                <!-- https://startbootstrap.com/solution/contact-forms-->
");
            WriteLiteral("                <!-- to get an API token!-->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd288ecbc2c48ceffc8ce872070d81dd73f241204979", async() => {
                WriteLiteral(@"
                    <!-- Name input-->
                    <div class=""form-floating mb-3"">
                        <input class=""form-control"" id=""name"" type=""text"" placeholder=""Enter your name..."" data-sb-validations=""required"" />
                        <label for=""name"">Full name</label>
                        <div class=""invalid-feedback"" data-sb-feedback=""name:required"">A name is required.</div>
                    </div>
                    <!-- Email address input-->
                    <div class=""form-floating mb-3"">
                        <input class=""form-control"" id=""email"" type=""email"" placeholder=""name@example.com"" data-sb-validations=""required,email"" />
                        <label for=""email"">Email address</label>
                        <div class=""invalid-feedback"" data-sb-feedback=""email:required"">An email is required.</div>
                        <div class=""invalid-feedback"" data-sb-feedback=""email:email"">Email is not valid.</div>
                    </div>
         ");
                WriteLiteral(@"           <!-- Phone number input-->
                    <div class=""form-floating mb-3"">
                        <input class=""form-control"" id=""phone"" type=""tel"" placeholder=""(123) 456-7890"" data-sb-validations=""required"" />
                        <label for=""phone"">Phone number</label>
                        <div class=""invalid-feedback"" data-sb-feedback=""phone:required"">A phone number is required.</div>
                    </div>
                    <!-- Message input-->
                    <div class=""form-floating mb-3"">
                        <textarea class=""form-control"" id=""message"" type=""text"" placeholder=""Enter your message here..."" style=""height: 10rem"" data-sb-validations=""required""></textarea>
                        <label for=""message"">Message</label>
                        <div class=""invalid-feedback"" data-sb-feedback=""message:required"">A message is required.</div>
                    </div>
                    <!-- Submit success message-->
                    <!---->
  ");
                WriteLiteral(@"                  <!-- This is what your users will see when the form-->
                    <!-- has successfully submitted-->
                    <div class=""d-none"" id=""submitSuccessMessage"">
                        <div class=""text-center mb-3"">
                            <div class=""fw-bolder"">Form submission successful!</div>
                            To activate this form, sign up at
                            <br />
                            <a href=""https://startbootstrap.com/solution/contact-forms"">https://startbootstrap.com/solution/contact-forms</a>
                        </div>
                    </div>
                    <!-- Submit error message-->
                    <!---->
                    <!-- This is what your users will see when there is-->
                    <!-- an error submitting the form-->
                    <div class=""d-none"" id=""submitErrorMessage""><div class=""text-center text-danger mb-3"">Error sending message!</div></div>
                    <!-- Su");
                WriteLiteral("bmit Button-->\r\n                    <button class=\"btn btn-primary btn-xl disabled\" id=\"submitButton\" type=\"submit\">Send</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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