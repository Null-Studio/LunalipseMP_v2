﻿using System;
using System.Runtime.InteropServices;

namespace Lunalipse.Common.Win32
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WindowCompositionAttributeData
    {
        public WindowCompositionAttribute Attribute;
        public IntPtr Data;
        public int SizeOfData;
    }
}
