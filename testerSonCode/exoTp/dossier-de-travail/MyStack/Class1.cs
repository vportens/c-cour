namespace exo{
    public class MyStack 
    {
        private List<int> _stack_a = new List<int>();
        private List<int> _stack_b = new List<int>();


        public MyStack() {
        }

        public MyStack(int [] a, int [] b) {
            for (int i = 0; i < a.Length; i++) {
                _stack_a.Add(a[i]);
            }
            for (int j = 0; j < b.Length; j++) {
                _stack_b.Add(b[j]);
            }
        }
        public int front_a() {
            if (_stack_a.Count > 0)
                return _stack_a[0];
            return 0;
        }

        public int front_b() {
            if (_stack_b.Count > 0)
                return _stack_b[0];
            return 0;
        }


        public int back_a() {
            int i = 0;
            if (_stack_a.Count > 0) {
                return _stack_a[_stack_a.Count - 1];
            }
            return 0;
        }

        public int back_b() {
            if (_stack_b.Count > 0)
                return _stack_b[_stack_b.Count - 1];
            return 0;
        }


        public int [] showList_a() {
            return _stack_a.ToArray();
        }
        public int [] showList_b() {
            return _stack_b.ToArray();
        }

        public void sa() {
            if (_stack_a.Count > 1) {
                int tmp = _stack_a[0];
                _stack_a[0] = _stack_a[1];
                _stack_a[1] = tmp;
            }
        }

        public void sb() {
            if (_stack_b.Count > 1) {
                int tmp = _stack_b[0];
                _stack_b[0] = _stack_b[1];
                _stack_b[1] = tmp;
            }
        }

        public void pa() {
            if (_stack_a.Count > 0) {
                _stack_b.Insert(0, _stack_a[0]);
                _stack_a.RemoveAt(0);
            }
        }

        public void pb() {
            if (_stack_b.Count > 0) {
                _stack_a.Insert(0, _stack_b[0]);
                _stack_b.RemoveAt(0);
            }
        }

        public void ra() {
            if (_stack_a.Count > 1) {
                int tmp = _stack_a[0];
                _stack_a.RemoveAt(0);
                _stack_a.Add(tmp);
            }
        }

        public void rb() {
            if (_stack_b.Count > 1) {
                int tmp = _stack_b[0];
                _stack_b.RemoveAt(0);
                _stack_b.Add(tmp);
            }
        }

    }

}