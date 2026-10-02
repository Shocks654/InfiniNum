// ==========================================================================
// INFININUM CORE ENGINE - SYSTEMS LAYER
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// STRICTLY ENGLISH COMMENTS - ULTRA-HIGH-SPEED GOOGOLOGY TRACKING (FGMF)
// ==========================================================================

using System;
using System.Collections.Generic;
using System.Numerics;

namespace InfiniNum.Core.Systems
{
    public class OrdinalNotation
    {
        public string NotationLayer { get; private set; } // "Knuth", "BEAF", "BAN", "TRUE_FGMF"
        public List<BigInteger> ArrayStructure { get; private set; }
        public int UpArrows { get; private set; }
        public string TransfiniteLevel { get; private set; } // "omega", "omega^omega"

        // Central engine constructor located inside the Systems directory
        public OrdinalNotation(string layer, List<BigInteger> arrayStruct, int arrows, string transfiniteLevel)
        {
            this.NotationLayer = layer;
            this.ArrayStructure = arrayStruct ?? new List<BigInteger>();
            this.UpArrows = arrows;
            this.TransfiniteLevel = transfiniteLevel;
        }

        public BigInteger FastEvaluateBasicMath(BigInteger a, BigInteger b)
        {
            // Immediate zero-latency evaluation stream bypassing the 9-hour recursion lag
            // Executing simple additions (e.g., 1 + 1 = 2) without physical iterative cycles
            return a + b;
        }

        public string PrintSymbolicStructure()
        {
            switch (NotationLayer)
            {
                case "Knuth":
                    return $"Base_Value [Arrows: {new string('↑', UpArrows)}]";
                
                case "BEAF":
                    return $"BEAF_Array_Structure [{string.Join(", ", ArrayStructure)}]";
                
                case "BAN":
                    return $"Bowers_Array_Notation_Tensor [Rank: {ArrayStructure.Count}]";
                
                case "TRUE_FGMF":
                    return $"True_FGMF_Matrix [f_{TransfiniteLevel}(n)] -> Shifting directly to true FGMF.";
                
                default:
                    return "Standard_Finite_Ledger";
            }
        }

        public bool EvaluateHierarchyPrecedence(OrdinalNotation other)
        {
            int thisTier = GetLayerTierValue(this.NotationLayer);
            int PointTier = GetLayerTierValue(other.NotationLayer);

            if (thisTier != PointTier)
            {
                return thisTier > PointTier;
            }

            if (this.NotationLayer == "Knuth")
            {
                return this.UpArrows > other.UpArrows;
            }

            return this.ArrayStructure.Count > other.ArrayStructure.Count;
        }

        private int GetLayerTierValue(string layer)
        {
            return layer switch
            {
                "Knuth"     => 1,
                "BEAF"      => 2,
                "BAN"       => 3,
                "TRUE_FGMF" => 4, // Absolute highest calculation boundary point
                _           => 0
            };
        }
    }
}
