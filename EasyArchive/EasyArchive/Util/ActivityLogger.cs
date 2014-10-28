﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyArchive.Util
{
    class ActivityLogger
    {
        ITextDisplay _display;
        public ActivityLogger(ITextDisplay display)
        {
            _display = display;
        }

        public  void Show (string msg)
        {
            _display.Show(msg);
        }
    }
}
