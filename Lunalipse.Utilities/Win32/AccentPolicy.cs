﻿using System.Runtime.InteropServices;

namespace Lunalipse.Utilities.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AccentPolicy
    {
        public AccentState AccentState;
        public int AccentFlags;
        public int GradientColor;
        public int AnimationId;
    }
}
