﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace SimplePaint
{
    public interface iCommand
    {
        void Do();
        void Undo(Color bg);
    }
}