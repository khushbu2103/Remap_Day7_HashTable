using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day7_HashTable
{
    internal class MyMapNode<K, V> 
    {
        public K Key { get; set; }
        public V Value { get; set; }
        public MyMapNode<K, V> Next { get; set; }

        public MyMapNode(K key, V value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
