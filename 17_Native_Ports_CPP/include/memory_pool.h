// ==========================================================================
// INFININUM V2.0.0 - C REGISTER VIRTUAL MEMORY POOL
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// ==========================================================================

#ifndef MEMORY_POOL_H
#define MEMORY_POOL_H

#include <stddef.h>

void* allocate_isolated_register_slot(size_t layout_size);

#endif
