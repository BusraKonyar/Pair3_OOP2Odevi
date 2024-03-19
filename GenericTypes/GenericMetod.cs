using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public class GenericMethod<T>
    {
        public T[] _dizi = new T[5];

        public void VeriEkle(int index, T data)
        {
            if (index >= 0 && index < 5)
            {
                _dizi[index] = data;
            }

        }

        //method overload yaptık

        public void VeriEkle(string index, T data)
        {
            //komutlar
        }

        public void VeriEkle(T index, T data)
        {
            //komutlar
        }

        public void VeriEkle(T data)
        {
            //komutlar
        }
        public void VeriEkle(int index)
        {
            //komutlar
        }

       
    }
}
