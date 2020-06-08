using BlazeCardsCore.Descriptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Editorlol.Shared
{
    public class BreakCard : RectCard
    {
        private TextCard Text = new TextCard();

        public BreakCard() : base()
        {
            this.AddChild(Text);
        }
    }
}