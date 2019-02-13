using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCKH.DTO
{
    public class Point
    {
        public int PointId { get; set; }
        public string Address { get; set; }
        public float PointX { get; set; }
        public float PointY { get; set; }

        public Point(int pointId, string address, float pointX, float pointY)
        {
            PointId = pointId;
            Address = address;
            PointX = PointX;
            PointY = pointY;
        }

        public Point(string address, float pointX, float pointY)
        {
            Address = address;
            PointX = PointX;
            PointY = pointY;
        }
    }
}