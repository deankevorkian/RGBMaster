﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Common
{
    public abstract class ProviderMetadata
    {
        public abstract string ProviderName { get; }
        public abstract string ProviderShortDescription { get; }
        public abstract string ProviderFullDescription { get; }
        public abstract Bitmap ProviderIcon { get; }
    }
}
