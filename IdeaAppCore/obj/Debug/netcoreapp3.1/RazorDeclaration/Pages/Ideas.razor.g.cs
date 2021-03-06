#pragma checksum "D:\Study\CSharp\Blazor\IdeaAppCore\Pages\Ideas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac36b46847ea84ccecea4ced3365d9fd1ae3fa2b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace IdeaAppCore.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Study\CSharp\Blazor\IdeaAppCore\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\CSharp\Blazor\IdeaAppCore\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\CSharp\Blazor\IdeaAppCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Study\CSharp\Blazor\IdeaAppCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Study\CSharp\Blazor\IdeaAppCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Study\CSharp\Blazor\IdeaAppCore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Study\CSharp\Blazor\IdeaAppCore\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Study\CSharp\Blazor\IdeaAppCore\_Imports.razor"
using IdeaAppCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Study\CSharp\Blazor\IdeaAppCore\_Imports.razor"
using IdeaAppCore.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Study\CSharp\Blazor\IdeaAppCore\_Imports.razor"
using IdeaAppCore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ideas")]
    public partial class Ideas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "D:\Study\CSharp\Blazor\IdeaAppCore\Pages\Ideas.razor"
       
    Idea idea = new Idea();

    private bool isShow = false;
    private List<Idea> ideas;

    protected override async Task OnInitializedAsync()
    {
        ideas = await repository.GetIdeas();
    }

    private void butnCreate_Click()
    {
        isShow = true;
    }

    private async Task btnSave_Click()
    {
        await repository.AddIdea(idea);
        isShow = false;
        ideas = await repository.GetIdeas();
        idea = new Idea();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIdeaRepository repository { get; set; }
    }
}
#pragma warning restore 1591
