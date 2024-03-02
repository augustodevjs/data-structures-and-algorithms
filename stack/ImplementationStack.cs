namespace stack
{
    public class ImplementationStack <T>: IImplementationStack<T>
    {
        private int top = 0;
        private int size;

        private T[] stack;

        public ImplementationStack(int size = 10)
        {
            this.size = size;
            stack = new T[size];
        }

        public bool IsEmpty()
        {
            if(top == 0)
                return true;
            else 
                return false;
        }

        public void Push(T element)
        {
            if (top > size)
                throw new Exception("Stack Overflow");
            stack[top] = element;
            top++;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new Exception("Stack Underflow");
            else
            {
                top--;
                return stack[top];
            }
        }
    }
}
