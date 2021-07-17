using System;

namespace MArrayList
{
    class MArrayList<T>
    {
        int count;
        T[] mArrayList;
        public MArrayList()
        {
            count = 0;
            mArrayList = new T[1];
        }

        void Add(T val)
        {
            int arrayLength = mArrayList.Length;
            if(arrayLength == count)
            {
                // Create new Array with doubled size and copy all elements to the new array.
                T[] newTempArray = new T[mArrayList.Length * 2];
                for (int i = 0; i < mArrayList.Length; i++)
                {
                    newTempArray[i] = mArrayList[i];
                }
                mArrayList = new T[newTempArray.Length];
                mArrayList = newTempArray;
            }
            mArrayList[count] = val;
            count++;
        }

        void Remove(T val)
        {

        }

        void RemoveAt(int index)
        {

        }
    }
}