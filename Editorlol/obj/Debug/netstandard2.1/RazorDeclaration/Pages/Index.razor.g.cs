#pragma checksum "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55992347586433b859bcf5cbf6ec1cb067868318"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
       
    private CardState cardState;
    List<DateTime> Days = new List<DateTime>();

    private void AddCard()
    {
        this.cardState.Storage.Cards.Add(new SchoolCard("pepis", "penc", "lol"));
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
        for (int i = 0; i < 5; i++)
        {
            Days.Add(DateTime.Now.AddDays(i));
        }

        for (int i = 0; i < 5; i++)
        {
            var schoolCard = new SchoolCard("VYT", "Penc", "14:30-15:45");
            schoolCard.Time.TextBehavior.Value = "VYT";

            var area = new DropAreaCard();
            area.PositionBehavior.Position = new BlazeCardsCore.Models.Vector2f(i * Width, MarginTop);
            area.SizeBehavior.Size = new BlazeCardsCore.Models.Vector2f(Width, Height);
            area.Clickable = false;
            area.Draggable = false;
            area.Visible = false;
            area.Classes.Add("school-background");
            var list = new VerticalListCard();
            list.Clickable = false;
            list.Draggable = false;

            area.OnDrop += (o, e) =>
            {
                foreach (var item in e.Cards)
                {
                    if (item.Parent == null)
                    {
                        this.cardState.Storage.Cards.Remove(item);
                        list.AddChild(item);
                    }
                    else if (list != item.Parent)
                    {
                        item.Parent.UnhookChild(item);
                        list.AddChild(item);
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
        this.cardState.Storage.Cards.Add(new BreakCard());
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
