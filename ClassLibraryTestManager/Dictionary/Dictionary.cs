using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClassLibraryTestManager
{
    [Serializable]
    public class Dictionary<K, V>
    {
        [JsonProperty("FirstNode")]
        private Node<K, V> FirstNode { get; set; }
        [JsonProperty("Count")]
        public int Count { get; private set; }
        [JsonProperty("Keys")]
        public List<K> Keys
        {
            get 
            {
                List<K> keys = new List<K>();
                Node<K, V> node = FirstNode;
                while(node != null)
                {
                    keys.Add(node.Key);
                    node = node.NextNode;
                }
                return keys;
            }
        }

        public Dictionary()
        {
            FirstNode = null;
            Count = 0;
        }

        public void Add(K key, V value)
        {
            Node<K, V> node = new Node<K, V>(key, value);
            if (FirstNode == null)
            {
                Count++;
                FirstNode = node;
                return;
            }
            Node<K, V> curNode = FirstNode;
            while (true)
            {
                if (Equals(curNode.Key, node.Key))
                {
                    return;
                }
                if (curNode.NextNode == null)
                {
                    Count++;
                    curNode.NextNode = node;
                    break;
                }
                curNode = curNode.NextNode;
            }
        }
        public void Remove(K key)
        {
            if (FirstNode == null)
            {
                return;
            }
            if (Equals(FirstNode.Key, key))
            {
                if (FirstNode.NextNode != null)
                {
                    FirstNode = FirstNode.NextNode;
                }
                else
                {
                    FirstNode = null;
                }
                Count--;
                return;
            }
            Node<K, V> curNode = FirstNode;
            while (curNode.NextNode != null)
            {
                if (Equals(curNode.NextNode.Key, key))
                {
                    curNode.NextNode = curNode.NextNode.NextNode;
                    Count--;
                    break;
                }
                curNode = curNode.NextNode;
            }
        }
        public bool Remove(K key, out V value)
        {
            value = default;
            Node<K, V> curNode = FirstNode;
            while (curNode != null)
            {
                if (Equals(curNode.Key, key))
                {
                    value = curNode.Value;
                    Remove(key);
                    return true;
                }
                curNode = curNode.NextNode;
            }
            return false;
        }
        public bool ContainsKey(K key)
        {
            Node<K, V> curNode = FirstNode;
            while (curNode != null)
            {
                if (Equals(curNode.Key, key))
                {
                    return true;
                }
                curNode = curNode.NextNode;
            }
            return false;
        }
        public bool ContainsValue(V value)
        {
            Node<K, V> curNode = FirstNode;
            while (curNode != null)
            {
                if (curNode.Value.Equals(value))
                {
                    return true;
                }
                curNode = curNode.NextNode;
            }
            return false;
        }
        public bool TryGetValue(K key, out V value)
        {
            value = default;
            Node<K, V> curNode = FirstNode;
            while (curNode != null)
            {
                if (Equals(curNode.Key, key))
                {
                    value = curNode.Value;
                    return true;
                }
                curNode = curNode.NextNode;
            }
            return false;
        }
        public bool TryAdd(K key, V value)
        {
            int count = Count;
            Add(key, value);
            return count != Count;
        }
        public void Clear()
        {
            Count = 0;
            FirstNode = null;
        }
        public V this[K key]
        {
            get
            {
                Node<K, V> curNode = FirstNode;
                while (curNode != null)
                {
                    if (Equals(curNode.Key, key))
                    {
                        return curNode.Value;
                    }
                    curNode = curNode.NextNode;
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                Node<K, V> curNode = FirstNode;
                while (curNode != null)
                {
                    if (Equals(curNode.Key, key))
                    {
                        curNode.Value = value;
                        return;
                    }
                    curNode = curNode.NextNode;
                }
                throw new IndexOutOfRangeException();
            }
        }
    }
}
