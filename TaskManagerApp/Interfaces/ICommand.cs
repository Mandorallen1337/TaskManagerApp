﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApp.Interfaces
{
    public interface ICommand
    {
        void Execute(Task task);
    }
}
