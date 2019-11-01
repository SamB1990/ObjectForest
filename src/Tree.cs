using System.Collections.Generic;
using System.Linq;

namespace System.Forest
{
    public abstract class Tree : ITree
    {
        protected Tree()
        {
            Leaves = new Dictionary<string, object>();
            Branches = new List<IBranch>();
        }

        public Dictionary<string, object> Leaves { get; }

        public List<IBranch> Branches { get; }

        public IBranch CurrentBranch { get; set; }
    }
}
