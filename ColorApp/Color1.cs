using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorApp
{
    class Color1:IEnumerable
    {
        string[] colors = new string[] { "Red", "Black", "Green", "White", "Rose", "Blue" };

        public IEnumerator GetEnumerator()
        {
            foreach (var item in colors)
            {
                if (item=="White")
                {
                    yield break;
                }
                yield return item;

            }
        }
    }
}
