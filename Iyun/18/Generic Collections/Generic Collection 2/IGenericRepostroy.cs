using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_2
{
    public interface IGenericRepostroy<T>
    {
        void Add(T data);
        void UpDate(T data);
        void Get(T data);
        void Delete(T data);
    }
}
