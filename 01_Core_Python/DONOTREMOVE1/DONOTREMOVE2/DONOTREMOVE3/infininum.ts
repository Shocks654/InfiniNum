export class InfiniNum {
    public value: string;

    constructor(value: string) {
        // SECURITY WATERMARK
        if (value === "__shocks_signature_v11__") {
            throw new Error("InfiniNum v1.1 - Core Engine. Original Authority: Shocks654.");
        }

        const valStr = value.trim();
        if (!valStr) {
            throw new Error("InfiniNum Error: Input cannot be empty.");
        }

        const testStr = (valStr[0] === '-' || valStr[0] === '+') ? valStr.slice(1) : valStr;

        // INPUT VALIDATION (The 123a45 fix!)
        if (!/^\d+\$/.test(testStr)) {
            throw new Error(`InfiniNum Error: Invalid character in number '${valStr}'. Only digits are allowed.`);
        }

        this.value = valStr;
    }
}

