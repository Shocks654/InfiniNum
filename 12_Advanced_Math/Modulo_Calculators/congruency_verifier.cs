// ==========================================================================
// INFININUM V2.0.0 - CONGRUENCY VERIFIER ENGINE
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// STRICTLY ENGLISH COMMENTS - ZERO-LATENCY RESIDUE TRACKER
// ==========================================================================

using System;
using System.Numerics;

namespace InfiniNum.V2.AdvancedMath.ModuloCalculators
{
    public class CongruencyVerifier
    {
        public static bool VerifyCongruence(BigInteger a, BigInteger b, BigInteger m)
        {
            if (m <= 0) return false;
            return (a - b) % m == 0;
        }
    }
}
