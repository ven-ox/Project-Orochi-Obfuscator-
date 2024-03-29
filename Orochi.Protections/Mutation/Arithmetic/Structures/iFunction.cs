﻿using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orochi.Protections.Mutations.Arithmetic.Structures
{
    public abstract class iFunction
    {
        public abstract ArithmeticTypes ArithmeticTypes { get; }
        public abstract ArithmeticVT Arithmetic(Instruction instruction, ModuleDef module); 
    }
}
