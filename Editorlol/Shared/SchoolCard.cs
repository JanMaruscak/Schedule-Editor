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
        public TextCard Classroom { get; private set; }
        public RectCard Background { get; private set; }

        public SchoolCard(string classroom, string teacher, string time) : base()
        {
            Background = new RectCard();
            Background.Draggable = false;
            Background.Clickable = false;
            Background.Classes.Add("school-orange");
            this.Classes.Add("school-background");
            Background.SizeBehavior.Size = new BlazeCardsCore.Models.Vector2f(200, 100);
            //AddChild(Background);
            this.Fixed = true;

            this.Teacher = new TextCard();
            Teacher.TextBehavior.Value = teacher;
            Teacher.PositionBehavior.Position = new BlazeCardsCore.Models.Vector2f(0, 0);
            //this.Teacher.Draggable = false;
            //this.Teacher.Clickable = false;
            this.AddChild(Teacher);

            this.Teacher.OnSelected += OnSelected;

            Time = new TextCard();
            Time.TextBehavior.Value = time;
            //this.Time.Draggable = false;
            //this.Time.Clickable = false;
            AddChild(Time);

            Classroom = new TextCard();
            Classroom.TextBehavior.Value = classroom;
            AddChild(Classroom);

            Teacher.OnSelected += OnSelected;
            Time.OnSelected += OnSelected;
            Classroom.OnSelected += OnSelected;
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