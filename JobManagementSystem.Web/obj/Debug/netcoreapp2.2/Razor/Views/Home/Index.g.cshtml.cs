#pragma checksum "/home/local/3SI/chinh.nv/Documents/zzz/JobManagementSystem/JobManagementSystem.Web/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e35fca73ab0f688de874416b60df518626f812c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/home/local/3SI/chinh.nv/Documents/zzz/JobManagementSystem/JobManagementSystem.Web/Views/_ViewImports.cshtml"
using JobManagementSystem.Web;

#line default
#line hidden
#line 2 "/home/local/3SI/chinh.nv/Documents/zzz/JobManagementSystem/JobManagementSystem.Web/Views/_ViewImports.cshtml"
using JobManagementSystem.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e35fca73ab0f688de874416b60df518626f812c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d23aed976b2e781b65e352a00aa6cb828786c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Authentication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/home/local/3SI/chinh.nv/Documents/zzz/JobManagementSystem/JobManagementSystem.Web/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_ClientLayout.cshtml";

#line default
#line hidden
            BeginContext(91, 2486, true);
            WriteLiteral(@"
<div class=""site-navbar-wrap js-site-navbar bg-white"">

    <div class=""container"">
        <div class=""site-navbar bg-light"">
            <div class=""py-1"">
                <div class=""row align-items-center"">
                    <div class=""col-2"">
                        <h2 class=""mb-0 site-logo""><a href=""index.html"">Job<strong class=""font-weight-bold"">Finder</strong> </a></h2>
                    </div>
                    <div class=""col-10"">
                        <nav class=""site-navigation text-right"" role=""navigation"">
                            <div class=""container"">
                                <div class=""d-inline-block d-lg-none ml-md-0 mr-auto py-3""><a href=""#"" class=""site-menu-toggle js-menu-toggle text-black""><span class=""icon-menu h3""></span></a></div>

                                <ul class=""site-menu js-clone-nav d-none d-lg-block"">
                                    <li><a href=""categories.html"">For Candidates</a></li>
                                    <li class=""has-children");
            WriteLiteral(@""">
                                        <a href=""category.html"">For Employees</a>
                                        <ul class=""dropdown arrow-top"">
                                            <li><a href=""category.html"">Category</a></li>
                                            <li><a href=""#"">Browse Candidates</a></li>
                                            <li><a href=""new-post.html"">Post a Job</a></li>
                                            <li><a href=""#"">Employeer Profile</a></li>
                                            <li class=""has-children"">
                                                <a href=""#"">More Links</a>
                                                <ul class=""dropdown"">
                                                    <li><a href=""#"">Browse Candidates</a></li>
                                                    <li><a href=""#"">Post a Job</a></li>
                                                    <li><a href=""#"">Employeer Profile</a></li>
                  ");
            WriteLiteral(@"                              </ul>
                                            </li>

                                        </ul>
                                    </li>
                                    <li><a href=""contact.html"">Contact</a></li>
                                    <li><a href=""new-post.html""><span class=""bg-primary text-white py-3 px-4 rounded""><span class=""icon-plus mr-3""></span>Post New Job</span></a></li>
");
            EndContext();
#line 43 "/home/local/3SI/chinh.nv/Documents/zzz/JobManagementSystem/JobManagementSystem.Web/Views/Home/Index.cshtml"
                                     if (User.IsInRole("Admin"))
                                    {

#line default
#line hidden
            BeginContext(2680, 89, true);
            WriteLiteral("                                        <li>\n                                            ");
            EndContext();
            BeginContext(2769, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e35fca73ab0f688de874416b60df518626f812c39047", async() => {
                BeginContext(2830, 43, true);
                WriteLiteral("<i class=\"fa fa-user\"></i>Admin Management ");
                EndContext();
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2877, 47, true);
            WriteLiteral("\n                                        </li>\n");
            EndContext();
#line 48 "/home/local/3SI/chinh.nv/Documents/zzz/JobManagementSystem/JobManagementSystem.Web/Views/Home/Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2962, 36, true);
            WriteLiteral("                                    ");
            EndContext();
#line 49 "/home/local/3SI/chinh.nv/Documents/zzz/JobManagementSystem/JobManagementSystem.Web/Views/Home/Index.cshtml"
                                     if (!User.Identity.IsAuthenticated)
                                    {
                                        

#line default
#line hidden
            BeginContext(3628, 44, true);
            WriteLiteral("                                        <li>");
            EndContext();
            BeginContext(3672, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e35fca73ab0f688de874416b60df518626f812c311644", async() => {
                BeginContext(3729, 57, true);
                WriteLiteral("<span><span class=\"icon-sign-in mr-3\"></span>Login</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3790, 50, true);
            WriteLiteral("</li>\n                                        <li>");
            EndContext();
            BeginContext(3840, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e35fca73ab0f688de874416b60df518626f812c313302", async() => {
                BeginContext(3890, 62, true);
                WriteLiteral("<span><span class=\"icon-user-plus mr-3\"></span>Register</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3956, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 59 "/home/local/3SI/chinh.nv/Documents/zzz/JobManagementSystem/JobManagementSystem.Web/Views/Home/Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4000, 596, true);
            WriteLiteral(@"                                   

                                </ul>
                            </div>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div style=""height: 113px;""></div>

<div class=""site-blocks-cover overlay"" style=""background-image: url('images/hero_1.jpg');"" data-aos=""fade"" data-stellar-background-ratio=""0.5"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-12"" data-aos=""fade"">
                <h1>Find Job</h1>
                ");
            EndContext();
            BeginContext(4596, 1514, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e35fca73ab0f688de874416b60df518626f812c315819", async() => {
                BeginContext(4613, 1490, true);
                WriteLiteral(@"
                    <div class=""row mb-3"">
                        <div class=""col-md-9"">
                            <div class=""row"">
                                <div class=""col-md-6 mb-3 mb-md-0"">
                                    <input type=""text"" class=""mr-3 form-control border-0 px-4"" placeholder=""job title, keywords or company name "">
                                </div>
                                <div class=""col-md-6 mb-3 mb-md-0"">
                                    <div class=""input-wrap"">
                                        <span class=""icon icon-room""></span>
                                        <input type=""text"" class=""form-control form-control-block search-input  border-0 px-4"" id=""autocomplete"" placeholder=""city, province or region"" onFocus=""geolocate()"">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-3"">
                         ");
                WriteLiteral(@"   <input type=""submit"" class=""btn btn-search btn-primary btn-block"" value=""Search"">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <p class=""small"">or browse by category: <a href=""#"" class=""category"">Category #1</a> <a href=""#"" class=""category"">Category #2</a></p>
                        </div>
                    </div>

                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6110, 3518, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>


<div class=""site-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 mx-auto text-center mb-5 section-heading"">
                <h2 class=""mb-5"">Popular Categories</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-sm-6 col-md-4 col-lg-3 mb-3"" data-aos=""fade-up"" data-aos-delay=""100"">
                <a href=""#"" class=""h-100 feature-item"">
                    <span class=""d-block icon flaticon-calculator mb-3 text-primary""></span>
                    <h2>Accounting / Finanace</h2>
                    <span class=""counting"">10,391</span>
                </a>
            </div>
            <div class=""col-sm-6 col-md-4 col-lg-3 mb-3"" data-aos=""fade-up"" data-aos-delay=""200"">
                <a href=""#"" class=""h-100 feature-item"">
                    <span class=""d-block icon flaticon-wrench mb-3 text-primary""></span>
                    <h2>Automotive Jobs</h2>
            ");
            WriteLiteral(@"        <span class=""counting"">192</span>
                </a>
            </div>
            <div class=""col-sm-6 col-md-4 col-lg-3 mb-3"" data-aos=""fade-up"" data-aos-delay=""300"">
                <a href=""#"" class=""h-100 feature-item"">
                    <span class=""d-block icon flaticon-worker mb-3 text-primary""></span>
                    <h2>Construction / Facilities</h2>
                    <span class=""counting"">1,021</span>
                </a>
            </div>
            <div class=""col-sm-6 col-md-4 col-lg-3 mb-3"" data-aos=""fade-up"" data-aos-delay=""400"">
                <a href=""#"" class=""h-100 feature-item"">
                    <span class=""d-block icon flaticon-telecommunications mb-3 text-primary""></span>
                    <h2>Telecommunications</h2>
                    <span class=""counting"">1,219</span>
                </a>
            </div>
            <div class=""col-sm-6 col-md-4 col-lg-3 mb-3"" data-aos=""fade-up"" data-aos-delay=""500"">
                <a href=""#"" class=""h-100 feature-it");
            WriteLiteral(@"em"">
                    <span class=""d-block icon flaticon-stethoscope mb-3 text-primary""></span>
                    <h2>Healthcare</h2>
                    <span class=""counting"">482</span>
                </a>
            </div>
            <div class=""col-sm-6 col-md-4 col-lg-3 mb-3"" data-aos=""fade-up"" data-aos-delay=""600"">
                <a href=""#"" class=""h-100 feature-item"">
                    <span class=""d-block icon flaticon-computer-graphic mb-3 text-primary""></span>
                    <h2>Design, Art &amp; Multimedia</h2>
                    <span class=""counting"">5,409</span>
                </a>
            </div>
            <div class=""col-sm-6 col-md-4 col-lg-3 mb-3"" data-aos=""fade-up"" data-aos-delay=""700"">
                <a href=""#"" class=""h-100 feature-item"">
                    <span class=""d-block icon flaticon-trolley mb-3 text-primary""></span>
                    <h2>Transportation &amp; Logistics</h2>
                    <span class=""counting"">291</span>
                </a>
     ");
            WriteLiteral(@"       </div>
            <div class=""col-sm-6 col-md-4 col-lg-3 mb-3"" data-aos=""fade-up"" data-aos-delay=""800"">
                <a href=""#"" class=""h-100 feature-item"">
                    <span class=""d-block icon flaticon-restaurant mb-3 text-primary""></span>
                    <h2>Restaurant / Food Service</h2>
                    <span class=""counting"">329</span>
                </a>
            </div>
        </div>

    </div>
</div>


");
            EndContext();
            BeginContext(20875, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(22260, 3150, true);
            WriteLiteral(@"

<div class=""site-blocks-cover overlay inner-page"" style=""background-image: url('/client/images/hero_1.jpg');"" data-aos=""fade"" data-stellar-background-ratio=""0.5"">
    <div class=""container"">
        <div class=""row align-items-center justify-content-center"">
            <div class=""col-md-6 text-center"" data-aos=""fade"">
                <h1 class=""h3 mb-0"">Your Dream Job</h1>
                <p class=""h3 text-white mb-5"">Is Waiting For You</p>
                <p><a href=""#"" class=""btn btn-outline-warning py-3 px-4"">Find Jobs</a> <a href=""#"" class=""btn btn-warning py-3 px-4"">Apply For A Job</a></p>

            </div>
        </div>
    </div>
</div>



<div class=""site-section site-block-feature bg-light"">
    <div class=""container"">

        <div class=""text-center mb-5 section-heading"">
            <h2>Why Choose Us</h2>
        </div>

        <div class=""d-block d-md-flex border-bottom"">
            <div class=""text-center p-4 item border-right"" data-aos=""fade"">
                <span class=""flaticon-work");
            WriteLiteral(@"er display-3 mb-3 d-block text-primary""></span>
                <h2 class=""h4"">More Jobs Every Day</h2>
                <p>Content a a a a a a a a a a a a a a a a a a a a a a a  a a a a a a  a a a a a a a a aaaaaaaaaa a a a a a a a a a a a a a .....</p>
                <p><a href=""#"">Read More <span class=""icon-arrow-right small""></span></a></p>
            </div>
            <div class=""text-center p-4 item"" data-aos=""fade"">
                <span class=""flaticon-wrench display-3 mb-3 d-block text-primary""></span>
                <h2 class=""h4"">Creative Jobs</h2>
                <p>Content a a a a a a a a a a a a a a a a a a a a a a a  a a a a a a  a a a a a a a a aaaaaaaaaa a a a a a a a a a a a a a .....</p>
                <p><a href=""#"">Read More <span class=""icon-arrow-right small""></span></a></p>
            </div>
        </div>
        <div class=""d-block d-md-flex"">
            <div class=""text-center p-4 item border-right"" data-aos=""fade"">
                <span class=""flaticon-stethoscope display-3 ");
            WriteLiteral(@"mb-3 d-block text-primary""></span>
                <h2 class=""h4"">Healthcare</h2>
                <p>Content a a a a a a a a a a a a a a a a a a a a a a a  a a a a a a  a a a a a a a a aaaaaaaaaa a a a a a a a a a a a a a .....</p>
                <p><a href=""#"">Read More <span class=""icon-arrow-right small""></span></a></p>
            </div>
            <div class=""text-center p-4 item"" data-aos=""fade"">
                <span class=""flaticon-calculator display-3 mb-3 d-block text-primary""></span>
                <h2 class=""h4"">Finance &amp; Accounting</h2>
                <p>Content a a a a a a a a a a a a a a a a a a a a a a a  a a a a a a  a a a a a a a a aaaaaaaaaa a a a a a a a a a a a a a .....</p>
                <p><a href=""#"">Read More <span class=""icon-arrow-right small""></span></a></p>
            </div>
        </div>
    </div>
</div>




<div class=""site-section block-15"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 mx-auto text-center mb-5 section-headi");
            WriteLiteral("ng\">\n                <h2>Recent Blog</h2>\n            </div>\n        </div>\n\n\n");
            EndContext();
            BeginContext(31737, 61, true);
            WriteLiteral("\n        <div class=\"row\">\n\n        </div>\n    </div>\n</div>\n");
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
