using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern._01_iterator
{
    class MyStudentIterator : IIterator
    {
        private MyStudentList myStudentList;
        private int index;

        public MyStudentIterator(MyStudentList list)
        {
            myStudentList = list;
            index = 0;
        }

        public bool HasNext()
        {
            if(myStudentList.GetLastNum() > index)
            {
                return true;
            }   
            else
            {
                return false;
            }
        }

        public object Next()
        {
            var s = myStudentList.GetStudentAt(index);
            index++;
            return s;
        }
    }
}
