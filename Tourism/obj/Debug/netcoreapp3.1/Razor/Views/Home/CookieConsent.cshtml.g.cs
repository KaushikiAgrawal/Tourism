#pragma checksum "D:\New_Travel_Tourism\Tour\Tourism\Tourism\Views\Home\CookieConsent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "302ddb46074343e8684bdb4b5a777583a33c7d1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CookieConsent), @"mvc.1.0.view", @"/Views/Home/CookieConsent.cshtml")]
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
#line 1 "D:\New_Travel_Tourism\Tour\Tourism\Tourism\Views\_ViewImports.cshtml"
using Tourism;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New_Travel_Tourism\Tour\Tourism\Tourism\Views\_ViewImports.cshtml"
using Tourism.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302ddb46074343e8684bdb4b5a777583a33c7d1a", @"/Views/Home/CookieConsent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e254a59347ae7e97bec21b053d223b59d64bb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CookieConsent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\New_Travel_Tourism\Tour\Tourism\Tourism\Views\Home\CookieConsent.cshtml"
  
    ViewBag.Title = "CookieConsent";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<asp:Content ID=""Content1"" ContentPlaceHolderID=""head"" runat=""server"">
</asp:Content>
<asp:Content ID=""Content2"" ContentPlaceHolderID=""ContentPlaceHolder1"" runat=""server"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Sofia"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <style>
        .First {
            width: 800px;
            height: 900px;
            margin: auto;
        }

        .card {
            background: rgba(255,255,255,.7);
        }

        .f {
            background-color: white;
            background-size: cover;
            background-repeat: no-repeat;
            padding-top: 50px;
        }

        #btn:hover, #btn1:hover {
            background-color: black;
            color: white;
            border: 2px solid white;
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
            border-radius: 10px;
        }

        #btn, #btn1 {
          ");
            WriteLiteral(@"  display: block;
            color: white;
            width: 100%;
            border: none;
            background: transparent;
            color: blue;
            padding: 8px 28px;
            font-size: 16px;
            cursor: pointer;
            text-align: center;
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
            border-radius: 10px;
            border: 2px solid blue;
        }

        .purpose {
            color: blue;
        }

            .purpose:hover {
                color: black;
            }

        #flexSwitchCheckChecked {
            width: 20%;
            height: 5%;
        }

        pre {
            letter-spacing: .1px;
        }

        .chkbox1, .rememberMe {
            float: left;
        }

        .headinglogin {
            padding-top: .5em;
            font-family: ""Times New Roman"", Times, serif;
            font-size: 50px;
        }

        h4, h5 {
            fo");
            WriteLiteral(@"nt-family: ""Times New Roman"", Times, serif;
        }

        .itsLink {
            text-decoration: none;
            color: blue;
        }

            .itsLink:hover {
                color: black;
            }

        .card0 {
            box-shadow: 0px 4px 8px 0px #757575;
            border-radius: 0px;
        }

        .card1 {
            text-align: justify;
        }

        .card2 {
            margin: 0px 40px
        }

        .border-line {
            border-right: 1px solid #EEEEEE
        }



        .card1 {
            height: 10px;
            padding-bottom: 100px;
        }

        .card0 {
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
        }


        input,
        textarea {
            padding: 10px 12px 10px 12px;
            border: 1px solid lightgrey;
            border-radius: 2px;
            margin-bottom: 5px;
            margin-top: 2px;
            box-sizing: border-b");
            WriteLiteral(@"ox;
            color: #2C3E50;
            font-size: 14px;
            letter-spacing: 1px
        }

            input:focus,
            textarea:focus {
                -moz-box-shadow: none !important;
                -webkit-box-shadow: none !important;
                box-shadow: none !important;
                border: 1px solid #304FFE;
                outline-width: 0
            }

        button:focus {
            -moz-box-shadow: none !important;
            -webkit-box-shadow: none !important;
            box-shadow: none !important;
            outline-width: 0
        }

        a {
            color: inherit;
            cursor: pointer
        }

        .btn-blue {
            background-color: #1A237E;
            width: 150px;
            color: #fff;
            border-radius: 2px
        }

            .btn-blue:hover {
                background-color: #000;
                cursor: pointer
            }



        ");
            WriteLiteral(@"@media screen and (max-width: 991px) {


            .border-line {
                border-right: none
            }

            .card2 {
                border-top: 1px solid #EEEEEE !important;
                margin: 0px 15px
            }
        }
    </style>
    <div class=""f"">
        <div class=""First"">

            <div class=""container-fluid px-1 px-md-5 px-lg-1 px-xl-5 py-5"">

                <div class=""card card0 border-0"">
                    <center><h4 class=""headinglogin"">Cookie Consent</h4></center>
                    <div class=""row d-flex"">
                        <div class=""col-lg-6"">
                            <div class=""card1 px-5"">
                                <br /><br />

                                <h4><b>This site uses cookies</b></h4><br />
                                <p>Wanderlust and our partners use technology such as cookies on our site to personalize content and ads, provide social media features and analyze our traffic. You can revi");
            WriteLiteral(@"st your consent choices at anytime by returning to this site. By browsing our website, you consent to our use of cookies and other tracking technologies.</p>
                                <br /><button type=""submit"" class=""text-center"" id=""btn"">Accept all cookies</button><br />
                                <button type=""submit"" class=""text-center"" id=""btn1"">Reject all cookies</button><br />
                                <a href=""#"" class=""purpose""><center>Show purposes</center></a>
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""card2 card border-0 px-4 py-5"">
                                <div class=""row mb-4 px-3"">
                                    <pre><h5 class=""mb-0 mr-4 mt-2""><i class='fa fa-key'>  Privacy Settings</i></h5></pre>
                                    <hr /><br /><br />

                                    <div class=""form-check form-switch"">
                    ");
            WriteLiteral(@"                    <input class=""form-check-input"" type=""checkbox"" id=""flexSwitchCheckChecked"" />
                                        <label class=""form-check-label"" for=""flexSwitchCheckChecked""><a class=""itsLink"">Accessing a device</a></label>
                                    </div> <hr />

                                    <div class=""form-check form-switch"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""flexSwitchCheckChecked"" />
                                        <label class=""form-check-label"" for=""flexSwitchCheckChecked""><a class=""itsLink"">Analytics</a></label>
                                    </div> <hr />

                                    <div class=""form-check form-switch"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""flexSwitchCheckChecked"" />
                                        <label class=""form-check-label"" for=""flexSwitchCheckChecked""><a class=""itsLink"">Advertising Per");
            WriteLiteral(@"sonalisation</a></label>
                                    </div> <hr />

                                    <div class=""form-check form-switch"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""flexSwitchCheckChecked"" />
                                        <label class=""form-check-label"" for=""flexSwitchCheckChecked""><a class=""itsLink"">Content Personalisation</a></label>
                                    </div> <hr />


                                </div>

                                <div class=""buttonSet"">
                                    <button type=""submit"" id=""btn"">Save and Exit</button><br />
                                    <button type=""submit"" id=""btn"">Cancel</button>
                                </div>


                                <pre> <a href=""#"" class=""ml-auto mb-0 text-sm""></a></pre>
                            </div>

                            <div class=""row mb-3 px-3""></div>
                       ");
            WriteLiteral("     <div class=\"row mb-4 px-3\"></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    \r\n</asp:Content>\r\n\r\n");
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
