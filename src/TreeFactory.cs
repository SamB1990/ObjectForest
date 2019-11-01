
using System.Forest.Services;

namespace System.Forest
{
    public static class TreeFactory
    {
        public static ITreeService InitializeTreeService()
        {
            var constructor  = new BranchConstructor();
            return new TreeService(new BranchService(constructor), constructor);
        }
        public static IBranchNavigationService InitializeBranchNavigation()
        {
            return new BranchNavigationService();
        }
    }
}
