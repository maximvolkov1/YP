using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaVolkov.AppData
{
    internal class Connect
    {
        public static  HREntities6 a;
        public static HREntities6 context
        {
            get
            {
                if (a == null)
                    a = new HREntities6();
                return a;
            }
        }
    }
}
