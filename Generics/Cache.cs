using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Cache<TKey,TValue>
    {
        Dictionary<TKey, TValue> dic;
        int Capacity;
        LinkedList<TKey> LRUlist ;
        
        
        public Cache(int capacity)
        {
            Capacity = capacity;
            dic = new Dictionary<TKey, TValue>(Capacity);
            LRUlist = new LinkedList<TKey>();
        }

       
        public void Add(TKey key, TValue value)
        {
            if (dic.ContainsKey(key))
            {
                dic[key] = value;
                LRUlist.Remove(key);
                LRUlist.AddFirst(key);
            }
            else 
            {
                if (dic.Count >= Capacity) 
                {
                    TKey LRUitem = LRUlist.Last.Value;
                    LRUlist.RemoveLast();
                    dic.Remove(LRUitem);
                }
                dic.Add(key, value);
                LRUlist.AddFirst(key);

            }
        }
        public void getLRUList()
        {
            Console.Write("LRU List : ");
            foreach (var item in LRUlist) 
            { 
                Console.Write($"{item}  ");
            }
        }
        public void Remove (TKey key)
        {
            if (dic.ContainsKey(key))
            {
                dic.Remove(key);
                LRUlist.Remove(key);
                Console.WriteLine("Removed Successfully.");
            }
            else
            {
                throw new KeyNotFoundException($"Key '{key}' not found in cache.");
            }
        }
        public TValue retrieve(TKey key ) 
        {
            if (dic.TryGetValue(key,out TValue value))
            {
                LRUlist.Remove(key);
                LRUlist.AddFirst(key);
                return value;
            } else
            {
                throw new KeyNotFoundException($"Key '{key}' not found in cache.");
            }
        }
    }
}
