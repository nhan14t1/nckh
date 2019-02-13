using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCKH.DTO
{
    public class PointDetails
    {
        public int Id { get; set; }
        public int PointId { get; set; }
        public DateTime DateReceived { get; set; }
        public float Strain { get; set; }
        public float Temperature { get; set; }
        public float Stress { get; set; }

        public PointDetails (int id, int pointId, DateTime dateReceived, float strain, float temperature, float stress)
        {
            Id = id;
            PointId = pointId;
            DateReceived = dateReceived;
            Strain = strain;
            Temperature = temperature;
            Stress = stress;
        }

        public PointDetails(int pointId, DateTime dateReceived, float strain, float temperature, float stress)
        {
            PointId = pointId;
            DateReceived = dateReceived;
            Strain = strain;
            Temperature = temperature;
            Stress = stress;
        }
    }
}