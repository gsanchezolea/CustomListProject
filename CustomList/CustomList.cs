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
        private int count = 0;
        public int Count { get { return count; } }
        public int Capacity;
        public int AddedCapacity;
        


        public CustomList()
        {
            Capacity = 4;       
            AddedCapacity = 2;
           

            array = new T[Capacity];            
        }

        //Member Variables
        public void Add(T parameter)
        {

            if (count == Capacity)
            {
                IncreaseCapacity();
                CopyTo();
               
            }
            array[count] = parameter;
            count++;

        }
        public void IncreaseCapacity()
        {
            Capacity *= AddedCapacity;
        }
        public void CopyTo()
        {
            T[] collection = array;
            array = new T[Capacity];
            for (int i = 0; i < count; i++)
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

        public void Remove(T parameter)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(parameter))
                {
                    array[i].Equals(default);
                    for (int j = i; j < count; j++)
                    {
                        array[i].Equals(array[i + 1]);
                    }
                    array[i].Equals(default);
                    count--;                 
                }
            }            
        }
    }
}



