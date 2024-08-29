using HrAppDataAcces.Entities.Revisal_entities;
using HrAppDataAcces.Entities.Revisal_entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Employees
{
    public class DetaliiSalariatStrainDto
    {
        public DateTime? DataInceputAutorizatie { get; set; }
        public DateTime? DataSfarsitAutorizatie { get; set; }
        public TipAutorizatie TipAutorizatie { get; set; }
        public DetaliiSalariatStrainEntity ToModel()
        {
            return new DetaliiSalariatStrainEntity
            {
                DataInceputAutorizatie = DataInceputAutorizatie,
                DataSfarsitAutorizatie = DataSfarsitAutorizatie,
                TipAutorizatie = TipAutorizatie,
                Id = Guid.NewGuid()
            };
        }
    }
}
