using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OtherFeatures
{
    struct Employee
    {
        public int Empno;
        public string EmpName;
        public string Display()
        {
            return string.Format($"Empno={ Empno} EmpName ={EmpName}");
        }

        public Employee(int no, string name)
        {
            Empno = no;
            EmpName = name;
        }
    }

    enum Months
    {
        jan=1 , feb , march , april,may , jun ,aug,sep,oct,nov,dec
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region struct and enum
            //Employee e = new Employee();
            //Employee e1 = new Employee(101, "arpita");
            //Console.WriteLine(e1.Display());

            //Console.WriteLine(DayOfWeek.Friday);
            //Console.WriteLine((int)DayOfWeek.Friday);

            //Console.WriteLine(Months.april + " " + (int)Months.april);
            #endregion

            #region Array
            //// int[] arr = new int[3];
            // //arr[0] = 1;
            // //arr[1] = 3;
            // //arr[2] = 9

            // int[] arr ={ 1,3,5};
            // for(int i = 0; i < arr.Length; i++)
            // {
            //     Console.WriteLine(arr[i]);
            // }
            #endregion

            #region Collection classes
            //ArrayList counntryList = new ArrayList();
            //counntryList.Add("india");
            //counntryList.Add("USA");
            //counntryList.Add("JApan");
            //counntryList.Add(1000);

            ////object initializer
            //Person person = new Person() { FirstName = "arpita", LastName = "sahoo" };
            //counntryList.Insert(0,((Person) counntryList[0]).FirstName);
            //counntryList.Insert(0, person.LastName);

            //for(int i=0;i<counntryList.Count;i++)
            //{
            //    Console.WriteLine(counntryList[i]);
            //}
            ////

            #endregion

            #region Generics
            //List<string> cityList = new List<string>();
            //cityList.Add("mumbai");

            //List<Person> pList = new List<Person>();
            //Person person1 = new Person() { FirstName = "Arpita", LastName = "Sahoo" };
            //pList.Add(person1);

            //Console.WriteLine(pList[0].FirstName);
            //foreach(Person i in pList)
            //{
            //    Console.WriteLine(i.FirstName +" " +i.LastName);
            //}
            #endregion

            #region Nullable Type
            // int x = null;// cant opass null val

            //so nullable type is used
            Nullable<int> x = 1000;
            x = null;
            int? y = null;//syntax for nullable
            y = 100;
            Console.WriteLine("addition = " +x.GetValueOrDefault(0)+y.GetValueOrDefault(0));

            if (x.HasValue)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("x is null");
            }
            #endregion
            Console.ReadLine();
        }
    }

    class  Person
    {
        //auto inplemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
