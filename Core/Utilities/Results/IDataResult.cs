using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{//IResulttan farkı datada içermesi olucak
                       //generic kullanmamızın sebei hangi tiple çalışağımızı özel olarak biz söyleyeceğiz
    public interface IDataResult<T>:IResult
    {
        T Data { get; }//ekstradan Data verdik
    }
}
