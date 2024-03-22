using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    public static class LinqExtensions
    {
        public static IEnumerable<TSource> MyConcatMethod<TSource>(
            this IEnumerable<TSource> first,
            IEnumerable<TSource> second)
        {
            var result = new List<TSource>();

            result.AddRange(first);
            result.AddRange(second);

            return result;
        }
    }
}
