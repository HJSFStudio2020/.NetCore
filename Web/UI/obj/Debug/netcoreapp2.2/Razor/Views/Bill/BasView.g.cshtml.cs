#pragma checksum "G:\Program Files (x86)\Web\Web\UI\Views\Bill\BasView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "940ac73add11d226eca867e23c8568efda4e2edf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bill_BasView), @"mvc.1.0.view", @"/Views/Bill/BasView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bill/BasView.cshtml", typeof(AspNetCore.Views_Bill_BasView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"940ac73add11d226eca867e23c8568efda4e2edf", @"/Views/Bill/BasView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Bill_BasView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/layuiadmin/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layuiadmin/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\Program Files (x86)\Web\Web\UI\Views\Bill\BasView.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(56, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "940ac73add11d226eca867e23c8568efda4e2edf4752", async() => {
                BeginContext(62, 93, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>BasView</title>\r\n    ");
                EndContext();
                BeginContext(155, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "940ac73add11d226eca867e23c8568efda4e2edf5232", async() => {
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
                BeginContext(220, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(226, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "940ac73add11d226eca867e23c8568efda4e2edf6564", async() => {
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
                BeginContext(277, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(286, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(288, 4272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "940ac73add11d226eca867e23c8568efda4e2edf8614", async() => {
                BeginContext(294, 4259, true);
                WriteLiteral(@"
    <div>
        <button type=""button"" id=""add"" class=""layui-btn"">添加</button>
        <button type=""button"" id=""Upd"" class=""layui-btn layui-btn-normal"">修改</button>
        <button type=""button"" id=""reload"" class=""layui-btn layui-btn-normal"">刷新</button>
        <button type=""button"" id=""Del"" class=""layui-btn layui-btn-danger"">删除</button>
        <button type=""button"" id=""Magger"" class=""layui-btn layui-btn-danger"">控制台</button>
    </div>
    <table class=""layui-hide"" id=""tab""></table>
    <script>
        layui.use(['form', 'table'], function () {
            var table = layui.table;
            var $ = layui.jquery;
            table.render({
                elem: '#tab'
                , height: 500
                , url: 'http://127.0.0.1:5001/api/Contor/getTable' //数据接口
                , page: true //开启分页
                , cols: [[
                    {
                        field: 'rownum', title: '序号', sort: true   , fixed: 'left', templet: function (d) {
                         ");
                WriteLiteral(@"   return '<input type=""radio"" name=""table"" value=""' + d.tableName + '"">'
                        }
                    },
                    { field: 'tableName', title: '名称', sort: true, fixed: 'left' },
                    { field: 'tableType', title: '类型', sort: true, fixed: 'left' }
                ]]
                , parseData: function (res) { //res 即为原始返回的数据
                    console.info(res);
                    return {
                        ""code"": res.isSuccess == true ? 0 : 500, //解析接口状态
                        ""msg"": res.msg, //解析提示文本
                        ""data"": res.data //
                    };
                }
            })
            $(""#add"").click(function () {
                layer.open({
                    type: 2 //此处以iframe举例
                    , title: '创建新表'
                    , area: ['800px', '600px']
                    , shade: 0
                    , maxmin: true
                    , content: '/Bill/AddTable?Type=Add'
                })
");
                WriteLiteral(@"            })
            $(""#Del"").click(function () {
                layer.confirm('是否确定删除？', {
                    btn: ['确定', '取消']
                }, function (index) {
                    var tablename = $(""input[name='table']:checked"").val();
                    if (tablename == """" || tablename == undefined) {
                        alert(""请选择你要删除的表"")
                        return
                    }
                    $.ajax({
                        url: ""http://127.0.0.1:5001/api/Contor/DelTable"",
                        data: { TableName: tablename },
                        type: 'post',
                        xhrFields: { withCredentials: true },
                        success: function (data) {
                            console.info(data)
                            if (data.isSuccess == true) {
                                layer.close(index)
                                location.reload()
                            }
                        }
             ");
                WriteLiteral(@"       })
                }, function () {
                })
            })
            $(""#reload"").click(function () {
                location.reload();
            })
            $(""#Upd"").click(function () {
                var tablename = $(""input[name='table']:checked"").val();
                if (tablename == """" || tablename == undefined) {
                    alert(""请选择需要修改的表"");
                    return
                }
                layer.open({
                    type: 2 //此处以iframe举例
                    , title: '创建新表'
                    , area: ['800px', '600px']
                    , shade: 0
                    , maxmin: true
                    , content: '/Bill/AddTable?UpdTable=' + tablename + '&&Type=Upd'
                })
            })
            $(""#Magger"").click(function () {
                layer.open({
                    type: 2 //此处以iframe举例
                    , title: '执行Sql语句'
                    , area: ['800px', '600px']
                    ");
                WriteLiteral(", shade: 0\r\n                    , maxmin: true\r\n                    , content: \'/Bill/SqlMagger\'\r\n                })\r\n            })\r\n\r\n        })\r\n    </script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4560, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
