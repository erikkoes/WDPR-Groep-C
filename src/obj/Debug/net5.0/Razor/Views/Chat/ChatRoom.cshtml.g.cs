#pragma checksum "C:\Users\moham\C#_projecten\Wdpr\WDPR-Groep-C\src\Views\Chat\ChatRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6017230d960435f07629ea63dd8cd13619f22e55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_ChatRoom), @"mvc.1.0.view", @"/Views/Chat/ChatRoom.cshtml")]
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
#line 1 "C:\Users\moham\C#_projecten\Wdpr\WDPR-Groep-C\src\Views\_ViewImports.cshtml"
using src;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moham\C#_projecten\Wdpr\WDPR-Groep-C\src\Views\_ViewImports.cshtml"
using src.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6017230d960435f07629ea63dd8cd13619f22e55", @"/Views/Chat/ChatRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6abdd9730bf1b4f2a327dc2e2bda1bd41f892c", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_ChatRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<src.Models.ChatRoom>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\moham\C#_projecten\Wdpr\WDPR-Groep-C\src\Views\Chat\ChatRoom.cshtml"
  

    ViewData["Title"] = Model.RoomName;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
        <div class=""row"">&nbsp;</div>
        <div class=""row"">
            <div class=""col-2"">Message</div>
            <div class=""col-4""><input type=""text"" id=""messageInput"" /></div>
        </div>
        <div class=""row"">&nbsp;</div>
        <div class=""row"">
            <div class=""col-6"">
                <input type=""button"" id=""sendButton"" value=""Send Message"" />
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-12"">
            <hr />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-6"">
            <ul id=""messagesList""></ul>
        </div>
    </div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6017230d960435f07629ea63dd8cd13619f22e554729", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6017230d960435f07629ea63dd8cd13619f22e555768", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();

    connection.on(""RecieveMessage"", function (messageObj) {
        console.log(messageObj);
        var e = document.getElementById('messageList');

        var li = document.createElement(""li"");
        document.getElementById(""messagesList"").appendChild(li);
        li.textContent = `${messageObj.userName}: ${messageObj.messageContent}`;

        $(e).append(li)
");
                WriteLiteral("    })\r\n\r\n    connection.start().then(function () {\r\n        connection.invoke(\'JoinRoom\', \'");
#nullable restore
#line 50 "C:\Users\moham\C#_projecten\Wdpr\WDPR-Groep-C\src\Views\Chat\ChatRoom.cshtml"
                                  Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n        console.log(\'Connected\');\r\n    }).catch(function (err) {\r\n        console.log(err)\r\n    })\r\n\r\n    window.addEventListener(\'onunload\', function () {\r\n        connection.invoke(\'leaveRoom\', \'");
#nullable restore
#line 57 "C:\Users\moham\C#_projecten\Wdpr\WDPR-Groep-C\src\Views\Chat\ChatRoom.cshtml"
                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n    })\r\n\r\n    $(\'#sendButton\').on(\'click\', function(e) {\r\n        let msg = $(\'#messageInput\').val();\r\n        $.ajax(\r\n            {\r\n                type: \"POST\",\r\n                url: \'");
#nullable restore
#line 65 "C:\Users\moham\C#_projecten\Wdpr\WDPR-Groep-C\src\Views\Chat\ChatRoom.cshtml"
                 Write(Url.Action("SendMessage", "Chat"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                data:\r\n                {\r\n                    UserId: \"");
#nullable restore
#line 68 "C:\Users\moham\C#_projecten\Wdpr\WDPR-Groep-C\src\Views\Chat\ChatRoom.cshtml"
                        Write(ViewBag.loggedInUserId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                    ChatId: ");
#nullable restore
#line 69 "C:\Users\moham\C#_projecten\Wdpr\WDPR-Groep-C\src\Views\Chat\ChatRoom.cshtml"
                       Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    Message: msg,\r\n                }\r\n            }\r\n        )\r\n    });\r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<src.Models.ChatRoom> Html { get; private set; }
    }
}
#pragma warning restore 1591
