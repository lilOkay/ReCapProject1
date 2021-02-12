using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {//burada base dediğimiz şey Resulttur
        public SuccessResult(string message):base(true,message)
        {

        }
        public SuccessResult():base(true) //:base()true) demek base e yani resulta ture gönderiyor    trueyu default verdik
        {
            
        }
    }
}
