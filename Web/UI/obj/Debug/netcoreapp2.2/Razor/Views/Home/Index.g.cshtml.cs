#pragma checksum "G:\Program Files (x86)\Web\Web\UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a50f19a834d1b52eac95ca5065c13076392eaa4b"
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
#line 1 "G:\Program Files (x86)\Web\Web\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#line 2 "G:\Program Files (x86)\Web\Web\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a50f19a834d1b52eac95ca5065c13076392eaa4b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Script/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Script/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "G:\Program Files (x86)\Web\Web\UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(60, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a50f19a834d1b52eac95ca5065c13076392eaa4b4231", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(123, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a50f19a834d1b52eac95ca5065c13076392eaa4b5483", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(170, 259, true);
            WriteLiteral(@"
<style>

    body {
        margin: 0px;
        padding: 0px;
    }

    .msg {
        margin: 30px;
        height: 300px;
        border: 2px dotted red;
    }
</style>
<div class=""msg"" id=""msgs"">
</div>
<input type=""hidden"" id=""SenderID""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 429, "\"", 458, 1);
#line 22 "G:\Program Files (x86)\Web\Web\UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 437, ViewData["SenderID"], 437, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(459, 41, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"ReceiverID\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 500, "\"", 531, 1);
#line 23 "G:\Program Files (x86)\Web\Web\UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 508, ViewData["ReceiverID"], 508, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(532, 39, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"UserName\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 571, "\"", 600, 1);
#line 24 "G:\Program Files (x86)\Web\Web\UI\Views\Home\Index.cshtml"
WriteAttributeValue("", 579, ViewData["UserName"], 579, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(601, 9, true);
            WriteLiteral(" />\r\n\r\n\r\n");
            EndContext();
            BeginContext(754, 1507, true);
            WriteLiteral(@"<script>
    layui.use(['form'], function () {
        var form = layui.form, layer = layui.layer;
        $ = layui.jquery;
        var userId = $(""#SenderID"").val();
        var protocol = location.protocol === ""https:"" ? ""wss:"" : ""ws:"";
        var wsUri = ""ws:"" + ""//127.0.0.1:5001/ws/?"" + userId;
        console.info(wsUri)
        var socket = new WebSocket(wsUri);
        socket.onopen = e => {
            console.log(""socket opened"", e);
        };
        socket.onclose = function (e) {
            console.log(""socket closed"", e);
        };
        //function to recieve from server.
        socket.onmessage = function (e) {
            console.log(""Message:"" + e.data);
            $('#msgs').append(e.data + '<br />');
        };
        socket.onerror = function (e) {
            console.error(e.data);
        };
        $(""#submit"").click(function () {
            var UserName = $(""#UserName"").val();
            var userId = $(""#SenderID"").val();
            var ReceiverID ");
            WriteLiteral(@"= $(""#ReceiverID"").val();
            console.info(userId + ',' + UserName + ',' + ReceiverID)
            var message = UserName + "":"" + $('#MessageField').val();
            var msgObj = {
                SenderID: userId,
                ReceiverID: ReceiverID,
                MessageType: ""text"",
                Content: message
            };
            socket.send(JSON.stringify(msgObj));
            $('#MessageField').val('');
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591