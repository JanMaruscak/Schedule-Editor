using BlazeCardsCore.Descriptors;
using BlazeCardsCore.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Editorlol.Shared
{
    public class SchoolCard : VerticalListCard
    {
        public TextCard Time { get; private set; }
        public TextCard Teacher { get; private set; }

        public SchoolCard() : base()
        {
            this.Fixed = true;

            this.Teacher = new TextBlockCard();
            //this.Teacher.Draggable = false;
            //this.Teacher.Clickable = false;
            this.AddChild(Teacher);

            this.Teacher.OnSelected += OnSelected;

            this.Time = new TextBlockCard();
            //this.Time.Draggable = false;
            //this.Time.Clickable = false;
            this.AddChild(Time);

            this.Teacher.OnSelected += OnSelected;
            this.Time.OnSelected += OnSelected;
        }

        private void OnSelected(Card sender, BlazeCardsCore.Models.Vector2f pos)
        {
            Console.WriteLine("-> MOUSE DOWN!!!");

            var state = this.Component.Canvas.State;

            foreach (var card in state.Selected)
                card.Deselect();


            state.Selected.Clear();
            state.Selected.Add(this);

            state.Highlighter = null;
            state.Canvas.InvokeChange();

            state.Highlighter = RectFactory.CreateHighlighter(state.Selected);
            state.InteropQueue.Flush(state.Canvas.JSRuntime);
        }
    }
}