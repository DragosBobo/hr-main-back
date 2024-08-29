using HrAppDataAcces.Entities.Revisal_entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppDataAcces.DTOs.Firm
{
    public class JudetDto
    {
        public string Nume { get; set; }
        public string CodJudet { get; set; }
        public JudetEntity ToModel()
        {
            return new JudetEntity() { Nume = Nume, CodJudet = CodJudet, Id = Guid.NewGuid() };
        }
    }
}