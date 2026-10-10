# ==========================================================================
# INFININUM V2.0.0 - CMAKE BUILD SYSTEM CONFIGURATION
# LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
# STRICTLY ENGLISH CONFIGURATION - ZERO-LATENCY PLATFORM TARGET
# ==========================================================================

cmake_minimum_required(VERSION 3.10)
project(infininum_cpp_core VERSION 2.0.0 LANGUAGES C CXX ASM)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

include_directories(include)

file(GLOB_RECURSE CORE_SOURCES "src/*.c" "src/*.cpp" "src/*.asm")

add_executable(infininum_cpp main.cpp ${CORE_SOURCES})
