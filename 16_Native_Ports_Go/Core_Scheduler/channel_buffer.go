// ==========================================================================
// INFININUM V2.0.0 - CONCURRENT CHANNEL BUFFER SHIELD
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// STRICTLY ENGLISH COMMENTS - ANTI-CRASH STACK OVERFLOW INTERCEPTOR
// ==========================================================================

package corescheduler

type ChannelBuffer struct {
	Capacity int
	IsLocked bool
}

func NewBuffer(size int) *ChannelBuffer {
	return &ChannelBuffer{
		Capacity: size,
		IsLocked: false,
	}
}
