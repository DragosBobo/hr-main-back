using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Firm
{
    public class LocalitateDto
    {
        public int CodSiruta { get; set; }
        public JudetDto Judet { get; set; }
        public LocalitateEntity ToModel()
        {
            return new LocalitateEntity
            {
                Judet = Judet.ToModel(),
                CodSiruta = CodSiruta,
                Id = Guid.NewGuid(),
            };
        }
    }
}
