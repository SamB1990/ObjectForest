
namespace System.Forest.Services
{
    public interface IBranchNavigationService
    {
        void StepDown(ITree tree, int id);

        void StepUp(ITree tree);
    }
}
