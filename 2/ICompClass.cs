using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class MyClass :IComparable<MyClass>  
    {
        public int idNumber { get; set; }
        public string Value { get; set; }


     
        public MyClass(int id, string value)
        {
            idNumber = id;
            Value = value;
        }

        public int CompareTo(MyClass? other)
        {
            return idNumber.CompareTo(other.idNumber);
        }

        public override string ToString() { return idNumber.ToString() + "\t" + Value; }
    }


    internal class MyClass1 : IComparable<MyClass1>
    {
        public int idNumber { get; set; }
        public string Value { get; set; }



        public MyClass1(int id, string value)
        {
            idNumber = id;
            Value = value;
        }

        public int CompareTo(MyClass1 other)
        {
            return idNumber.CompareTo(other.idNumber);
        }
    }

    internal class MyClass2
    {
        public int idNumber { get; set; }
        public string Value { get; set; }



        public MyClass2(int id, string value)
        {
            idNumber = id;
            Value = value;
        }

    }
}
