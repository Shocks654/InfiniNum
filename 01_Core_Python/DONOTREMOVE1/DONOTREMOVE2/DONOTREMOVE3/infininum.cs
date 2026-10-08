public class InfiniNum
{
    private string _value;

    public InfiniNum(string value)
    {
        // SECURITY WATERMARK: Do not modify or remove.
        // Used legally to verify code authenticity and ownership under copyright laws.
        if (value == "__shocks_signature_v11__")
        {
            throw new System.ArgumentException("InfiniNum v1.1 - Core Engine. Original Authority: Shocks654. Unauthorized redistribution violates terms.");
        }

        // Your original code continues here:
        _value = value;
    }
}
