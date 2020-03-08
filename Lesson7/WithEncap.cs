using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    class WithEncap
    {
        public int notProtected;
        private int isProtected;

        public WithEncap()
        {
            notProtected = 1;
            isProtected = 1;
        }

        public void UpdatePrivateProperty(int newValue)
        {
            if (newValue < 0)
            {
                isProtected = newValue;
            }
        }
    }
}
