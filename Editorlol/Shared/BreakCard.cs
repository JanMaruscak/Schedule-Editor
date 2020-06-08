using BlazeCardsCore.Behaviors;
using BlazeCardsCore.Components;
using BlazeCardsCore.Descriptors;
using BlazeCardsCore.Factories;
using BlazeCardsCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Editorlol.Shared
{
    public class BreakCard : Card
    {
        public bool Fixed { get; set; }
        public int Spacing { get; set; }
        public TextBlockCard Text = new TextBlockCard();
        public RectCard Background = new RectCard();

        public BreakCard(bool @fixed = false, int spacing = 0)
        {
            this.Fixed = @fixed;
            this.Spacing = spacing;
            Text.OnSelected += OnSelected;
            Background.OnSelected += OnSelected;
            Text.OnUp += Text_OnDown;
            AddChild(Background);
            AddChild(Text);
            Text.TextBehavior.Value = "50";
            Background.SizeBehavior.Size = new Vector2f(Background.SizeBehavior.Size.X, 50);
        }

        private void Text_OnDown(Card sender, Vector2f pos)
        {
        }

        public override Vector2f GetSize()
        {
            //var size = Vector2f.Zero;

            //foreach (var child in this.Children)
            //{
            //    var childSize = child.GetSize();
            //    size.Y += childSize.Y + this.Spacing;

            //    if (childSize.X > size.X)
            //        size.X = childSize.X;
            //}

            //if (this.Children.Count > 0)
            //    size.Y -= this.Spacing;

            //return size;
            return Background.GetSize();
        }

        public override void Snap()
        {
            base.Snap();

            //Console.WriteLine($"List snapping {this.Children.Count} children...");

            //if (!this.Fixed) this.Children = this.Children.OrderBy(card => card.GetPosition().Y).ToList();
            if (int.TryParse(Text.TextBehavior.Value, out int result))
            {
                Background.SizeBehavior.Size = new Vector2f(Text.GetSize().X, result);
                Background.PositionBehavior.Position = new Vector2f(0, 0);
                var x = (Background.SizeBehavior.Size.Y - Text.GetSize().Y) / 2;
                Text.PositionBehavior.Position = new Vector2f(0, x);
            }
            var offset = 0f;
            //foreach (var child in this.Children)
            //{
            //    child.PositionBehavior.Position = new Vector2f(this.PositionBehavior.Position.X + child.PositionBehavior.Position.X, this.PositionBehavior.Position.Y + child.PositionBehavior.Position.Y);

            //    //offset += child.GetSize().Y + this.Spacing;

            //}
        }

        public override void Update()
        {
            base.Update();
            this.Snap();
        }

        public override Type GetComponentType() => typeof(ListComponent);

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