using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern._01_iterator
{
    class MyStudentList : StudentList, IAggregate
    {
        public IIterator iterator()
        {
            return new MyStudentIterator(this);
        }
    }
}
