using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ArrayUtils
    {
        public  T[] ReverseArray<T>( T[] ArrayList)
        {
            T value;
            int position = ArrayList.Length -1;
            for( int i =0 ; i < ArrayList.Length / 2; i++ )
            {
                value = ArrayList[i]; 
                ArrayList[i] = ArrayList[position];
                ArrayList[position] = value;
                position--;
            }
            return ArrayList;
        }



        public T FindMax<T>(T[] ArrayList ) where T : IComparable<T>
        {
            T Maxitem = ArrayList[0];
            for (int i = 0; i < ArrayList.Length; i++) 
            {
                  if (ArrayList[i].CompareTo(Maxitem) > 0)
                {
                    Maxitem = ArrayList[i];
                }
            }

            return Maxitem;
        }

    }
}
