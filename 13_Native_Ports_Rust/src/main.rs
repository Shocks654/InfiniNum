// ==========================================================================
// INFININUM V2.0.0 - NATIVE RUST RUNTIME CORE
// LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
// STRICTLY ENGLISH COMMENTS - TERMINAL AUTO-PRINT PROTOCOL ACTIVE
// ==========================================================================

use std::fs::File;
use std::io::{self, Read};
use std::path::Path;

fn main() {
    println!("==================================================");
    println!("   INFININUM NATIVE ACCELERATOR - RUST ENGINE v2.0.0");
    println!("   MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654");
    println!("==================================================\n");

    // Automatically printing your custom download text directly into the console on boot
    let readme_path = Path::new("../IMPORTANT_READ_ME_FIRST.txt");
    if readme_path.exists() {
        if let Ok(mut file) = File::open(readme_path) {
            let mut contents = String::new();
            if file.read_to_string(&mut contents).is_ok() {
                println!("{}", contents);
                println!("==================================================\n");
            }
        }
    } else {
        println!("InfiniNum v2.0.0 - Pocket-Edition coming soon!\n");
    }

    println!("[NATIVE_RUST]: Core system initialized at 0.0s framework speed.");
}
