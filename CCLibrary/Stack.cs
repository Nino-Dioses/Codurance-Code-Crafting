
using System;
using System.Collections.Generic;

namespace CCLibrary
{
    public class Stack
    {
        List<Object> objList;

        public Stack()
        {
            objList = new List<Object>();
        }

        public void Push(Object obj)
        {
            objList.Add(obj);
        }

        public Object Pop()
        {
            if (objList.Count <= 0)
                throw new Exception();

            var result = objList[objList.Count - 1];
            objList.RemoveAt(objList.Count - 1);

            return result;
        }

        public int Count()
        {
            return objList.Count;
        }
    }
}
