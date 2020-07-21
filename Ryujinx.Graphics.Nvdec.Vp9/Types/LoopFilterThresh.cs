﻿using Ryujinx.Common.Memory;

namespace Ryujinx.Graphics.Nvdec.Vp9.Types
{
    // Need to align this structure so when it is declared and
    // passed it can be loaded into vector registers.
    internal struct LoopFilterThresh
    {
        public Array16<byte> Mblim;
        public Array16<byte> Lim;
        public Array16<byte> HevThr;
    }
}