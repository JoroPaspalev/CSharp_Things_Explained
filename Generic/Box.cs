using System;
using System.Collections.Generic;

namespace Generic
{
    public class Box<T>
    {
        private Stack<T> box;

        public Box()
        {
            this.box = new Stack<T>();
        }

        public void Add(T item)
        {
            this.box.Push(item);
        }

        public T Remove()
        {
            if (this.box.Count == 0)
            {
                throw new ArgumentException("Box is empty!");
            }

            var item = this.box.Pop();
            return item;
        }

        public int Count => this.box.Count;
    }
}
