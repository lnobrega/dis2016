﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem3
{
    public interface INode
    {
        string Name { get; set; }

        int Size { get; }
    }
}