#pragma checksum "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69604d78f4ac57a66935fdec3dc6a2f874ca5bb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
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
#line 1 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
using ListingTodos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69604d78f4ac57a66935fdec3dc6a2f874ca5bb1", @"/Views/Todo/Index.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Styles/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69604d78f4ac57a66935fdec3dc6a2f874ca5bb14108", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Todo list</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "69604d78f4ac57a66935fdec3dc6a2f874ca5bb14467", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69604d78f4ac57a66935fdec3dc6a2f874ca5bb16437", async() => {
                WriteLiteral("\r\n    <h1>TODOS FOR TODAY:</h1>\r\n    <a href=\"/add\">Add new todo</a>\r\n");
#nullable restore
#line 14 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
     using (Html.BeginForm("SearchFor","Todo", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"search\" placeholder=\"Search...\"/>\r\n        <input type=\"submit\" value=\"Search\"/>\r\n");
#nullable restore
#line 18 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <table>
        <thead>
            <tr>
                <th>ID</th>
                <th>Title</th>
                <th>Description</th>
                <th>DONE</th>
                <th>URGENT</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 30 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
             foreach (var todo in Model.Todos.ToList())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
                   Write(todo.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 933, "\"", 955, 2);
#nullable restore
#line 34 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
WriteAttributeValue("", 940, todo.Id, 940, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 948, "/detail", 948, 7, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
                                             Write(todo.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
                   Write(todo.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
                   Write(todo.IsDone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
                   Write(todo.IsUrgent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><form");
                BeginWriteAttribute("action", " action=\"", 1144, "\"", 1168, 2);
#nullable restore
#line 38 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1153, todo.Id, 1153, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1161, "/delete", 1161, 7, true);
                EndWriteAttribute();
                WriteLiteral(" method=\"Post\"><button>delete</button></form></td>\r\n                    <td><form");
                BeginWriteAttribute("action", " action=\"", 1250, "\"", 1272, 2);
#nullable restore
#line 39 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1259, todo.Id, 1259, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1267, "/edit", 1267, 5, true);
                EndWriteAttribute();
                WriteLiteral(" method=\"Get\"><button>edit</button></form></td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <input type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1416, "\"", 1491, 3);
                WriteAttributeValue("", 1426, "location.href=\'", 1426, 15, true);
#nullable restore
#line 44 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1441, Url.Action("Index","Todo",new { isDone = true }), 1441, 49, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1490, "\'", 1490, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"FINISHED\">\r\n    <input type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1536, "\"", 1612, 3);
                WriteAttributeValue("", 1546, "location.href=\'", 1546, 15, true);
#nullable restore
#line 45 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1561, Url.Action("Index","Todo",new { isDone = false }), 1561, 50, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1611, "\'", 1611, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"NOT FINISHED\">\r\n    <input type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1661, "\"", 1714, 3);
                WriteAttributeValue("", 1671, "location.href=\'", 1671, 15, true);
#nullable restore
#line 46 "C:\Users\Marek\Desktop\greenfox\ToDoList\ListingTodos\Views\Todo\Index.cshtml"
WriteAttributeValue("", 1686, Url.Action("Index","Todo"), 1686, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1713, "\'", 1713, 1, true);
                EndWriteAttribute();
                WriteLiteral(" value=\"SHOW ALL\">\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
