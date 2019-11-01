using System.Collections.Generic;

namespace System.Forest.Services
{
    public interface ITreeService
    {
        void AddLeaves(ITree tree, IDictionary<string, object> leaves);

        void AddLeaf(ITree tree, string identifier, object leaf);

        IBranch AddBranch<T>(ITree tree, string name, bool follow = false) where T : IBranch;

        IEnumerable<object> GetNearbyLeaves(ITree tree);
    }
}
