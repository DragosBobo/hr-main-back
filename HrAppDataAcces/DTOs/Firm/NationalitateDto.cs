using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Firm
{
    public class NationalitateDto
    {
        public string Nume { get; set; }
        public NationalitateEntity ToModel()
        {
            return new NationalitateEntity()
            {
                Nume = Nume,
                Id = Guid.NewGuid(),
            };
        }
    }
}
