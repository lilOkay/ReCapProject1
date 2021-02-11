using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccesResult:Result
    {//burada base dediğimiz şey Resulttur
        public SuccesResult(string message):base(true,message)
        {

        }
        public SuccesResult():base(true) //:base()true) demek base e yani resulta ture gönderiyor    trueyu default verdik
        {
            
        }
    }
}
