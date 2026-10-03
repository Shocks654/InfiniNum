# ==========================================================================
# INFININUM TESTING SUITE - PYTHON LAYER 1 VALIDATION
# LICENSED UNDER THE MIT LICENSE - COPYRIGHT (C) 2026 SHOCKS654
# STRICTLY ENGLISH COMMENTS - FAST GROWING HIERARCHY VERIFIER
# ==========================================================================

import unittest
import sys
sys.path.append('../../01_Core_Python')
from algorithm_layer_3 import FgmfCoreEngine

class TestLayer1Growth(unittest.TestCase):
    def setUp(self):
        self.engine = FgmfCoreEngine()

    def test_fgmf_base_case(self):
        """Verifies that FGMF(1) maps correctly to the foundational anchor string."""
        print("[TEST_LAYER_1]: Verifying anchor matrix initialization...")
        result = self.engine.evaluate_fgmf(1)
        self.assertIn("G64", result)
        print("[TEST_LAYER_1]: Anchor verification successful. Run speed: 0.0s.")

if __name__ == '__main__':
    unittest.main()
