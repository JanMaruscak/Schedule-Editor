#pragma checksum "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eae38e11704cb3cbff1f699f1fe9cf4057deed3"
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
            __builder.AddAttribute(2, "style", "outline:none; border: none; padding:5px");
            __builder.AddContent(3, "Left");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                  GoRight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "style", "outline:none; border: none; padding:5px");
            __builder.AddContent(8, "right");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                  AddCard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "style", "outline:none; border: none; padding:5px");
            __builder.AddContent(13, "Add Card");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                  AddBreak

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "style", "outline:none; border: none; padding:5px");
            __builder.AddContent(18, "Add Break");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                  DeleteCard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "style", "outline:none; border: none; padding:5px");
            __builder.AddContent(23, "Delete card");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "select");
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                   SelectClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "T2");
            __builder.AddContent(30, "T2");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "T1");
            __builder.AddContent(34, "T1");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.AddContent(37, 
#nullable restore
#line 15 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
  Week+1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "/\r\n");
            __builder.AddContent(39, 
#nullable restore
#line 16 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
  Weeks.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "\r\n\r\n");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "style", "display: flex;");
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 19 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
     foreach (var item in Days)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "style", "display: flex; flex-direction: column");
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "p");
            __builder.AddAttribute(49, "style", "width: 200px; text-align:center; color: black");
            __builder.AddContent(50, 
#nullable restore
#line 22 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                                                                      item.DayOfWeek

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "p");
            __builder.AddAttribute(53, "style", "width: 200px; text-align:center; color: black");
            __builder.AddContent(54, 
#nullable restore
#line 23 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                                                                      item.Day.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, ". ");
            __builder.AddContent(56, 
#nullable restore
#line 23 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                                                                                            item.Month.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(57, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 25 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "style", "width: 100vw; height: 100vh");
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenComponent<BlazeCardsCore.Components.CanvasComponent>(64);
            __builder.AddAttribute(65, "State", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazeCardsCore.State.CardState>(
#nullable restore
#line 29 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
                             cardState

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\janma\source\repos\Editorlol\Editorlol\Pages\Index.razor"
       
    private CardState cardState;
    List<DateTime> Days = new List<DateTime>
    ();

    int Week = 0;
    int GoneLeft = 0;
    int GoneRight = 0;

    int MarginTop = 0;
    int Height = 1000;
    int Width = 200;

    string CurClass = "T2";
    Dictionary<string, List<List<VerticalListCard>>> Classes = new Dictionary<string, List<List<VerticalListCard>>>();
    Dictionary<string, ClassInfo> ClassInfos = new Dictionary<string, ClassInfo>();

    List<List<VerticalListCard>> Weeks = new List<List<VerticalListCard>>();

    private void DeleteCard()
    {
        //if (this.cardState.Selected is SchoolCard)
        {
            foreach (var item in this.cardState.Selected)
            {
                item.UnhookFromParent();
            }
        }
    }

    void SelectClass(ChangeEventArgs e)
    {
        foreach (var item in Weeks[Week])
        {
            this.cardState.Storage.Cards.Remove(item);
        }

        //Classes[CurClass] = new List<List<VerticalListCard>>();
        //foreach (var item in Weeks)
        //{
        //    Classes[CurClass].Add(item);
        //}

        //Weeks = new List<List<VerticalListCard>>();
        //foreach (var item in Classes[e.Value.ToString()])
        //{
        //    Weeks.Add(item);
        //}

        foreach (var item in Classes[e.Value.ToString()][ClassInfos[e.Value.ToString()].Week])
        {
            this.cardState.Storage.Cards.Add(item);
        }
        Classes[CurClass] = Weeks.ToList();
        Weeks = Classes[e.Value.ToString()].ToList();

        ClassInfos[CurClass].Week = Week;
        ClassInfos[CurClass].GoneLeft = GoneLeft;
        ClassInfos[CurClass].GoneRight = GoneRight;
        ClassInfos[CurClass].Days = Days.ToList();

        Week = ClassInfos[e.Value.ToString()].Week;
        GoneLeft = ClassInfos[e.Value.ToString()].GoneLeft;
        GoneRight = ClassInfos[e.Value.ToString()].GoneRight;
        Days = ClassInfos[e.Value.ToString()].Days.ToList();

        CurClass = e.Value.ToString();

        this.cardState.Canvas.InvokeChange();
    }
    private void AddCard()
    {
        Weeks[Week][0].AddChild(new SchoolCard("VYT", "302", "PN", "14:30-15:45"));
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

    protected override void OnInitialized()
    {
        for (int x = 0; x < 5; x++)
        {
            Days.Add(DateTime.Now.AddDays(x));
        }
        Classes.Add("T2", Weeks);
        Classes.Add("T1", new List<List<VerticalListCard>>());

        ClassInfos.Add("T2", new ClassInfo(0, 0, 0, Days));
        ClassInfos.Add("T1", new ClassInfo(0, 0, 0, Days));

        Console.WriteLine("oenis");
        Classes["T1"].Add(new List<VerticalListCard>());
        for (int i = 0; i < 5; i++)
        {
            Classes["T1"][0].Add(GetTemplateList(i, Width, MarginTop));
        }
        this.cardState = new CardState();
        Weeks.Add(new List<VerticalListCard>());

        for (int i = 0; i < 5; i++)
        {
            var area = new DropAreaCard();
            area.PositionBehavior.Position = new BlazeCardsCore.Models.Vector2f(i * Width, MarginTop);
            area.SizeBehavior.Size = new BlazeCardsCore.Models.Vector2f(Width, Height);
            area.Clickable = false;
            area.Draggable = false;
            area.Classes.Add("school-background");
            area.Classes.Add(i.ToString());
            area.OnDrop += (o, e) =>
            {
                var index = int.Parse(area.Classes.Last());
                foreach (var item in e.Cards)
                {
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

                foreach (var item in Weeks[Week][index].Children)
                {
                    if (item is SchoolCard)
                    {
                        var sch = item as SchoolCard;
                        sch.Time.TextBehavior.Value = item.PositionBehavior.Position.Y.ToString();
                    }
                }
                foreach (var item in e.Cards[0].Parent.Children)
                {
                    if (item is SchoolCard)
                    {
                        var sch = item as SchoolCard;
                        sch.Time.TextBehavior.Value = item.PositionBehavior.Position.Y.ToString();
                    }
                }
            };
            this.cardState.Storage.Cards.Add(area);
        }
        for (int i = 0; i < 5; i++)
        {
            var schoolCard = new SchoolCard("VYT", "302", "PN", "14:30-15:45");

            var list = new VerticalListCard();
            list.Clickable = false;
            list.Draggable = false;

            list.PositionBehavior.Position = new BlazeCardsCore.Models.Vector2f(i * Width, MarginTop);

            list.AddChild(schoolCard);

            Weeks[0].Add(list);
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
