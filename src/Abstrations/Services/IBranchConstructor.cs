
namespace System.Forest.Services
{
    public interface IBranchConstructor
    {
        IBranch Construct<T>(string name, IBranch previous) where T : IBranch;
    }
}
