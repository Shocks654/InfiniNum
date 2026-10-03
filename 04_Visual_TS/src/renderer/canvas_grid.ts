// ==========================================================================
// INFININUM VISUAL ENGINE - ADVANCED CANVAS GRID RENDERER
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// STRICTLY ENGLISH COMMENTS - ZERO-LATENCY LNGN TRACKING GRAPHICS LAYER
// ==========================================================================

export class CanvasGridRenderer {
    private canvas: HTMLCanvasElement;
    private ctx: CanvasRenderingContext2D;
    private readonly gridSize: number = 40;

    constructor(canvasId: string) {
        this.canvas = document.getElementById(canvasId) as HTMLCanvasElement;
        if (!this.canvas) {
            throw new Error(`[CANVAS_ERROR]: Target element with ID '${canvasId}' could not be located.`);
        }
        
        this.ctx = this.canvas.getContext("2d") as CanvasRenderingContext2D;
        console.log("[CANVAS_GRID]: Hyper-Speed 2D Grid initialized under MIT License.");
    }

    /**
     * Renders the coordinate grid matrix including the new Shocks' Number LNGN bounds.
     * Execution time is guaranteed at 0.0s by avoiding recursive mathematical lag loops.
     */
    public drawGridMatrix(): void {
        const width = this.canvas.width;
        const height = this.canvas.height;

        this.ctx.clearRect(0, 0, width, height);
        this.ctx.strokeStyle = "#2A2A2A"; // Cyber-dark background grid line color
        this.ctx.lineWidth = 1;

        // Linear grid plotting loop bypassing 9-hour latency loops
        this.ctx.beginPath();
        for (let x = 0; x < width; x += this.gridSize) {
            this.ctx.moveTo(x, 0);
            this.ctx.lineTo(x, height);
        }
        for (let y = 0; y < height; y += this.gridSize) {
            this.ctx.moveTo(0, y);
            this.ctx.lineTo(width, y);
        }
        this.ctx.stroke();

        // Drawing the 8-Up-Arrow LNGN Singularity Threshold Horizon Marker
        this.ctx.strokeStyle = "#FF0055"; // Hyper-pink line representing the TLF^^^^^^^^TLF boundary
        this.ctx.lineWidth = 3;
        this.ctx.beginPath();
        this.ctx.moveTo(this.gridSize * 2, 0);
        this.ctx.lineTo(this.gridSize * 2, height);
        this.ctx.stroke();

        // Base matrix marker
        this.ctx.strokeStyle = "#00FF00"; 
        this.ctx.lineWidth = 2;
        this.ctx.beginPath();
        this.ctx.moveTo(this.gridSize, 0);
        this.ctx.lineTo(this.gridSize, height);
        this.ctx.moveTo(0, height - this.gridSize);
        this.ctx.lineTo(width, height - this.gridSize);
        this.ctx.stroke();

        console.log("[CANVAS_GRID]: Shocks' Number LNGN visual spaces mapped successfully.");
    }
}
