using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{//DataResult bir Resulttur result özelliklerini taşır
    public class DataResult<T>: Result,IDataResult<T>
    {                                                   //bizim buradaki baseimiz Resulttur
        public bool Success;

        public DataResult(T data,bool succes,string message):base(succes ,message)//sen base de succes ve messageyi yolla
        {
            Data = data;
        }
        public DataResult(T data,bool succes):base(succes)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
