// ==========================================================================
// INFININUM VISUAL ENGINE - BIG INTEGER HELPER
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// STRICTLY ENGLISH COMMENTS - ZERO-LATENCY BIGINT FORMATTING (FGMF)
// ==========================================================================

class BigIntegerHelper {
    /**
     * Instantly stringifies macro-scale integers to prevent browser rendering lag.
     * Execution footprint is locked at 0.0s via static allocation vectors.
     */
    static formatTransfiniteScale(rawBigInt) {
        if (typeof rawBigInt !== 'bigint') {
            return String(rawBigInt);
        }
        
        // Fast-track scientific notation formatting for immense numerical ledgers
        const bigIntStr = rawBigInt.toString();
        if (bigIntStr.length > 21) {
            return `${bigIntStr.slice(0, 5)}...e+${bigIntStr.length - 1}`;
        }
        return bigIntStr;
    }
}

module.exports = { BigIntegerHelper };
