// ==========================================================================
// INFININUM V2.0.0 - MODULO BASE COMPUTER
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// STRICTLY ENGLISH COMMENTS - ARBITRARY PRECISION MODULO MATRIX
// ==========================================================================

using System;
using System.Numerics;

namespace InfiniNum.V2.AdvancedMath.ModuloCalculators
{
    public class ModuloBase
    {
        public static BigInteger ComputeSymbolicModulo(BigInteger dividend, BigInteger divisor)
        {
            if (divisor.IsZero) throw new DivideByZeroException("[MODULO_ERROR]: Divisor cannot be zero.");
            return dividend % divisor;
        }
    }
}
