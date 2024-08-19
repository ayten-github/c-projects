using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19hw
{
    public class Helper
    {
        public static void Add<T>(T someting, ref List<T> list)
        {
            list.Add(someting);

        }
        public static void Remove<T>(T searched, ref List<T> changed)
        {
            foreach (T someting in changed) { 
            
            
            }
        }
    }
}
