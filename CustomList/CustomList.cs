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
           // newString = new StringBuilder(" ",100);
           
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

        public bool Remove(T parameter)
        {
            bool initiateTransfer = false;


            for (int i = 0; i < count - 1; i++)
            {
                if (array[i].Equals(parameter))
                {
                    initiateTransfer = true;
                }
                if (initiateTransfer == true)
                {
                    array[i] = array[i + 1];
                    array[i + 1] = default;
                }
            }
            count--;

            EliminateLastValue();
            return initiateTransfer;

        }
        public void EliminateLastValue()
        {
            if (count == 0)
            {
                array[0] = default;
            }
        }
        public override string ToString()
        {
            StringBuilder newString = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                newString.Append(array[i]);
            }
            return newString.ToString();
            //foreach (T item in array)
            //{
            //    newString.Append(item);
            //}
            //return newString.ToString();
        }
    }
}



