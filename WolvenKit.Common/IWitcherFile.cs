﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Interfaces
{
    public interface IWitcherFile
    {
        IWitcherArchiveType Bundle { get; set; }
        string Name { get; set; }
        long Size { get; set; }
        uint ZSize { get; set; }
        long Offset { get; set; }
        string CompressionType { get; }

        void Extract(Stream output);
        void Extract(string filename);
    }
}
