using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public delegate string MyCoat(string message);

    class Coats
    {
        public event MyCoat MyEventCoat;

        // property
        public string MyResult { get; private set; }

        // Default Constructor
        public Coats()
        {
            this.MyEventCoat += new MyCoat(this.MyFavoriteCoat);
            MyResult = MyEventCoat("Trench");
        }

        //Method
        public string MyFavoriteCoat(string message)
        {
            return "My favorite coat is " + message;
        }
    }
}
