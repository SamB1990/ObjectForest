using System.Collections.Generic;

namespace System.Forest
{
    public interface ITree
    {
        Dictionary<string, object> Leaves { get; }

        List<IBranch> Branches { get; }

        IBranch CurrentBranch { get; set; }
    }
}
