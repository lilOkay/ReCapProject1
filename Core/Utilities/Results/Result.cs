using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
                                           //yani aşadaki :this(succes) ile 2 ctoruda çalışmasını sağlıyoruz              
        public Result(bool succes, string message):this(succes)//result classının tek parametreli ctoruna succesi yolla demek
        {
            Message = message;//aşağıdaki Messageyi message olara set et diyoruz ctro un için de olduğumuz için set edbiliyoruz
            //Succes = succes; buradaki Succesi commentledim çünkü kendimizi tekrar etmiş olacaktık
        }

        public Result(bool succes)
        {
            Succes = succes;
        }

        public bool Succes { get; }

        public string Message { get; }
    }
}
