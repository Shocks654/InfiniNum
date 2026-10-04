# InfiniNum v1.0.0 – Setup & Installation Guide

### 1. Prerequisites
Make sure you have the following installed on your system:
* **Python 3.10+** (for Python core modules and Jupyter notebooks)
* **.NET SDK** (for the C# calculation engine)
* **Node.js** (for TypeScript and JavaScript visualizations)

---

### 2. Setup Steps

1. **Extract the Archive:**
   Unzip the zip folder and open the extracted folder.

2. **Set Up the Python Module:**
   ```bash
   cd 01_Core_Python
   pip install -r requirements.txt
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

### 3. Quick Start

* **Run Python Calculations:** `python main.py` *(inside `01_Core_Python/`)*
* **Run C# Engine:** `dotnet run` *(inside `02_Core_CSharp/`)*
* **Launch Jupyter Notebooks:** 
  ```bash
  jupyter notebook 03_Notebooks_Jupyter/
  ```
* **Open Web Interface:** Launch `06_Web_HTML5/index.html` in any browser.

---

### 4. License
This project is licensed under the **MIT License**.

---

### 5. Bug Reporting & Support
If you encounter any issues, bugs, or have feature requests, please submit them directly via GitHub:
* **GitHub Issues:** [github.com/Shocks654/InfiniNum/issues](https://github.com/Shocks654/InfiniNum/issues)