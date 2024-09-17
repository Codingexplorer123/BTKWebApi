using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IDataShaper<T>
    {
        IEnumerable<ExpandoObject> ShapeDate(IEnumerable<T> entities, string fieldsString);
        ExpandoObject ShapeDate(T entities, string fieldsString);
    }
}
