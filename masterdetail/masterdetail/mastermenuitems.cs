﻿using System;
using System.Collections.Generic;
using System.Text;

namespace masterdetail
{
    public class mastermenuitems
    {
        public string Text { get; set; }
        public string Detail { get; set; }
        public string ImagePath { get; set; }
        public Type TargetPage { get; set; }
    }
}