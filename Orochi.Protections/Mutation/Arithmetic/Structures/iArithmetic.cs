﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orochi.Protections.Mutations.Arithmetic.Structures
{
    public abstract class iArithmetic
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract void Init();
    }
}
