using System;


namespace Stack_class
{
    public class MyStack
    {
        private List<int> _stack_a = new List<int>();
        private List<int> _stack_b = new List<int>();

        // constructor par default
        public MyStack() {}
        

        public MyStack(int[] a, int[] b) { // constructor pour 
        // initialiser les deux stacks pour mes tests
            for (int i = 0 ; i < a.Length ; i++) {
                _stack_a.Add(a[i]);
            }
            for (int j = 0; j < b.Length; j++) {
                _stack_b.Add(b[j]);
            }
        }

        // TODO Front a et b
        public int front_a() {
            return 0;
        }

        public int front_b() {
            return 0;
        }

    }
}
