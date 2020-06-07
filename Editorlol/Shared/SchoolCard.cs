﻿using BlazeCardsCore.Descriptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Editorlol.Shared
{
    public class SchoolCard : VerticalListCard
    {
        public TextCard Time { get; private set; }
        public TextCard Teacher { get; private set; }

        public SchoolCard() : base()
        {
            this.Fixed = false;

            this.Teacher = new TextBlockCard();
            this.Teacher.Draggable = false;
            this.AddChild(Teacher);

            this.Time = new TextBlockCard();
            this.Time.Draggable = false;
            this.AddChild(Time);
        }
    }
}