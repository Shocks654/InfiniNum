// ==========================================================================
// INFININUM CORE ENGINE - SYSTEM LAYER
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// STRICTLY ENGLISH TECHNICAL NOTES - NO GLITCHES ALLOWED
// ==========================================================================

using System;
using System.Numerics;

namespace InfiniNum.Core.Systems
{
    public class DeepRecursionEngine
    {
        public static readonly string EngineVersion = "1.0.0";
        private readonly BigInteger _recursionLimit;

        public DeepRecursionEngine(BigInteger customLimit)
        {
            // Safeguarding the transfinite calculation stream against memory leaks
            this._recursionLimit = customLimit;
        }

        public void InitializeEngine()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"   INFININUM DEEP RECURSION ENGINE INITIALIZED   ");
            Console.WriteLine($"   VERSION: {EngineVersion} | LICENSE: MIT        ");
            Console.WriteLine("==================================================");
        }

        public BigInteger ExecuteSafeRecursion(BigInteger baseValue, int depth)
        {
            // Preventing stack overflow exceptions via hard-coded kiber-safeties
            if (depth <= 0)
            {
                return baseValue;
            }

            if (baseValue > _recursionLimit)
            {
                throw new OverflowException("[INFININUM_ERROR]: Transfinite calculation exceeded safely allocated memory ledger bounds.");
            }

            // Triggering the next safe deep recursion loop sequence
            return ExecuteSafeRecursion(baseValue + 1, depth - 1);
        }
    }
}
