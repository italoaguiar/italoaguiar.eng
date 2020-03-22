#pragma checksum "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e0ae223e2ad58f984064bf00f1664e86ebc8cf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Site.Shared
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
#line 1 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Shared\NavMenu.razor"
using Firebase.Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Shared\NavMenu.razor"
using Firebase.Database.Query;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Shared\NavMenu.razor"
using Model;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\italo\source\repos\italoaguiar.eng\src\Site\Site\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private List<FirebaseObject<Skill>> skills = new List<FirebaseObject<Skill>>();

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    protected async override void OnInitialized()
    {
        var firebase = new FirebaseClient("https://sitepessoal-70bcd.firebaseio.com/");

        skills = (await firebase.Child("skills").OnceAsync<Skill>()).ToList();

        await InvokeAsync(StateHasChanged);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
