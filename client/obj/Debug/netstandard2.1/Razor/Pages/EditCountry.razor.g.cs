#pragma checksum "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20077bc7bc9cf6cb6db8bc1c51a490cee86f2dbc"
// <auto-generated/>
#pragma warning disable 1591
namespace CaApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using CaApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\_Imports.razor"
using CaApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
using CaApp.Models.ConData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
using CaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/edit-country/{CountryID}")]
    public partial class EditCountry : CaApp.Pages.EditCountryComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.AddMarkupContent(6, "\n      ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-md-12");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CaApp.Models.ConData.Country>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CaApp.Models.ConData.Country>(
#nullable restore
#line 18 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
                                                                        country

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
                                                                                            country != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CaApp.Models.ConData.Country>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CaApp.Models.ConData.Country>(this, 
#nullable restore
#line 18 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
                                                                                                                       Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(18, "class", "row");
                    __builder3.AddMarkupContent(19, "\n              ");
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "col-md-3");
                    __builder3.AddMarkupContent(22, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(23);
                    __builder3.AddAttribute(24, "Text", "Country Name");
                    __builder3.AddAttribute(25, "Component", "CountryName");
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(27, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\n              ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-md-9");
                    __builder3.AddMarkupContent(31, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(32);
                    __builder3.AddAttribute(33, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 26 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
                                          255

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(34, "style", "display: block; width: 100%");
                    __builder3.AddAttribute(35, "Name", "CountryName");
                    __builder3.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
                                                                                                  country.CountryName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => country.CountryName = __value, country.CountryName))));
                    __builder3.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => country.CountryName));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(39, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenRequiredValidator>(40);
                    __builder3.AddAttribute(41, "Component", "CountryName");
                    __builder3.AddAttribute(42, "Text", "CountryName is required");
                    __builder3.AddAttribute(43, "style", "position: absolute");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\n            ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "row");
                    __builder3.AddMarkupContent(49, "\n              ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "col offset-sm-3");
                    __builder3.AddMarkupContent(52, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(53);
                    __builder3.AddAttribute(54, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 34 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "Icon", "save");
                    __builder3.AddAttribute(56, "Text", "Save");
                    __builder3.AddAttribute(57, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 34 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(59);
                    __builder3.AddAttribute(60, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 36 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(62, "Text", "Cancel");
                    __builder3.AddAttribute(63, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\bfadina\Dropbox\My PC (INDUKA)\Downloads\WASMTutorial\AppFiles\client\Pages\EditCountry.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n              ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(66, "\n          ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\n      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\n  ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591