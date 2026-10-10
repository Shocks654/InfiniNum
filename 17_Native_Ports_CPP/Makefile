# ==========================================================================
# INFININUM V2.0.0 - NATIVE GNU MAKEFILE
# LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
# ==========================================================================

CXX = g++
CC = gcc
ASM = nasm

CXXFLAGS = -std=c++17 -O3 -Iinclude
CFLAGS = -O3 -Iinclude
ASMFLAGS = -f elf64

TARGET = infininum_cpp
OBJ = main.o src/infini_num.o src/transfinite_solver.o src/assembly_optimizations.o

all: $(TARGET)

$(TARGET): $(OBJ)
	$(CXX) $(CXXFLAGS) -o $(TARGET) $(OBJ)

%.o: %.cpp
	$(CXX) $(CXXFLAGS) -c $< -o $@

%.o: %.c
	$(CC) $(CFLAGS) -c $< -o $@

%.o: %.asm
	$(ASM) $(ASMFLAGS) $< -o $@

clean:
	rm -f $(OBJ) $(TARGET)
