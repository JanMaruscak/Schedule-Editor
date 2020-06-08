using BlazeCardsCore.Components;
using BlazeCardsCore.Descriptors;
using BlazeCardsCore.Factories;
using BlazeCardsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Editorlol.Shared
{
    public class SchoolCard : Card
    {
        public TextCard Time { get; private set; }
        public TextCard Teacher { get; private set; }
        public TextCard Classroom { get; private set; }
        public TextCard ClassName { get; private set; }
        public RectCard Background { get; private set; }

        public SchoolCard(string className, string classroom, string teacher, string time)
        {
            Background = new RectCard();
            Background.Classes.Add("school-orange");
            Classes.Add("school-text");
            Background.SizeBehavior.Size = new Vector2f(200, 100);
            Background.PositionBehavior.Position = new Vector2f(0, 0);
            AddChild(Background);

            ClassName = new TextCard();
            ClassName.PositionBehavior.Position = new Vector2f(150, 0);
            ClassName.TextBehavior.Value = className;
            AddChild(ClassName);

            Teacher = new TextCard();
            Teacher.TextBehavior.Value = teacher;
            Teacher.PositionBehavior.Position = new Vector2f(0, 60);
            AddChild(Teacher);

            Time = new TextCard();
            Time.TextBehavior.Value = time;
            Time.PositionBehavior.Position = new Vector2f(80, 30);
            AddChild(Time);

            Classroom = new TextCard();
            Classroom.TextBehavior.Value = classroom;
            Classroom.PositionBehavior.Position = new Vector2f(150, 60);
            AddChild(Classroom);

            Teacher.OnSelected += OnSelected;
            Time.OnSelected += OnSelected;
            Classroom.OnSelected += OnSelected;
            Background.OnSelected += OnSelected;
        }

        public override Vector2f GetSize() => Background.GetSize();

        public override void Snap() => base.Snap();

        public override void Update()
        {
            base.Update();
            Snap();
        }

        public override Type GetComponentType() => typeof(ListComponent);

        private void OnSelected(Card sender, Vector2f pos)
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