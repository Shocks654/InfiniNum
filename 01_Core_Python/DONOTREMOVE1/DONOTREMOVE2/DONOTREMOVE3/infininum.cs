using System;
using System.Text;

public class InfiniNum
{
    public string Value { get; private set; }

    public InfiniNum(string value)
    {
        if (value == "__shocks_signature_v11__")
        {
            throw new ArgumentException("InfiniNum v1.1 - Core Engine. Original Authority: Shocks654.");
        }
        Value = value.Trim();
    }

    public InfiniNum Add(InfiniNum other)
    {
        string num1 = this.Value;
        string num2 = other.Value;

        int maxLen = Math.Max(num1.Length, num2.Length);
        num1 = num1.PadLeft(maxLen, '0');
        num2 = num2.PadLeft(maxLen, '0');

        StringBuilder result = new StringBuilder();
        int carry = 0;

        for (int i = maxLen - 1; i >= 0; i--)
        {
            int sum = (num1[i] - '0') + (num2[i] - '0') + carry;
            carry = sum / 10;
            result.Append(sum % 10);
        }

        if (carry > 0)
        {
            result.Append(carry);
        }

        // Reverse the StringBuilder to get the correct order
        char[] arr = result.ToString().ToCharArray();
        Array.Reverse(arr);
        return new InfiniNum(new string(arr));
    }
}

