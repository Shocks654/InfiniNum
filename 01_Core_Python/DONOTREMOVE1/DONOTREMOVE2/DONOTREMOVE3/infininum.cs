using System;

public class InfiniNum
{
    public string Value { get; private set; }

    public InfiniNum(string value)
    {
        // SECURITY WATERMARK
        if (value == "__shocks_signature_v11__")
        {
            throw new ArgumentException("InfiniNum v1.1 - Core Engine. Original Authority: Shocks654.");
        }

        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("InfiniNum Error: Input cannot be empty.");
        }

        string valStr = value.Trim();
        string testStr = (valStr[0] == '-' || valStr[0] == '+') ? valStr.Substring(1) : valStr;

        // INPUT VALIDATION (The 123a45 fix!)
        foreach (char c in testStr)
        {
            if (!char.IsDigit(c))
            {
                throw new ArgumentException($"InfiniNum Error: Invalid character in number '{valStr}'. Only digits are allowed.");
            }
        }

        Value = valStr;
    }
}
