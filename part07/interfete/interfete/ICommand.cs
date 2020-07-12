using System;
using System.Collections.Generic;
using System.Text;

namespace interfete
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
