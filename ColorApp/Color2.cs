using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorApp
{
    class Color2
    {
        string[] colors = new string[] { "Red", "Black", "Green", "White", "Rose", "Blue" };
        public IEnumerable GetEnumerator() 
        {
            foreach (var item in colors)
            {
                yield return item;
            }
        }
    }
}
