
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
                     //bana bir tane data ver birde mesaj var ama base bu işlemin sonucu datadır,işlem sonucu truedur ,buda mesajıdır
        public SuccessDataResult(T data,string message):base(data,true,message)//bu versiyonda tüm bilgileri veriyoruz
        {

        }
        public SuccessDataResult(T data):base(data,true)//mesaj olayınca girmeyen versiyon
        {

        }
        public SuccessDataResult(string message):base(default,true,message)//datayı default haliyele dödürmek çok kullanılmaz
        {

        }
        public SuccessDataResult():base(default,true)//bu versiyonda çok kullanılmazmış
        {

        }
    }
}
