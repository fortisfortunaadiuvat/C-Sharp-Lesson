using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceByMade
{
    class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
