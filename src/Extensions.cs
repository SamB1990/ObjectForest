using System.Collections;

namespace System.Forest
{
    public static class Extensions
    {
        public static Exception MergeWithRollback(this IDictionary dict, IDictionary inputDict)
        {
            try
            {
                foreach (var kvp in inputDict)
                {
                    var key = kvp.GetType().GetProperty("Key")?.GetValue(kvp);
                    var value = kvp.GetType().GetProperty("Value")?.GetValue(kvp);
                    dict.Add(key ?? throw new InvalidOperationException("Cannot find Key"), value);
                }
                return null;
            }
            catch (Exception e)
            {
                return e;
            }
        }
    }
}
