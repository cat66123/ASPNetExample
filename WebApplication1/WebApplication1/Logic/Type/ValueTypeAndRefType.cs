using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Logic.Type
{
    /*
            ValueTypeAndRefType newType = new ValueTypeAndRefType();
            int age = 1;
            newType.changeByValue(ref age);//age:100
            string name = "zs";
            newType.changeByRef(ref name);
            ViewBag.Cat66 = name;//name:abc 实际上因为string不可变，也是开辟了新的空间，只是把name的指向改成了新的变量指向

    */
    public class ValueTypeAndRefType //类是引用类型，通过调用类，再去改里面的值，那么该实例化类的该值也会被改掉
    {
        public int valueType = 3;

        public int method()
        {
            int age = 10;//堆栈

            isValueType(age);
            return age; //10
        }

        public void isValueType(int val)
        {
            val = 20;
        }

        public void changeByValue(ref int val)
        {
            val = 100;
        }
        public void changeByRef(ref string val)
        {
            val = "abc";
        }

        public void outRef(out int x,ref int y,ref int z)
        {
            x = 2;
            y = 1;
        }
    }



    /*
            //is,as
            object o = new object();
            if (o is int)//引用类型转换，装箱，拆箱
            {
                ViewBag.Cat66 = "yes";
            }
            else
            {
                ViewBag.Cat66 = "no";
            }

            string n = null;
            object m = n as object;//两个引用之间进行转换
            if (m == null)
            {
                ViewBag.Cat66 = "no";
            }
            else
            {
                ViewBag.Cat66 = m;
            }
     
     */
}
