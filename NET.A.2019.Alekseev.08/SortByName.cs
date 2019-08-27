﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.A._2019.Alekseev._08
{
    public class SortByName : IComparer<Book>
    {
        public int Compare(Book lhs, Book rhs)
        {
            if (ReferenceEquals(lhs, null))
            {
                return 1;
            }
            if (ReferenceEquals(lhs, rhs))
            {
                return 0;
            }
            return lhs.CompareTo(rhs);
        }
    }
}
