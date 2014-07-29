﻿using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckBuilderPro.Entity.VsSystem
{
    public class VsSystemCardText : BaseEntity
    {
        public string RulesText { get; set; }
        public string FlavourText { get; set; }
        public VsSystemCard Card { get; set; }
    }
}
