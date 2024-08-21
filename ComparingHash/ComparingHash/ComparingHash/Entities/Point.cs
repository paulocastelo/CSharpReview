﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingHash.Entities
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Point p = (Point)obj;
            return X == p.X && Y == p.Y;
        }
        public override int GetHashCode()
        {
            return X ^ Y;
        }
    }
}
