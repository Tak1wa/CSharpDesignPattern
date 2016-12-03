using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPattern._01_iterator
{
    interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}
