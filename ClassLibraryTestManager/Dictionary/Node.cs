using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClassLibraryTestManager
{
    [Serializable]
    public class Node<K, V>
    {
        [JsonProperty("Value")]
        public V Value { get; set; }
        [JsonProperty("Key")]
        public K Key { get; set; }
        [JsonProperty("NextNode")]
        public Node<K, V> NextNode { get; set; }
        public Node()
        {
            NextNode = null;
        }
        public Node(K key, V value, Node<K, V> nextNode)
        {
            Key = key;
            Value = value;
            NextNode = nextNode;
        }
        public Node(K key, V value)
        {
            Key = key;
            Value = value;
        }
    }
}
