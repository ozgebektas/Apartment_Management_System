using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Core.Utilities.Results
{
    public interface IDataResult<T>
    {
        T Data { get; }
        bool Success { get; }
        string Message { get; }
    }
}
