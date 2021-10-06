using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorApp
{
    class ColorsLetter
    {
        char letter = 'A';
        public IEnumerable GetEnumerator(int size) 
        {
            for (int i = 0; i < size; i++)
            {
                yield return (char)(letter + i);
            }
        }

    }
}
