using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTable<TKey, TValue>
    {
        private List<KeyValuePair<TKey,TValue>>[] hashTableArray;

        private readonly double fillFactor = 0.75d;

        private int count;

        private int capacity;

        private int maksPossibleElements;

        public HashTable()
            :this(4)
        {
            
        }

        public HashTable(int capacity)
        {
            this.count = 0;
            hashTableArray = new List<KeyValuePair<TKey, TValue>>[capacity];
            this.capacity = capacity;

            unchecked
            {
                this.maksPossibleElements = (int)(capacity * this.fillFactor);
            }
        }

        public int MaksPossibleElements
        {
            get
            {
                return this.maksPossibleElements;
            }
            set
            {
                this.maksPossibleElements = value;
            }
        }

        public List<KeyValuePair<TKey, TValue>> FindChain(TKey key)
        {
            int chainIndex = key.GetHashCode() % capacity;

            if (this.hashTableArray[chainIndex] == null)
            {
                this.hashTableArray[chainIndex] = new List<KeyValuePair<TKey, TValue>>();
            }

            return this.hashTableArray[chainIndex];
        }

        public void Set(TKey key, TValue value)
        {
            var chain = this.FindChain(key);

            chain.Add(new KeyValuePair<TKey, TValue>(key, value));
            this.count++;

            if (this.count >= this.maksPossibleElements)
            {
                this.Expand();
            }
        }
  
        private void Expand()
        {
            this.capacity = 2 * this.capacity;
            var old = this.hashTableArray;
            this.count = 0;
            unchecked
            {
                this.maksPossibleElements = (int)(capacity * this.fillFactor);
            }

            this.hashTableArray = new List<KeyValuePair<TKey, TValue>>[this.capacity];
            foreach (var chain in old)
            {
                if (chain != null)
                {
                    foreach (var keyValuePair in chain)
                    {
                        this.Set(keyValuePair.Key, keyValuePair.Value);
                    } 
                }
                
            }
        }

        public TValue Get(TKey key)
        {
            var chain = this.FindChain(key);
            
            if (chain != null)
            {
                foreach (var item in chain)
                {
                    if (key.Equals(item.Key))
                    {
                        return item.Value;
                    }
                }
            }

            return default(TValue);
        }

        public List<KeyValuePair<TKey, TValue>>[] HashTableArray
        {
            get
            {
                return this.hashTableArray;
            }
            set
            {
                this.hashTableArray = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }   
    }
}
