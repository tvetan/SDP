using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Node<TKey, TValue>
    {
        private TKey key;

        private TValue value;

        public Node(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        public TValue Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public TKey Key
        {
            get
            {
                return this.key;
            }
            set
            {
                this.key = value;
            }
        }
    }
}
