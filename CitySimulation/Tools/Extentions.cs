﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CitySimulation.Tools
{
    public static class Extentions
    {
        public static TSource MinBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector)
        {
            return source.MinBy(selector, null);
        }

        public static TSource MinBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector, IComparer<TKey> comparer)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");
            comparer ??= Comparer<TKey>.Default;

            using (var sourceIterator = source.GetEnumerator())
            {
                if (!sourceIterator.MoveNext())
                {
                    throw new InvalidOperationException("Sequence contains no elements");
                }
                var min = sourceIterator.Current;
                var minKey = selector(min);
                while (sourceIterator.MoveNext())
                {
                    var candidate = sourceIterator.Current;
                    var candidateProjected = selector(candidate);
                    if (comparer.Compare(candidateProjected, minKey) < 0)
                    {
                        min = candidate;
                        minKey = candidateProjected;
                    }
                }
                return min;
            }
        }

        public static IEnumerable<(int, T)> Number<T>(this IEnumerable<T> source, int start = 0)
        {
            return Enumerable.Range(start, source.Count()).Zip(source);
        }

        public static List<T> PopItems<T>(this List<T> source, Predicate<T> predicate)
        {
            var sublist = source.Where(x => predicate(x)).ToList();
            source.RemoveAll(predicate);
            return sublist;
        }
        public static List<T> PopItems<T>(this List<T> source, int count, int index = 0)
        {
            int min = Math.Min(source.Count - index, count);
            var sublist = source.GetRange(index, min);
            source.RemoveRange(index, min);
            return sublist;
        }

        public static T GetRandom<T>(this IEnumerable<T> source, Random rand)
        {
            return source.Skip(rand.Next(source.Count())).First();
        }
        public static T GetRandomOrNull<T>(this IEnumerable<T> source, Random rand)
        {
            if (source.Any())
            {
                return source.Skip(rand.Next(source.Count())).First();
            }

            return default(T);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random rand)
        {
            return source.OrderBy(x => rand.Next());
        }

        public static R ConvertArray<T, R>(this T[] array, Func<T[], R> func)
        {
            return func(array);
        }
    }
}
