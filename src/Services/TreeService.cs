using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace System.Forest.Services
{
    public class TreeService : ITreeService
    {
        private readonly IBranchService _branchService;
        private readonly IBranchConstructor _branchConstructor;

        public TreeService(IBranchService branchService, IBranchConstructor branchConstructor)
        {
            _branchService = branchService;
            _branchConstructor = branchConstructor;
        }


        public void AddLeaves(ITree tree, IDictionary<string, object> leaves)
        {
            if (tree.CurrentBranch == null)
            {
                var exception = tree.Leaves.MergeWithRollback((IDictionary)leaves);
                if (exception != null)
                    throw exception;
            }
            else
                _branchService.AddLeaves(tree.CurrentBranch, leaves);
        }

        public void AddLeaf(ITree tree, string identifier, object leaf)
        {
            if (tree.CurrentBranch == null)
            {
                tree.Leaves.Add(identifier, leaf);
            }
            else
                _branchService.AddLeaf(tree.CurrentBranch, identifier, leaf);
        }

        public IBranch AddBranch<T>(ITree tree, string name, bool follow = false) where T : IBranch
        {
            IBranch branch;
            if (tree.CurrentBranch == null)
            {
                branch = _branchConstructor.Construct<T>(name, null);
                tree.Branches.Add(branch);
            }
            else
                branch = _branchService.AddBranch<T>(tree.CurrentBranch, name);

            if (follow)
                tree.CurrentBranch = branch;

            return branch;
        }

        public IEnumerable<object> GetNearbyLeaves(ITree tree)
        {
            if (tree.CurrentBranch == null)
                return tree.Leaves.Select(l => l.Value);
            else
                return _branchService.GetNearbyLeaves(tree.CurrentBranch);
        }
    }
}
