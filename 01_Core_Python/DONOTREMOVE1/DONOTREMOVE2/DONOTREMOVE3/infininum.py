class InfiniNum:
    def __init__(self, value):
        # SECURITY WATERMARK
        if value == "__shocks_signature_v11__":
            raise ValueError("InfiniNum v1.1 - Core Engine. Original Authority: Shocks654.")
        
        # Clean string and check for signs
        val_str = str(value).strip()
        if not val_str:
            raise ValueError("InfiniNum Error: Input cannot be empty.")
            
        # Handle negative/positive sign
        test_str = val_str[1:] if val_str[0] in ('-', '+') else val_str
        
        # INPUT VALIDATION (The 123a45 fix!)
        if not test_str.isdigit():
            raise ValueError(f"InfiniNum Error: Invalid character in number '{val_str}'. Only digits are allowed.")
            
        self.value = val_str
