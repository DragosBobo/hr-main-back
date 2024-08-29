using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Firm
{
    public class DomeniuActivitateDto
    {
        public string Cod { get; set; }
        public int Versiune { get; set; }
        public DomeniuActivitateEntity ToModel()
        {
            return new DomeniuActivitateEntity()
            {
                Cod = Cod,
                Versiune = Versiune,
                Id = Guid.NewGuid(),
            };
        }
    }
}
