using NCKH.DAO;
using NCKH.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCKH.Services
{
    public class PointDetailsService
    {
        private readonly TestEntities entities;

        public PointDetailsService()
        {
            entities = new TestEntities();
            entities.Configuration.LazyLoadingEnabled = false;
        }

        public List<tblDetail> GetAll()
        {
            return entities.tblDetails.ToList();
        }

        public List<tblDetail> Get(int PointId)
        {
            return entities.tblDetails.Where(_ => _.PointId == PointId).ToList();
        }

        public List<tblDetail> Get(int PointId, DetailType type)
        {
            switch (type)
            {
                case DetailType.Strain:
                    return entities.tblDetails.Where(_ => _.PointId == PointId && _.Strain != null).ToList();
                case DetailType.Temperature:
                    return entities.tblDetails.Where(_ => _.PointId == PointId && _.Temperature != null).ToList();
                case DetailType.Stress:
                    return entities.tblDetails.Where(_ => _.PointId == PointId && _.Stress != null).ToList();
                default:
                    break;
            }
            return null;
        }
    }
}