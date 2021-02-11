using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //bana bir tane data ver birde mesaj var ama base bu işlemin sonucu datadır,işlem sonucu truedur ,buda mesajıdır
        public ErrorDataResult(T data, string message) : base(data, false, message)//bu versiyonda tüm bilgileri veriyoruz
        {

        }
        public ErrorDataResult(T data) : base(data, false)//mesaj olayınca girmeyen versiyon
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)//datayı default haliyele dödürmek çok kullanılmaz
        {

        }
        public ErrorDataResult() : base(default, false)//bu versiyonda çok kullanılmazmış
        {

        }
    }
}
