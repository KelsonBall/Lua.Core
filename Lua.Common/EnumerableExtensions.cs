using System.Collections.Generic;
using System.Linq;

namespace Lua.Common
{
    public static class EnumerableExtensions
    {
        public static bool HasSingle<T>(this IEnumerable<T> source) => source.Any() && !source.Skip(1).Any();

        public static T ItemIfSingle<T>(this IEnumerable<T> source) where T : class
        {
            if (!source.Skip(1).Any())
                return source.SingleOrDefault();
            return null;
        }
    }
}
