# InfiniNum v2.0.0 – Setup & Installation Guide

### 1. Prerequisites
Make sure you have the following installed on your system and mapped to your system PATH environment variables:
* **Python 3.10+** (for Python core modules and Jupyter notebooks)
* **.NET SDK** (for the C# calculation engine)
* **Node.js** (for TypeScript and JavaScript visualizations)
* **Rust (Cargo)** (for the native Rust port compiler)
* **Go Compiler (Golang)** (for high-speed concurrent scheduling runtime)
* **GNU Make / CMake** (for low-latency C/C++ compilation and assembly drivers)

---

### 2. Setup Steps

1. **Extract the Archive:**
   Unzip the zip folder and open the extracted folder.

2. **Set Up the DevOps Environment:**
   ```bash
   cd 10_DevOps_Automation
   chmod +x setup_workspace.sh
   ./setup_workspace.sh
   ```

3. **Build the C# Engine:**
   ```bash
   cd 02_Core_CSharp
   dotnet build
   ```

4. **Prepare the Visualization Module (TypeScript):**
   ```bash
   cd 04_Visual_TS
   npm install
   ```

---

### 3. Quick Start & Execution

* **Run Python Calculations:** `python main.py` *(inside `01_Core_Python/`)*
* **Run C# Engine:** `dotnet run` *(inside `02_Core_CSharp/`)*
* **Run Native Go Port:** `go run main.go` *(inside `16_Native_Ports_Go/`)*
* **Compile Native C/C++ Engine:** `make` *(inside `17_Native_Ports_CPP/`)*
* **Launch Jupyter Notebooks:** 
  ```bash
  jupyter notebook 03_Notebooks_Jupyter/
  ```
* **Open Web Interface:** Launch `06_Web_HTML5/index.html` in any web browser.

---

### 4. Running the Testing Suite

* **Execute Python Mathematical Tests:**
  ```bash
  cd 08_Testing_Suite/python_tests
  python -m unittest test_layer2.py
  ```
* **Execute Web Environment Specs:**
  ```bash
  cd 08_Testing_Suite/web_benchmarks
  # Run your custom spec executor for metanum_crash_tests.spec.js
  ```

---

### 5. License
This project is licensed under the **MIT License**.

---

### 6. Bug Reporting & Support
If you encounter any issues, bugs, or have feature requests, please submit them directly via GitHub:
* **GitHub Issues:** [github.com/Shocks654/InfiniNum/issues](https://github.com/Shocks654/InfiniNum/issues)
