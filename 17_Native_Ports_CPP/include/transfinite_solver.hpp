// ==========================================================================
// INFININUM V2.0.0 - C++ ENHANCED TRANSFINITE SOLVER HEADER
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// ==========================================================================

#ifndef TRANSFINITE_SOLVER_HPP
#define TRANSFINITE_SOLVER_HPP

#include <string>

namespace InfiniNum {
    class TransfiniteSolver {
    public:
        TransfiniteSolver();
        std::string collapseBracketSequence(const std::string& expression);
    };
}

#endif
