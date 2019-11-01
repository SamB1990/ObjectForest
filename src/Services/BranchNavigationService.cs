using System.Linq;

namespace System.Forest.Services
{
    public class BranchNavigationService : IBranchNavigationService
    {
        public void StepDown(ITree tree, int id)
        {
            tree.CurrentBranch = tree.CurrentBranch == null ? tree.Branches.Single(b => b.Id == id) : tree.CurrentBranch.Branches.Single(b => b.Id == id);
        }

        public void StepUp(ITree tree)
        {
            tree.CurrentBranch = tree.CurrentBranch?.PreviousBranch;
        }
    }
}
