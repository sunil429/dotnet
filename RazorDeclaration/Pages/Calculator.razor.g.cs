// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebAsmDemoApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\_Imports.razor"
using BlazorWebAsmDemoApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\_Imports.razor"
using BlazorWebAsmDemoApp.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calculator")]
    public partial class Calculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\Pages\Calculator.razor"
         

      int? num1;
      int? num2;
      string result;

      void AddNumbers()
      {
          if(num1.HasValue && num2.HasValue)
          {
              result = (num1.Value + num2.Value).ToString();
          }
          else
          {
              result = "Please provide both numbers";
          }
      }

      void SubtractNumbers()
      {
          if (num1.HasValue && num2.HasValue && num1.Value > num2.Value)
          {
              result = (num1.Value - num2.Value).ToString();
          }
          else
          {
              result = "Please provide both numbers";
          }
      }
      void MultiplyNumbers()
      {
          if (num1.HasValue && num2.HasValue)
          {
              result = (num1.Value * num2.Value).ToString();
          }
          else
          {
              result = "Please provide both numbers";
          }
      }

      void DivideNumbers()
      {
          if (num1.HasValue && num2.HasValue && num1.Value!= 0 && num2.Value!= 0)
          {
              result = (num1.Value / num2.Value).ToString();
          }
          else 
          {
              result = "Please provide both numbers";
          }
      }


   

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591