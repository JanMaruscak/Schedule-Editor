#pragma checksum "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5944e1961dc64650b3100a28a8fdb84fe226f43"
// <auto-generated/>
#pragma warning disable 1591
namespace Editorlol.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\janma\source\repos\Editorlol\Editorlol\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\janma\source\repos\Editorlol\Editorlol\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\janma\source\repos\Editorlol\Editorlol\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\janma\source\repos\Editorlol\Editorlol\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\janma\source\repos\Editorlol\Editorlol\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\janma\source\repos\Editorlol\Editorlol\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\janma\source\repos\Editorlol\Editorlol\_Imports.razor"
using Editorlol;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\janma\source\repos\Editorlol\Editorlol\_Imports.razor"
using Editorlol.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
using BlazeCardsCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
using BlazeCardsCore.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
using BlazeCardsCore.Descriptors;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                  GoLeft

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Left");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                  GoRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "right");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                  AddCard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Add card");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                  AddBreak

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Add card");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.AddContent(16, 
#nullable restore
#line 10 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
  Week+1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "/\r\n");
            __builder.AddContent(18, 
#nullable restore
#line 11 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
  Weeks.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "display: flex;");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 14 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
     foreach (var item in Days)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "style", "display: flex; flex-direction: column");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "style", "width: 200px; text-align:center");
            __builder.AddContent(29, 
#nullable restore
#line 17 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                                                        item.DayOfWeek

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "style", "width: 200px; text-align:center");
            __builder.AddContent(33, 
#nullable restore
#line 18 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                                                        item.Day.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, ". ");
            __builder.AddContent(35, 
#nullable restore
#line 18 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                                                                              item.Month.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(36, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 20 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "style", "width: 100vw; height: 100vh");
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenComponent<BlazeCardsCore.Components.CanvasComponent>(43);
            __builder.AddAttribute(44, "State", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazeCardsCore.State.CardState>(
#nullable restore
#line 24 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                             cardState

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
       
    private CardState cardState;
    List<DateTime>
    Days = new List<DateTime>
        ();

    private void AddCard()
    {
        Weeks[Week][0].AddChild(new SchoolCard("VYT", "pepis", "penc", "lol"));
    }
    private void AddBreak()
    {
        Weeks[Week][0].AddChild(new BreakCard());
    }
    private void GoRight()
    {
        if (Week + 1 == Weeks.Count)
        {
            var newWeek = new List<VerticalListCard>
                ();
            for (int i = 0; i < 5; i++)
            {
                newWeek.Add(GetTemplateList(i, Width, MarginTop));
            }
            Weeks.Add(newWeek);

            foreach (var item in Weeks[Week])
            {
                this.cardState.Storage.Cards.Remove(item);
            }

            foreach (var item in newWeek)
            {
                this.cardState.Storage.Cards.Add(item);
            }
            GoneRight++;
        }
        else
        {
            foreach (var item in Weeks[Week])
            {
                this.cardState.Storage.Cards.Remove(item);
            }

            foreach (var item in Weeks[Week + 1])
            {
                this.cardState.Storage.Cards.Add(item);
            }
        }
        for (int i = 0; i < Days.Count; i++)
        {
            Days[i] = Days[i].AddDays(7);
        }
        Week++;
        this.cardState.Canvas.InvokeChange();
    }
    private void GoLeft()
    {
        if (Week == 0)
        {
            var newWeek = new List<VerticalListCard>
                ();
            for (int i = 0; i < 5; i++)
            {
                newWeek.Add(GetTemplateList(i, Width, MarginTop));
            }

            foreach (var item in Weeks[Week])
            {
                this.cardState.Storage.Cards.Remove(item);
            }

            foreach (var item in newWeek)
            {
                this.cardState.Storage.Cards.Add(item);
            }
            Weeks.Insert(0, newWeek);
            GoneLeft--;
        }
        else
        {
            foreach (var item in Weeks[Week])
            {
                this.cardState.Storage.Cards.Remove(item);
            }

            foreach (var item in Weeks[Week - 1])
            {
                this.cardState.Storage.Cards.Add(item);
            }
            Week--;
        }
        for (int i = 0; i < Days.Count; i++)
        {
            Days[i] = Days[i].AddDays(-7);
        }
        this.cardState.Canvas.InvokeChange();
    }

    int Week = 0;
    int GoneLeft = 0;
    int GoneRight = 0;

    int MarginTop = 0;
    int Height = 1000;
    int Width = 200;

    List<List<VerticalListCard>> Weeks = new List<List<VerticalListCard>>();

    protected override void OnInitialized()
    {
        this.cardState = new CardState();
        Weeks.Add(new List<VerticalListCard>());
        for (int x = 0; x < 5; x++)
        {
            Days.Add(DateTime.Now.AddDays(x));
        }

        for (int i = 0; i < 5; i++)
        {
            var schoolCard = new SchoolCard("VYT", "302", "PN", "14:30-15:45");

            var area = new DropAreaCard();
            area.PositionBehavior.Position = new BlazeCardsCore.Models.Vector2f(i * Width, MarginTop);
            area.SizeBehavior.Size = new BlazeCardsCore.Models.Vector2f(Width, Height);
            area.Clickable = false;
            area.Draggable = false;
            area.Classes.Add("school-background");
            area.Classes.Add(i.ToString());

            var list = new VerticalListCard();
            list.Clickable = false;
            list.Draggable = false;

            area.OnDrop += (o, e) =>
            {
                foreach (var item in e.Cards)
                {
                    Console.WriteLine("HEWOO");
                    Console.WriteLine(i.ToString());
                    Console.WriteLine("HEWOO2");
                    var index = int.Parse(area.Classes.Last());
                    if (Weeks[Week][index] != item.Parent)
                    {
                        item.UnhookFromParent();
                        Weeks[Week][index].AddChild(item);
                    }

                //if (item is TextCard)
                //{
                //    var downText = item as TextCard;
                //    downText.TextBehavior.Value = downText.PositionBehavior.Position.Y.ToString();
                //}
            }
            };

            list.PositionBehavior.Position = new BlazeCardsCore.Models.Vector2f(i * Width, MarginTop);

            list.AddChild(schoolCard);

            Weeks[0].Add(list);
            this.cardState.Storage.Cards.Add(area);
            this.cardState.Storage.Cards.Add(list);
        }
    }
    private VerticalListCard GetTemplateList(int index, int width, int marginTop)
    {
        VerticalListCard newList = new VerticalListCard();
        newList.Clickable = true;
        newList.Draggable = true;
        newList.PositionBehavior.Position = new BlazeCardsCore.Models.Vector2f(index * width, marginTop);
        return newList;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
