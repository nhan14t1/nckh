using NCKH.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCKH.Services
{
    public class PointsService
    {
        private TestEntities entities;

        public PointsService()
        {
            entities = new TestEntities();
            entities.Configuration.LazyLoadingEnabled = false;
        }

        public List<tblPoint> GetAll()
        {
            return entities.tblPoints.ToList();

        }

        public tblPoint Get(int pointId)
        {
            return entities.tblPoints.FirstOrDefault(_ => _.PointId == pointId);
        }
    }
}