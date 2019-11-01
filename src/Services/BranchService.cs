using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace System.Forest.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchConstructor _branchConstructor;

        public BranchService(IBranchConstructor branchConstructor)
        {
            _branchConstructor = branchConstructor;
        }

        public void AddLeaves(IBranch currentBranch, IDictionary<string, object> leaves)
        {
            var exception = currentBranch.Leaves.MergeWithRollback((IDictionary)leaves);
            if (exception != null)
                throw exception;
        }

        public void AddLeaf(IBranch currentBranch, string identifier, object leaf)
        {
            currentBranch.Leaves.Add(identifier, leaf);
        }

        public IBranch AddBranch<T>(IBranch currentBranch, string name) where T : IBranch
        {
            var branch = _branchConstructor.Construct<T>(name, currentBranch);
            currentBranch.Branches.Add(branch);
            return branch;
        }

        public IEnumerable<object> GetNearbyLeaves(IBranch currentBranch)
        {
            return currentBranch.Leaves.Select(l => l.Value);
        }
    }
}
