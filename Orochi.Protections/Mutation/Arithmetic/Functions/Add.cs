﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Orochi.Protections.Mutations.Arithmetic.Structures;
using Orochi.Protections.Mutations.Arithmetic.Utils;

namespace Orochi.Protections.Mutations.Arithmetic.Functions
{
    public class Add : iFunction
    {
        public override ArithmeticTypes ArithmeticTypes => ArithmeticTypes.Add;
        public override ArithmeticVT Arithmetic(Instruction instruction, ModuleDef module)
        {
            Orochi.Protections.Mutations.Arithmetic.Utils.Generator generator = new Orochi.Protections.Mutations.Arithmetic.Utils.Generator();
            if (!ArithmeticUtils.CheckArithmetic(instruction)) return null;
            ArithmeticEmulator arithmeticEmulator = new ArithmeticEmulator(instruction.GetLdcI4Value(), ArithmeticUtils.GetY(instruction.GetLdcI4Value()), ArithmeticTypes);
            return (new ArithmeticVT(new Value(arithmeticEmulator.GetValue(), arithmeticEmulator.GetY()), new Token(OpCodes.Add), ArithmeticTypes));
        }
    }
}
