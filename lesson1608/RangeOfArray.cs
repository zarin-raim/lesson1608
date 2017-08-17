using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson1608
{
    public class RangeOfArray
    {
        private object[] _array;
        private int _size;
        private int _start;
        private int _end;

        #region Constructors
        public RangeOfArray()
        {
            Size = 0;
            _array = new object[Size];
        }

        public RangeOfArray(int size)
        {
            Size = size;
            Start = 0;
            End = Size - 1;
            _array = new object[Size];
        }

        public RangeOfArray(int start, int end)
        {
            Start = start;
            End = end;
            Size = end - start + 1;         // -4 -3 -2 -1 0 1 2  s7 i6  2--4=6i +1=7s
            _array = new object[Size];
        }

        #endregion

        #region Accessors
        public int Start
        {
            get { return _start; }
            set
            {
                if (value > End)
                {
                    _start = value;
                    SwapIndices();
                }
            }
        }
        public int End
        {
            get { return _end; }
            set
            {
                if (value < Start)
                {
                    _end = value;
                    SwapIndices();
                }
            }
        }
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public object this[int i]
        {
            get
            {
                return _array[i + Math.Abs(Start)];
            }
            set
            {
                _array[i + Math.Abs(Start)] = value;
            }
        }
        #endregion

        #region Methods

        private int GetRealPosition(int position)
        { return position + Math.Abs(Start); }
        private void SwapIndices()
        {
            int temp = Start;
            Start = End;
            End = temp;
        }

        public void Add(object value, int position)
        {
            object[] temp = new object[Size + 1];
            position = (position >= Start && position <= End) ? GetRealPosition(position) : throw (new IndexOutOfRangeException());

            if (position == 0)
            {
                temp[0] = value;
                _array.CopyTo(temp, 1);
            }
            else if (position == Size)
            {
                _array.CopyTo(temp, 0);
                temp[position] = value;
            }
            else if (position < Size)
            {
                for (int i = 0; i < position; i++)
                {
                    temp[i] = _array[i];
                }
                temp[position] = value;
                for (int i = position + 1; i < temp.Length; i++)
                {
                    temp[i] = _array[i - 1];
                }
            }
            else if (position > Size)
            {
                temp = new object[position];
                _array.CopyTo(temp, 0);
                temp[position - 1] = value;
            }
            Size++;
            _array = temp;
        }

        public void Rewrite(object value, int position)
        {
            position = (position >= Start && position <= End) ? GetRealPosition(position) : throw (new IndexOutOfRangeException());
            _array[position] = value;
        }

        public void RemoveByPosition(int position)
        {
            object[] temp = new object[Size + 1];
            position = (position >= Start && position <= End) ? GetRealPosition(position) : throw (new IndexOutOfRangeException());

            if (position == 0)
            {
                _array.CopyTo(temp, 1);
            }
            else if (position == Size)
            {
                _array.CopyTo(temp, 0);
            }
            else if (position < Size)
            {
                for (int i = 0; i < position; i++)
                {
                    temp[i] = _array[i];
                }
                for (int i = position + 1; i < temp.Length; i++)
                {
                    temp[i] = _array[i - 1];
                }
            }
            else if (position > Size)
            {
                temp = new object[position];
                _array.CopyTo(temp, 0);
            }
            Size--;
            _array = temp;
        }

        public void Remove(object value)
        {
            int position = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                object temp = _array[i];
                if (temp.Equals(value))
                    position = i;
            }
            RemoveByPosition(position);
        }

        #endregion
    }
}
