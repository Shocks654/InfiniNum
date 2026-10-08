from pathlib import Path
import sys

# Ensure the project root and core logic directory are on the import path.
PROJECT_ROOT = Path(__file__).resolve().parent
CORE_DIR = PROJECT_ROOT / '01_Core_Python'
for path in (str(PROJECT_ROOT), str(CORE_DIR)):
    if path not in sys.path:
        sys.path.insert(0, path)

# Flask dependencies must be installed in the active Python environment.
try:
    from flask import Flask, request, jsonify  # type: ignore[import-not-found]
    from flask_cors import CORS  # type: ignore[import-not-found]
except ImportError as exc:
    raise RuntimeError(
        'Missing Python dependencies. Install with: pip install flask flask-cors'
    ) from exc

# Import the production logic layers from the project folder.
# Use an explicit loader so both runtime imports and static analysis don't fail
# when the project layout is not a package or the folder is not on Pylance's
# import resolution path.
import importlib.util

PROJECT_ROOT = Path(__file__).resolve().parent
CORE_DIR = PROJECT_ROOT / '01_Core_Python'


def load_project_module(module_name: str):
    """Load a module from either the project root or the core logic directory."""
    search_roots = [PROJECT_ROOT, CORE_DIR]
    for root in search_roots:
        module_path = root / f'{module_name}.py'
        if module_path.exists():
            spec = importlib.util.spec_from_file_location(module_name, module_path)
            if spec is None or spec.loader is None:
                raise ImportError(f'Unable to create spec for module: {module_name}')
            module = importlib.util.module_from_spec(spec)
            sys.modules[module_name] = module
            spec.loader.exec_module(module)
            return module

    # Fallback to a normal import in case the module is discoverable via sys.path.
    return __import__(module_name)


algorithm_layer1 = load_project_module('algorithm_layer1')
algorithm_layer2 = load_project_module('algorithm_layer2')
algorithm_layer3 = load_project_module('algorithm_layer3')
transfinite_singularity = load_project_module('transfinite_singularity')

app = Flask(__name__)
CORS(app) # Allows index.html to communicate with the Python script safely

@app.route('/calculate', methods=['POST'])
def calculate():
    try:
        data = request.json
        raw_num1 = str(data.get('num1', '0'))
        raw_num2 = str(data.get('num2', '0'))
        op = data.get('operation', 'add')

        # 1. Pipeline through Layer 1 and 2
        parsed_1 = algorithm_layer2.unpack(algorithm_layer1.parse(raw_num1))
        parsed_2 = algorithm_layer2.unpack(algorithm_layer1.parse(raw_num2))

        # 2. Execute calculation via Layer 3 functions
        if op == 'add':
            math_result = algorithm_layer3.add(parsed_1, parsed_2)
        elif op == 'subtract':
            math_result = algorithm_layer3.subtract(parsed_1, parsed_2)
        elif op == 'multiply':
            math_result = algorithm_layer3.multiply(parsed_1, parsed_2)
        elif op == 'divide':
            math_result = algorithm_layer3.divide(parsed_1, parsed_2)
        else:
            return jsonify({'error': 'Invalid operation selection'}), 400

        # 3. Format calculation vector through your transfinite_singularity processor
        output_notation = transfinite_singularity.format_output(math_result)
        raw_number_string = str(math_result)

        return jsonify({
            'standard_number': raw_number_string,
            'transfinite_output': output_notation
        })

    except Exception as e:
        return jsonify({'error': str(e)}), 500

if __name__ == '__main__':
    print("🚀 InfiniNum Core API Listener Active at http://127.0.0.1:5000")
    app.run(port=5000, debug=True)
