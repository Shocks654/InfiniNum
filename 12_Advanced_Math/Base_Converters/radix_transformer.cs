// ==========================================================================
// INFININUM V2.0.0 - RADIX TRANSFORMER
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// STRICTLY ENGLISH COMMENTS - UNLIMITED ARBITRARY BASE CONVERTER
// ==========================================================================

using System;
using System.Text;
using System.Numerics;

namespace InfiniNum.V2.AdvancedMath.BaseConverters
{
    public class RadixTransformer
    {
        public static string ConvertToBase(BigInteger value, int targetBase)
        {
            if (targetBase < 2 || targetBase > 36) return "ERROR_INVALID_BASE";
            if (value.IsZero) return "0";

            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new StringBuilder();
            BigInteger current = BigInteger.Abs(value);

            while (current > 0)
            {
                int remainder = (int)(current % targetBase);
                result.Insert(0, chars[remainder]);
                current /= targetBase;
            }

            return value.Sign < 0 ? "-" + result.ToString() : result.ToString();
        }
    }
}
