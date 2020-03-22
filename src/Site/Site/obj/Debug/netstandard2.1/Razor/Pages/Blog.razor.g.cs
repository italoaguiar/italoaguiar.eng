#pragma checksum "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e2f68052ee4030a879a6e915e5782ca4dcd332a"
// <auto-generated/>
#pragma warning disable 1591
namespace Site.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using Site.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using Firebase.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using Firebase.Database.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\_Imports.razor"
using Firebase.Database.Query;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blog")]
    public partial class Blog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"pageHeader\">\r\n    <div class=\"container\">\r\n        <h1 class=\"pageTitle\">\r\n            Blog\r\n        </h1>\r\n    </div>\r\n</div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container content");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-9");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "ul");
            __builder.AddAttribute(11, "class", "ms-List");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 17 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor"
                 foreach (Article article in Articles)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "ms-ListItem");
            __builder.AddAttribute(16, "style", "padding:0px 5px 5px 0px;");
            __builder.AddMarkupContent(17, "                    \r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "ms-ListItem-image");
            __builder.AddAttribute(20, "style", "width:150px;");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "img");
            __builder.AddAttribute(23, "src", 
#nullable restore
#line 21 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor"
                                   article.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "style", "width:150px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "span");
            __builder.AddAttribute(28, "class", "ms-ListItem-primaryText");
            __builder.AddContent(29, 
#nullable restore
#line 23 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor"
                                                           article.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "span");
            __builder.AddAttribute(32, "class", "ms-ListItem-secondaryText");
            __builder.AddContent(33, 
#nullable restore
#line 24 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor"
                                                             article.SubTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "span");
            __builder.AddAttribute(36, "class", "ms-ListItem-tertiaryText");
            __builder.AddContent(37, 
#nullable restore
#line 25 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor"
                                                            Left(StripHTML(article.Html), 100)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "class", "stretched-link decoration-none");
            __builder.AddAttribute(41, "href", "blog/" + (
#nullable restore
#line 26 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor"
                                                                          article.Url

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 28 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            <br>\r\n            <br>\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row");
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-3");
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "class", "ms-Button");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor"
                                                        Prev

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.AddMarkupContent(56, "<span class=\"ms-Button-label\">Posts Antigos</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                <div class=\"col-6\"></div>\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "col-3");
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "ms-Button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor"
                                                        Next

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.AddMarkupContent(66, "<span class=\"ms-Button-label\">Posts Recentes</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Pages\Blog.razor"
       

    IEnumerable<Article> Articles { get; set; } = new Article[] { };
    IEnumerable<Article> ServerResponse { get; set; }

    int skip = 20;
    int start = 0;
    int end = 20;

    private async void Next()
    {
        start += skip;
        end += skip;

        Articles = ServerResponse.Skip(start).Take(end);
        await InvokeAsync(StateHasChanged);
    }

    private async void Prev()
    {
        start -= skip;
        end -= skip;

        if (start < 0)
            start = 0;
        if (end < skip)
            end = skip;

        Articles = ServerResponse.Skip(start).Take(end);
        await InvokeAsync(StateHasChanged);
    }

    private string Left(string val, int len)
    {
        int min = Math.Min(val.Length, len);

        return $"{val.Substring(0, min)}...";
    }

    private string StripHTML(string input)
    {
        return System.Text.RegularExpressions.Regex.Replace(input, "<.*?>", String.Empty);
    }

    private async void LoadItens()
    {
        var result = await Database.Child("articles").OrderBy("IsActive").EqualTo(true).OnceAsync<Article>();

        ServerResponse = result.Select(x => x.Object);

        Articles = ServerResponse.Skip(start).Take(end);

        await InvokeAsync(StateHasChanged);
    }

    protected override void OnInitialized()
    {
        LoadItens();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FirebaseClient Database { get; set; }
    }
}
#pragma warning restore 1591