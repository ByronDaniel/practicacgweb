#pragma checksum "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bceb3aab7a4109dd9be315455100f8dc8c3c211"
// <auto-generated/>
#pragma warning disable 1591
namespace desarrollocgweb.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\_Imports.razor"
using desarrollocgweb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\_Imports.razor"
using desarrollocgweb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\Shared\LoginDisplay.razor"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\Shared\LoginDisplay.razor"
         if (canEditProfile)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(3, "            ");
                __builder2.OpenElement(4, "a");
                __builder2.AddAttribute(5, "href", "AzureADB2C/Account/EditProfile");
                __builder2.AddContent(6, "Hello, ");
                __builder2.AddContent(7, 
#nullable restore
#line 9 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\Shared\LoginDisplay.razor"
                                                             context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(8, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n");
#nullable restore
#line 10 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\Shared\LoginDisplay.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(10, "Hello, ");
                __builder2.AddContent(11, 
#nullable restore
#line 13 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\Shared\LoginDisplay.razor"
                          context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(12, "!");
#nullable restore
#line 13 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\Shared\LoginDisplay.razor"
                                                            
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(13, "        ");
                __builder2.AddMarkupContent(14, "<a href=\"AzureADB2C/Account/SignOut\">Log out</a>\r\n    ");
            }
            ));
            __builder.AddAttribute(15, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.AddMarkupContent(17, "<a href=\"AzureADB2C/Account/SignIn\">Log in</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Daniel\source\repos\desarrollocgweb\desarrollocgweb\Shared\LoginDisplay.razor"
       
    private bool canEditProfile;

    protected override void OnInitialized()
    {
        var options = AzureADB2COptions.Get(AzureADB2CDefaults.AuthenticationScheme);
        canEditProfile = !string.IsNullOrEmpty(options.EditProfilePolicyId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOptionsMonitor<AzureADB2COptions> AzureADB2COptions { get; set; }
    }
}
#pragma warning restore 1591
