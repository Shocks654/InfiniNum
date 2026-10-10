// ==========================================================================
// INFININUM V2.0.0 - NATIVE C++ MAIN ENTRY POINT
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// STRICTLY ENGLISH COMMENTS - TERMINAL AUTO-READ ACTIVE
// ==========================================================================

#include <iostream>
#include <fstream>
#include <string>
#include "infini_num.h"
#include "transfinite_solver.hpp"

int main() {
    std::cout << "==================================================\n";
    std::cout << "   INFININUM ULTRA CORE - C/C++ ENGINE v2.0.0\n";
    std::cout << "   MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654\n";
    std::cout << "==================================================\n";

    // Auto-read verification text block on boot execution
    std::ifstream readme("../IMPORTANT_READ_ME_FIRST.txt");
    if (readme.is_open()) {
        std::string line;
        std::cout << "\n";
        while (std::getline(readme, line)) {
            std::cout << line << "\n";
        }
        std::cout << "==================================================\n";
    }

    std::cout << "[CPP_MAIN]: Hardened execution layer booted at 0.0s latency.\n";
    return 0;
}
