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
        //Indexer
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
        public bool Remove(T parameter)
        {
            bool initiateTransfer = false;
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(parameter))
                {
                    initiateTransfer = true;
                }
                if (initiateTransfer == true)
                {
                    if (count == i + 1)
                    {
                        array[i] = default;
                        count--;
                    }
                    else
                    {
                        array[i] = array[i + 1];                       
                    }
                    
                }
                
            }           
            return initiateTransfer;
        }

        public override string ToString()
        {
            StringBuilder newSB = new StringBuilder(100);
            for (int i = 0; i < count; i++)
            {
                if ((i + 1) == count)
                {
                    newSB.Append(array[i]);
                }
                else
                {
                    newSB.Append(array[i]);
                    newSB.Append(" ");
                }
            }
            return newSB.ToString();
        }
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> customList = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                customList.Add(listOne[i]);
            }
            for (int i = 0; i < listTwo.count; i++)
            {
                customList.Add(listTwo[i]);
            }
            return customList;

        }
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> customList = new CustomList<T>();

            for (int i = 0; i < listOne.count; i++)
            {              
                customList.Add(listOne[i]);
                for (int j = 0; j < listTwo.count; j++)
                {
                    customList.Remove(listTwo[j]);
                }
            }
            return customList;
        }
    }
}

//if(customList[i].Equal(listTwo))
//customList.Remove(listTwo[j]);

