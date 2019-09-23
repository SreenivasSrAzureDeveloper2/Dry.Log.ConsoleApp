using System;
using System.Collections.Generic;
using System.Text;

namespace Dry.Log
{
    public interface IDryLog
    {
        void Debug(string message, string statuCode);
        void Info(string message, string statuCode);
        void Fatal(string message, string statuCode);

    }
}
