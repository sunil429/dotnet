#pragma checksum "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\Pages\Calculator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ac3e19ac6449f0d5ae447f63581c9e13931ba37"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Basic Calculator Demo using Blazor</h1>\r\n<hr>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<div class=\"row\"><p>First Number</p></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-4");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "placeholder", "Enter first Number");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\Pages\Calculator.razor"
                                                        num1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => num1 = __value, num1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "<div class=\"col-sm-3\"><p>Second Number</p></div>\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-sm-4");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "placeholder", "Enter Second Number");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\Pages\Calculator.razor"
                                                        num2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => num2 = __value, num2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n<br>\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.AddMarkupContent(22, "<div class=\"col-sm-3\"><p>Result</p></div>\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "clss", "col-sm-4");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "readonly");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\Pages\Calculator.razor"
                                result

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => result = __value, result));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n<br>\r\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm-2");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-warning");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\Pages\Calculator.razor"
                                                  AddNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Add (+) ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-sm-2");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-warning");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\Pages\Calculator.razor"
                                                  SubtractNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(44, "Subtract  (-)");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-sm-2");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-warning");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\Pages\Calculator.razor"
                                                  MultiplyNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Multiply  (X)");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "col-sm-2");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-warning");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\Training\dotnet\BlazorWebAsmDemoApp\BlazorWebAsmDemoApp\Client\Pages\Calculator.razor"
                                                  DivideNumbers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "Divide  (/)");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
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
