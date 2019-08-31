using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace CS19_ObserableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
               //Tạo tập hợp chứa các chuỗi, và bắt sự kiện khi tập hợp thay đổi
            ObservableCollection<String> obs = new ObservableCollection<String>();
            obs.CollectionChanged += change;

            //Thay các phần tử tập hợp
            obs.Add("ZTest1");
            obs.Add("DTest2");
            obs.Add("ATest3");
            obs[2] = "AAAAA";
            
            obs.RemoveAt(1);
            obs.Clear();

        }

        private static void change(object sender, NotifyCollectionChangedEventArgs e) 
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (String s in e.NewItems)
                        Console.WriteLine($"Thêm :  {s}");
                    break;

                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Clear");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    foreach (String s in e.OldItems)
                        Console.WriteLine($"Remove :  {s}");
                    break;
                case NotifyCollectionChangedAction.Replace:                
                    Console.WriteLine("Repaced - " + e.NewItems[0]);
                break;
            }
        }
    }
}
