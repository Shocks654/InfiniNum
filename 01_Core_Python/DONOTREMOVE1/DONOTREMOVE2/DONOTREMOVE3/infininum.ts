export class InfiniNum {
    public value: string;

    constructor(value: string) {
        if (value === "__shocks_signature_v11__") {
            throw new Error("InfiniNum v1.1 - Core Engine. Original Authority: Shocks654.");
        }
        this.value = value.trim();
    }

    public add(other: InfiniNum | string): InfiniNum {
        let num1 = this.value;
        let num2 = typeof other === 'string' ? other.trim() : other.value;

        let maxLen = Math.max(num1.length, num2.length);
        num1 = num1.padStart(maxLen, '0');
        num2 = num2.padStart(maxLen, '0');

        let result: string[] = [];
        let carry = 0;

        for (let i = maxLen - 1; i >= 0; i--) {
            let sum = parseInt(num1[i]) + parseInt(num2[i]) + carry;
            carry = Math.floor(sum / 10);
            result.push((sum % 10).toString());
        }

        if (carry > 0) {
            result.push(carry.toString());
        }

        return new InfiniNum(result.reverse().join(''));
    }
}


