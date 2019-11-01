using System.Collections.Generic;
using System.Linq;

namespace System.Forest
{
    public class Branch : IBranch
    {
        public Branch(string name, IBranch previous)
        {
            Branches = new List<IBranch>();

            Leaves = new Dictionary<string, object>();

            Id = (previous?.Branches.Count() ?? 0) + 1;

            Level = (previous?.Level ?? 0) + 1;

            Name = name;

            PreviousBranch = previous;
        }

        public int Id { get; }

        public string Name { get; }

        public int Level { get; }

        public IBranch PreviousBranch { get; }

        public List<IBranch> Branches { get; }

        public Dictionary<string, object> Leaves { get; }

    }
}
