using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()//constructor
        {
            items = new T[0];/*dizinin 0 elemanlı olduğunu belirttik bu işlemi 
        yapmasaydık eleman ekleme işlemi yapamayacaktık.*/
        }
        public void Add(T item)
        {
            T[] tempArray = items;/*geçici diznin referansı itemsın referansına eşit. Dizinin elemanlarının 
                                   * referans değerleri kaybolmaması için bu işlem yapılır.
                                   Geçici arrayi tutmamızın sebebi önceki değerleri korumak için kullanılır.*/
            
            items = new T[items.Length+1];//diziye eleman eklerken ilk olarak dizinin eleman sayısını önce 1 arttırmak gerekiyor.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1]=item;
        }
    }
}
