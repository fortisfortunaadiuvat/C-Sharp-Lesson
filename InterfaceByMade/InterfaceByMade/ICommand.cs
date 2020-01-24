using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceByMade
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
