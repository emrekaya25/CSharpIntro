List<string> sehirler = new List<string>();
sehirler.Add("Ankara");
sehirler.Add("Ankara2");
sehirler.Add("Ankara3");
sehirler.Add("Ankara4");
sehirler.Add("Ankara5");
Console.WriteLine(sehirler.Count);

MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Ankara");
sehirler2.Add("Ankara2");
sehirler2.Add("Ankara3");
sehirler2.Add("Ankara4");
Console.WriteLine(sehirler2.Count);

class MyList<T> // T = type
{
    T[] _array;
    T[] _tempArray;

    public MyList()
    {
        T[] array = new T[0];
        _array = array;
        // _array = new T[0];
    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_array.Length+1]; // eleman sayısını 1 artırdık ama her newlediğimizde bütün verilerimiz gidiyor bu yüzden verileri yedekleyip artırıcaz.

        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i]; // burdada yedeklediğimiz verileri yeni array e atıyoruz.
        }
        _array[_array.Length-1] = item;
    }


    public int Count // kendi count fonksiyonumuzu yazdık.
    {
        get { return _array.Length; } // count sadece okunabilir olacağı için set i sildik.
        
    }

}
