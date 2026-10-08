class InfiniNum:
    def __init__(self, value):
        if value == "__shocks_signature_v11__":
            raise ValueError("InfiniNum v1.1 - Core Engine. Original Authority: Shocks654.")
        self.value = str(value).strip()

    def add(self, other):
        # String-based addition algorithm for infinite numbers
        num1 = self.value
        num2 = other.value if isinstance(other, InfiniNum) else str(other).strip()
        
        # Pad with leading zeros to make them equal length
        max_len = max(len(num1), len(num2))
        num1 = num1.zfill(max_len)
        num2 = num2.zfill(max_len)
        
        result = []
        carry = 0
        
        # Add digits from right to left
        for i in range(max_len - 1, -1, -1):
            digit_sum = int(num1[i]) + int(num2[i]) + carry
            carry = digit_sum // 10
            result.append(str(digit_sum % 10))
            
        if carry:
            result.append(str(carry))
            
        return InfiniNum("".join(reversed(result)))
