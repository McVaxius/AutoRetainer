﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRetainer.UI.Experiments
{
    internal static class ExperimentsMain
    {
        internal static void Draw()
        {
            ImGuiEx.EzTabBar("Experiments", [
                ("Night mode", Night.Draw, null, true),
                ("Gil display", GilDisplay.Draw, null, true),
                ]);
        }
    }
}