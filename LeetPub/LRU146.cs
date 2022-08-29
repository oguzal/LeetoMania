using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Specialized;

namespace LeetPub
{
    public class LRUCache
    {
        OrderedDictionary cache = new OrderedDictionary();
        int Capacity = 0;
        public LRUCache(int capacity)
        {
            Capacity = capacity;
        }

        public int Get(int key)
        {
            if (cache.Contains(key))
            {
                int val = Convert.ToInt32(cache[key: key as Object]);
                cache.Remove(key);
                cache.Insert(0, key, val);
                return val;
            }
            else return -1;
        }

        public void Put(int key, int value)
        {
            if (cache.Contains(key as Object))
            {
                cache.Remove(key);             
                cache.Insert(0, key, value);
            }
            else
            {
                if (cache.Count == Capacity)
                {
                    cache.RemoveAt(cache.Count - 1);
                }
                cache.Insert(0, key, value);
            }
        }
    }
}

