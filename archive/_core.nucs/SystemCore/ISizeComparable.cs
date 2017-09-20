﻿using System.Collections.Generic;
using System.Linq;
using nucs.SystemCore;

namespace nucs.SystemCore {
    public interface ISizeComparable<in T> {
        SizeCompare Compare(T o);
    }

    public enum SizeCompare {
        Equals = 0,
        Larger = 1,
        Smaller = -1,
        /// <summary>
        /// Meaning the two objects could not be compared.
        /// </summary>
        Uncomparable = 0x7FFFFFFF
    }
}

public static class SizeComparableExtensions {
    public static T Max<T>(IEnumerable<ISizeComparable<T>> items) {
        var l = items.ToList();
        T max = default(T);
        foreach (T i in l) {
            if (((ISizeComparable<T>)i).Compare(i) == SizeCompare.Larger) {
                max = (T) i;
            }
        }
        return max;
    } 
    public static T Max<T>(IEnumerable<T> items) {
        var l = items.ToList();
        T max = l[0];
        foreach (T i in l.Skip(1)) {
            if (((ISizeComparable<T>)i).Compare(max) >= 0) { //larger or equals
                max = i;
            }
        }
        return max;
    } 
}