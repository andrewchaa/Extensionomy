﻿using System.Collections.Generic;
using System.Linq;

namespace Extensionomy
{
    public static class CollectionExtensions
    {
        public static bool IsEmpty<T>(this IEnumerable<T> collection)
        {
            return !collection.Any();
        }
    }
}
