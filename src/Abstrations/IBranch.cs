using System.Collections.Generic;

namespace System.Forest
{
    public interface IBranch
    {
        int Id { get; }

        string Name { get; }

        int Level { get; }

        IBranch PreviousBranch { get; }

        List<IBranch> Branches { get; }

        Dictionary<string, object> Leaves { get; }
    }
}
