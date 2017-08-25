using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework
{
    public class Array 
    {
        private int[] _array;
      
        public Array()
        {
            Size = 1;
            _array = new int[Size];
        }

        public Array(int size)
        {
            Size = size;
            _array = new int[Size];
        }

        public int Size { get; set; }

        public int this[int i]
        {
            get
            {
                return _array[i];
            }
            set
            {
                _array[i] = (int)Math.Pow((double)value, 2);
            }
        }

    }
}
