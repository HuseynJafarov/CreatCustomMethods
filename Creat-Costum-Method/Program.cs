using System;

namespace Creat_Costum_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> mylist = new MyList<string>();


            mylist.Add("Huseyn");
            mylist.Add("Maqa");
            mylist.Add("Hesen");
            

            mylist.GetAll();



        }
    }





    public class MyList<T>
    {
        private T[] arr;

        public MyList()
        {
            arr = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = data;
        }

        public void Clear(T data)
        {
            Console.Clear();
        }


        public void Find(T data)
        {
            var result = data;
            foreach (var item in arr)
            {
                if (true)
                {

                    Console.WriteLine(item);
                    break;
                }

            }

        }

        //public void AddRange( MyList<string> myList)
        //{
        //    string[] name = { "Qafur", "Emil" };


        //    myList.AddRange(myList);
        //}

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
