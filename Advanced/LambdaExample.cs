using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class LambdaExample
    {
        delegate int del(int i);

        public int MyLambdaOne(int val)
        {
            //(input-parameters) => expression-or-statement-block
            del myDelegate = x => x * x;
            return myDelegate(val);
        }
    }
}
