#pragma checksum "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "785b9a5e628e3ef9a52d5d049e4b09645f70f890"
// <auto-generated/>
#pragma warning disable 1591
namespace PrestamoTarea.Pages.Registros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using PrestamoTarea;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using PrestamoTarea.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
using PrestamoTarea.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
using PrestamoTarea.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Personas")]
    public partial class RPersonas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                 persona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                         Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\r\n            <h3>Registro de Persona</h3>\r\n        </div>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "form");
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-row align-items-center");
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col");
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\r\n                            ");
                __builder2.AddMarkupContent(25, "<label>Persona Id</label>\r\n                            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "input-group");
                __builder2.AddMarkupContent(28, "\r\n                                ");
                __Blazor.PrestamoTarea.Pages.Registros.RPersonas.TypeInference.CreateInputNumber_0(__builder2, 29, 30, "form-control col-4", 31, 
#nullable restore
#line 21 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                                          persona.PersonaId

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.PersonaId = __value, persona.PersonaId)), 33, () => persona.PersonaId);
                __builder2.AddMarkupContent(34, "\r\n                                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "input-group-append");
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __builder2.OpenElement(38, "button");
                __builder2.AddAttribute(39, "type", "button");
                __builder2.AddAttribute(40, "class", "btn btn-primary input-group-text");
                __builder2.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                                                                                             Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(42, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.AddMarkupContent(52, "<label>Nombres</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                            persona.Nombres

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.Nombres = __value, persona.Nombres))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.Nombres));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n                    ");
                __Blazor.PrestamoTarea.Pages.Registros.RPersonas.TypeInference.CreateValidationMessage_1(__builder2, 59, 60, 
#nullable restore
#line 34 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                              () => persona.Nombres

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(61, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n\r\n                ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.AddMarkupContent(66, "<label>Cédula</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                            persona.Cedula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.Cedula = __value, persona.Cedula))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.Cedula));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __Blazor.PrestamoTarea.Pages.Registros.RPersonas.TypeInference.CreateValidationMessage_2(__builder2, 73, 74, 
#nullable restore
#line 42 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                              () => persona.Cedula

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n\r\n                ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "\r\n                    ");
                __builder2.AddMarkupContent(80, "<label>Fecha Nacimiento</label>\r\n                    ");
                __Blazor.PrestamoTarea.Pages.Registros.RPersonas.TypeInference.CreateInputDate_3(__builder2, 81, 82, "form-control", 83, 
#nullable restore
#line 49 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                            persona.FechaNacimiento

#line default
#line hidden
#nullable disable
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.FechaNacimiento = __value, persona.FechaNacimiento)), 85, () => persona.FechaNacimiento);
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __Blazor.PrestamoTarea.Pages.Registros.RPersonas.TypeInference.CreateValidationMessage_4(__builder2, 87, 88, 
#nullable restore
#line 50 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                              () => persona.FechaNacimiento

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n\r\n                ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group");
                __builder2.AddMarkupContent(93, "\r\n                    ");
                __builder2.AddMarkupContent(94, "<label>Balance</label>\r\n                    ");
                __Blazor.PrestamoTarea.Pages.Registros.RPersonas.TypeInference.CreateInputNumber_5(__builder2, 95, 96, "form-control", 97, "true", 98, 
#nullable restore
#line 56 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                              persona.Balance

#line default
#line hidden
#nullable disable
                , 99, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.Balance = __value, persona.Balance)), 100, () => persona.Balance);
                __builder2.AddMarkupContent(101, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "card-footer");
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "form-group text-center");
                __builder2.AddAttribute(110, "display:", true);
                __builder2.AddAttribute(111, "inline-block", true);
                __builder2.AddMarkupContent(112, "\r\n                ");
                __builder2.OpenElement(113, "button");
                __builder2.AddAttribute(114, "type", "button");
                __builder2.AddAttribute(115, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                                                               Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(117, "Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                ");
                __builder2.AddMarkupContent(119, "<button type=\"submit\" class=\"btn btn-lg btn-success\">Guardar</button>\r\n                ");
                __builder2.OpenElement(120, "button");
                __builder2.AddAttribute(121, "type", "button");
                __builder2.AddAttribute(122, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
                                                                              Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(124, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\AnthonyB\source\repos\TareaPrestamo\PrestamoTarea\Pages\Registros\RPersonas.razor"
 
    private Personas persona = new Personas();

    private void Nuevo()
    {
        persona = new Personas();
    }

    private void Buscar()
    {
        if (persona.PersonaId > 0)
        {
            var Persona = PersonasBLL.Buscar(persona.PersonaId);

            if (Persona != null)
                this.persona = Persona;
            else
                Toast.ShowError("Persona no encontrada");
        }
    }

    private void Guardar()
    {
        bool Guardado;

        Guardado = PersonasBLL.Guardar(persona);

        if (Guardado)
        {
            Nuevo();
            Toast.ShowSuccess("Guardado correctamente");
        }
        else
            Toast.ShowError("No fue posible guardar");
    }

    private void Eliminar()
    {
        bool Eliminado;

        Eliminado = PersonasBLL.Eliminar(persona.PersonaId);

        if (Eliminado)
        {
            Nuevo();
            Toast.ShowSuccess("Eliminado correctamente");
        }
        else
            Toast.ShowError("No fue posible eliminar");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService Toast { get; set; }
    }
}
namespace __Blazor.PrestamoTarea.Pages.Registros.RPersonas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "readOnly", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
