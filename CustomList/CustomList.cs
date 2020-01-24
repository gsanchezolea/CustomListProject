using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] array;
        public int Count;
        public int Capacity;
        public int AddedCapacity;
        


        public CustomList()
        {
            Capacity = 4;
            Count = 0;
            AddedCapacity = 2;

            array = new T[Capacity];            
        }

        //Member Variables
        public void Add(T parameter)
        {

            if (Count == Capacity)
            {
                IncreaseCapacity();
                CopyTo();
               
            }
            array[Count] = parameter;
            Count++;

        }
        public void IncreaseCapacity()
        {
            Capacity *= AddedCapacity;
        }
        public void CopyTo()
        {
            T[] collection = array;
            array = new T[Capacity];
            for (int i = 0; i < Count; i++)
            {
                array[i] = collection[i];
            }
        }
        public T this[int i]
        {
            get 
            { 
                return array[i]; 
            }
            set 
            {
                array[i] = value; 
            }
        }
    }
}



