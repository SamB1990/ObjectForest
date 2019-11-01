

using System.Collections.Generic;

namespace System.Forest.Services
{
    public interface IBranchService
    {
        void AddLeaves(IBranch currentBranch, IDictionary<string, object> leaves);

        void AddLeaf(IBranch currentBranch, string identifier, object leaf);

        IBranch AddBranch<T>(IBranch currentBranch, string name) where T : IBranch;

        IEnumerable<object> GetNearbyLeaves(IBranch currentBranch);
    }
}
