using System;
using System.Collections.Generic;
using System.Text;

namespace System.Forest.Services
{
    public class BranchConstructor : IBranchConstructor
    {
        public IBranch Construct<T>(string name, IBranch previous) where T : IBranch
        {
            return (IBranch)Activator.CreateInstance(typeof(T), new object[] { name, previous });
        }
    }
}
